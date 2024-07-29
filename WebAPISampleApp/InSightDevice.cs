using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Cognex.InSight.Web;
using Cognex.InSight.Web.Controls;
using Cognex.SimpleCogSocket;
using Cognex.InSight.Remoting.Serialization;
using System.Net;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;
using System.Security.RightsManagement;
using System.Web;
using System.Xml.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace InSightValidationTool
{
    /// <summary>
    /// The InSightDevice class is responsible for managing the backend connection and interactions with an In-Sight vision system. 
    /// This class encapsulates all necessary properties and methods required to establish and maintain a connection, 
    /// perform various operations, and handle data exchange with the In-Sight system.
    /// </summary>

    internal class InSightDevice
    {
        public class ImageEntry
        {
            public string Path { get; set; }
            public string Filename { get; set; }
            public bool ExpectedResult { get; set; }
            public bool ActualResult { get; set; }
        }

        public string IpAddressWithPort { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool AutoConnect { get; set; }

        public bool ImageLoad { get; set; }
        public List<String> ImgsPath { get; set; }
        public JToken Results { get; set; }
        public JToken Configuration { get; set; }
        public string JobFile { get; set; }

        public CvsInSight _inSight;


        public int _startTicks;
        public string _deviceName;
        public List<ImageEntry> _imageEntries;
        public bool _imageLoaded;
        private bool _secuence;
        public TaskCompletionSource<bool> _imageProcessedSignal;
        public bool _validationResult;
        private bool _Ignore;
        private string _loggedMessages = "";





        public InSightDevice(string IPwPort,string username, string password, bool autoConnect)
        {
            IpAddressWithPort = IPwPort;
            UserName = username;
            Password = password;
            AutoConnect = autoConnect;

            _startTicks = Environment.TickCount;    

            _inSight = new CvsInSight();
            _inSight.PreviewMessage += _inSight_PreviewMessage;
            _inSight.ResultsChanged += _inSight_ResultsChanged;
            _inSight.ConnectedChanged += _inSight_ConnectedChanged;
            _inSight.ConnectingChanged += _inSight_ConnectingChanged;
            _inSight.StateChanged += _inSight_StateChanged;
            _inSight.LiveModeChanged += _inSight_LiveModeChanged;
            _inSight.JobInfoChanged += _inSight_JobInfoChanged;
            _inSight.JobLoadingChanged += _inSight_JobLoadingChanged;
            _inSight.EditorAttachedChanged += _inSight_EditorAttachedChanged;
        }

        private void _inSight_PreviewMessage(object sender, MessagePayloadPreviewEventArgs e)
        {
            string msg = (e.Payload?.ToString() ?? "");
            int len = msg.Length;

            if (msg.Length > 150)
            {
                msg = msg.Substring(0, 100) + "..." + msg.Substring(msg.Length - 50, 50);
            }

            if (_inSight.Connected)
            {
                Debug.WriteLine($"[{_deviceName}] [Len:{len}] {msg}");
            }

            if (msg.Contains("manualTrigger"))
            {
                _startTicks = Environment.TickCount;
            }
            /*
                  if (msg.Contains("resultChanged"))
                  {
                    Debug.WriteLine(String.Format("resultChanged ticks: {0}", (Environment.TickCount - _startTicks).ToString()));
                    MessageBox.Show(String.Format("resultChanged ticks: {0}", (Environment.TickCount - _startTicks).ToString()));
                  }*/
            /*
              //#if SHOW_ALL_MESSAGES
              Debug.WriteLine("Ticks: " + (Environment.TickCount - _startTicks).ToString());
              var header = e.IsIncoming ? "Incoming" : "Outgoing";
              var json = JToken.Parse((string)e.Payload);
              long id = -1;
              string objType = (string)json["$type"];

              string lenStr = (string)(e.Payload);

              if (objType != "event")
                id = (long)json["id"];

              if (e.IsIncoming)
              {
                Debug.WriteLine($"Incoming({id} {lenStr.Length}):");
              }
              else
              {
                Debug.WriteLine($"Outgoing({id} {lenStr.Length}):");
              }

              string payload = e.Payload.ToString();
              string formattedJson = payload.Substring(0,Math.Min(100,payload.Length));
              Debug.WriteLine(formattedJson);*/
            //#endif
        }

        private void _inSight_ResultsChanged(object sender, EventArgs e)
        {
          //  JToken results = _inSight.Results;
          //Results = results;
        }

        private void _inSight_ConnectedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the ConnectingChanged event by updating the controls that use the state.
        /// </summary>
        private void _inSight_ConnectingChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the StateChanged event by updating the controls that use the state.
        /// </summary>
        private void _inSight_StateChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the LiveModeChanged event by updating the controls that use the state.
        /// </summary>
        private void _inSight_LiveModeChanged(object sender, EventArgs e)
        {

        }

        private void _inSight_JobInfoChanged(object sender, EventArgs e)
        {
            // Handle sheet re-format
            _inSight_ResultsChanged(sender, e); // Be sure we re-process the result after job load


        }

        private void _inSight_JobLoadingChanged(object sender, EventArgs e)
        {

        }

        private void _inSight_EditorAttachedChanged(object sender, EventArgs e)
        {

        }

        private async void UnsubscribeEvents()
        {
            _inSight.PreviewMessage -= _inSight_PreviewMessage;
            _inSight.ResultsChanged -= _inSight_ResultsChanged;
            _inSight.ConnectedChanged -= _inSight_ConnectedChanged;
            _inSight.StateChanged -= _inSight_StateChanged;
            _inSight.LiveModeChanged -= _inSight_LiveModeChanged;
            _inSight.JobInfoChanged -= _inSight_JobInfoChanged;
            _inSight.JobLoadingChanged -= _inSight_JobLoadingChanged;
            _inSight.EditorAttachedChanged -= _inSight_EditorAttachedChanged;
            await _inSight.Disconnect();
        }


        ~InSightDevice()
        {
            UnsubscribeEvents();

        }

        public async Task Connect()
        {

            try
            {
                if (_inSight.Connected)
                {
                    await _inSight.Disconnect();
                }
                else
                {
                    HmiSessionInfo sessionInfo = new HmiSessionInfo();
                    sessionInfo.SheetName = "Inspection";
                    sessionInfo.CellNames = new string[1] { "A0:Z599" }; // Designating a cell range requires 6.3 or newer firmware
                    sessionInfo.EnableQueuedResults = true; // When the queue is frozen, then show the queued results
                    sessionInfo.IncludeCustomView = true;
                    await _inSight.Connect(IpAddressWithPort, UserName, Password, sessionInfo);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Connect error: " + ex.Message);
                MessageBox.Show("Unable to connect: " + ex.Message);
            }
        }

        public async Task LoadJob(string filename)
        {
            try
            {

                if (_inSight.Connected) await _inSight.LoadJob(filename).ConfigureAwait(false);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"LoadJob Exception: {ex.Message}");
            }

        }

        public async Task LoadImage(string imgpath)
        {
            try
            {
                if (_inSight.Connected) await _inSight.LoadImage(imgpath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"LoadImage Exception: {ex.Message}");
            }

        }

        public async Task SendImageAndWait(string imgpath)
        {
            _imageProcessedSignal = new TaskCompletionSource<bool> { };

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
            if (_inSight.Connected)
            {
                try
                {
                    await _inSight.SetSoftOnlineAsync(state);

                }
                catch (Exception)
                {
                    MessageBox.Show("Error setting soft Status. Verify that ISE is not connected.");
                }
            }
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
                    MessageBox.Show($"Live Mode Exception: {ex.Message}");
                }
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
    }
}
