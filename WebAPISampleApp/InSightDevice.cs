using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Cognex.InSight.Remoting.Serialization;
using System.Windows.Forms;
using Cognex.InSight.Web;
using MinimalisticTelnet;
using Newtonsoft.Json.Linq;

namespace InSightValidationTool
{
    internal class InSightDevice
    {
        public class NativeResponse
        {
            public enum StatusCode
            {
                CommandExecutedSuccessfully = 1,
                UnrecognizedCommand = 0,
                InvalidCellName = -1,
                CommandCouldNotBeExecuted = -2
            }

            public NativeResponse() { }
            public NativeResponse(StatusCode status, string result)
            {
                Status = status;
                Result = result;
            }

            public NativeResponse(StatusCode status)
            {
                Status = status;
                Result = "0.00";
            }

            public StatusCode Status { get; set; }
            public string Result { get; set; }

            public static NativeResponse Parse(string input)
            {
                if (string.IsNullOrEmpty(input)) return new NativeResponse();

                var parts = input.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length > 4) throw new ArgumentException("Input string is not in the expected format.");

                if (!Enum.TryParse(parts[0], out StatusCode status)) return new NativeResponse();

                return parts.Length > 1 ? new NativeResponse(status, parts[1]) : new NativeResponse(status);
            }
        }

        public class ImageEntry
        {
            public string Path { get; set; }
            public string Filename { get; set; }
            public bool ExpectedResult { get; set; }
            public bool ActualResult { get; set; }
        }

        public string IpAddressWithPort { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool AutoConnect { get; set; }

        public List<string> ImgsPath { get; set; }
        public JToken Results { get; set; }
        public JToken Configuration { get; set; }
        public string JobFile { get; set; }

        public CvsInSight _inSight;
        public int _startTicks;
        public List<ImageEntry> _imageEntries = new List<ImageEntry>();
        public TaskCompletionSource<bool> _imageProcessedSignal;
        public bool _validationResult;

        // Telnet Variables
        private const int TelnetPort = 23;
        private TelnetConnection _nativeConnection;
        private TelnetConnection _resultsConnection;
        private Thread _nativeThread;
        private bool _isConnected = false;
        public bool _imageLoaded;

        public delegate void InSightDeviceEventHandler(object sender, NativeResponse e);
        public event InSightDeviceEventHandler InSightDevice_NativeDataRecieved;

        protected virtual void onDataRecieved(NativeResponse e) => InSightDevice_NativeDataRecieved?.Invoke(this, e);

        public InSightDevice(string ipWithPort, string username, string password, bool autoConnect)
        {
            IpAddressWithPort = ipWithPort;
            UserName = username;
            Password = password;
            AutoConnect = autoConnect;

            _startTicks = Environment.TickCount;
            _inSight = new CvsInSight();
        }

        ~InSightDevice()
        {
            UnsubscribeEvents();
            _nativeConnection?.Disconnect();
        }

        public async Task Connect()
        {
            try
            {
                if (_inSight.Connected)
                {
                    await _inSight.Disconnect();
                    _isConnected = false;
                    _nativeConnection?.Disconnect();
                }
                else
                {
                    var sessionInfo = new HmiSessionInfo
                    {
                        SheetName = "Inspection",
                        CellNames = new[] { "A0:Z599" },
                        EnableQueuedResults = true,
                        IncludeCustomView = true
                    };

                    await _inSight.Connect(IpAddressWithPort, UserName, Password, sessionInfo);

                    Uri uri = new Uri("http://" + IpAddressWithPort);
                    _nativeConnection = new TelnetConnection(uri.Host, TelnetPort);

                    string nativeLogIn = _nativeConnection.Login(UserName, Password, 100);
                    if (nativeLogIn.Trim() != "User Logged In") throw new Exception("Connection failed");

                    _isConnected = true;

                    _nativeThread = new Thread(pollInSightNative)
                    {
                        IsBackground = true
                    };
                    _nativeThread.Start();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Connect error: " + ex.Message);
                MessageBox.Show("Unable to connect: " + ex.Message);
            }
        }
        public async Task ManualTrigger()
        {

            if (_inSight.Connected)
            {
                try
                {
                    await _inSight.ManualAcquire();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Live Mode Exception: {ex.Message}");
                }
            }
        }
        private void pollInSightNative()
        {
            while (_isConnected)
            {
                _nativeConnection.WriteLine("GVInSightValidation.A1");
                string response = _nativeConnection.Read();
                NativeResponse responseNative = NativeResponse.Parse(response);
                if (responseNative != null) onDataRecieved(responseNative);
                Thread.Sleep(1000);
            }
        }

        public void WriteValidationResult(string validationResult)
        {
            ExecuteTelnetCommand($"SSInSightValidation.B1 {validationResult}");
        }

        public void ResetValidationTrigger()
        {
            ExecuteTelnetCommand("SFInSightValidation.A1 0.000");
        }

        private void ExecuteTelnetCommand(string command)
        {
            try
            {
                Uri uri = new Uri("http://" + IpAddressWithPort);
                _resultsConnection = new TelnetConnection(uri.Host, TelnetPort);

                string loginResponse = _resultsConnection.Login(UserName, Password, 100).Trim();
                if (loginResponse != "User Logged In") throw new Exception("Connection Results failed");

                _resultsConnection.WriteLine(command);
                NativeResponse responseNative = NativeResponse.Parse(_resultsConnection.Read());

                Console.WriteLine(responseNative.Status == NativeResponse.StatusCode.CommandExecutedSuccessfully
                    ? "Command Executed Successfully"
                    : "Command Execution Failed");

                _resultsConnection.Disconnect();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Command Execution error: " + ex.Message);
                MessageBox.Show("Error executing command: " + ex.Message);
            }
            finally
            {
                _resultsConnection = null;
            }
        }

        public async Task LoadJob(string filename)
        {
            if (_inSight.Connected)
            {
                try
                {
                    await _inSight.LoadJob(filename).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"LoadJob Exception: {ex.Message}");
                }
            }
        }

        public async Task LoadImage(string imgpath)
        {
            if (_inSight.Connected)
            {
                try
                {
                    await _inSight.LoadImage(imgpath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"LoadImage Exception: {ex.Message}");
                }
            }
        }

        public async Task SendImageAndWait(string imgpath)
        {
            _imageProcessedSignal = new TaskCompletionSource<bool>();

            try
            {
                if (_inSight.Connected)
                {
                    await _inSight.LoadImage(imgpath);
                    await _imageProcessedSignal.Task;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"LoadImage Exception: {ex.Message}");
                _imageProcessedSignal.TrySetResult(true);
            }
        }

        public async Task SetCameraStatus(bool state)
        {
                
                
                    await _inSight.SetSoftOnlineAsync(state);
                
                
                
                    
                
            
        }

        public async Task SetLiveMode(bool state)
        {
            if (_inSight.Connected)
            {
                try
                {
                    await _inSight.SetSoftOnlineAsync(state);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error setting Live mode: {ex.Message}");
                }
            }
        }

        private async void UnsubscribeEvents()
        {
            if (_inSight != null)
            {
                await _inSight.Disconnect();
                _inSight = null;
            }
        }
    }
}