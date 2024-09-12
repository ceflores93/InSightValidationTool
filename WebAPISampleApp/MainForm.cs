//*******************************************************************************
// Copyright (C) 2021 Cognex Corporation
//
// Subject to Cognex Corporation's terms and conditions and license agreement,
// you are authorized to use and modify this sample source code in any way you find
// useful, provided the Software and/or the modified Software is used solely in
// conjunction with a Cognex Machine Vision System.  Furthermore you acknowledge
// and agree that Cognex has no warranty, obligations or liability for your use
// of the Software.
//*******************************************************************************

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
using WebAPISampleApp.Properties;
using WebAPISampleApp;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using Application = System.Windows.Forms.Application;
using System.Runtime.CompilerServices;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Channels;

namespace InSightValidationTool
{
    /// <summary>
    /// This a class that shows a simple example of a Web API application.
    /// 
    /// The application constructs a CvsInSight instance to access Web API functionality.
    /// 
    /// A PictureBox is used to render the current image.
    /// </summary>
    public partial class MainFormWindow : Form
    {
        // Holds the connection to the camera and provides an abstraction for the API
        public class ImageEntry
        {
            public string Path { get; set; }
            public string Filename { get; set; }
            public bool ExpectedResult { get; set; }
            public bool ActualResult { get; set; }
        }

        private CvsInSight _inSight;
        private int _startTicks;
        public bool m_imageloadFlag = true;
        public List<String> imgspath = null;
        public JToken m_results = null;
        public JToken m_configuration = null;
        public string m_jobFile = null;
        private List<ImageEntry> m_imageEntries = new List<ImageEntry>();
        private const int ThumbnailSize = 200; // Desired thumbnail size (width and height)
        private const int RowHeight = 100; // Desired row height
        private int m_currentIndex = 0;
        private bool m_ImagesLoaded = false;
        private bool m_Secuence = false;
        private TaskCompletionSource<bool> m_imageProcessedSignal;
        private bool m_ValidationResult = true;
        private bool m_Ignore = false;
        private bool m_mouseDown;
        private Point m_lastLocation;
        private const string version = "0.5";

        private List<string> tabResults = new List<string>();
        private bool isBlinking = false;
        private Timer TabBlinker;

        public MainFormWindow()
        {
            InitializeComponent();
            btnWindowTitle.Text += " " + version;

            //Make sure important events are declared 
         
            this.tabCtrlContent.MouseDown += TabCtrl_MouseDown;
            this.tabCtrlContent.SelectedIndexChanged += TabCtrlContent_SelectedIndexChanged;

            this.insightValidationControl1.InSightValidationControl_OnUpdate += InSightControlUpdate;
            this.insightValidationControl1.InSightValidationControl_OnJobLoad += InSightControlJobLoad;
            this.insightValidationControl1.InSightValidationControl_OnConnected += InSightControlConnected;
            this.insightValidationControl1.InSightValidationControl_OnDisconnected +=  InSightControlDisconnected;
            this.insightValidationControl1.InSightValidationControl_OnValidationStart += InSightControlValidationStart;
            this.insightValidationControl1.InSightValidationControl_OnValidationCompleted += InSightControlValidationCompleted;

            InitializeDataGridView();    
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


            this.customTabSelector1.OnCloseTabClick += TabSelector_OnCloseTabClick;
            this.customTabSelector1.OnSelectTabClick += TabSelector_OnSelectTabClick;
            this.customTabSelector1.attachedTabIndex = 0;   

            //cvsSpreadsheet.SetInSight(_inSight);
            //cvsCustomView.SetInSight(_inSight);
            //cvsDisplay.SetInSight(_inSight);
            // cvsFilmstrip.SetInSight(_inSight);

            //dgwImageResults.CellValueChanged += dgwImageResults_CellValueChanged;
            //dgwImageResults.CellDoubleClick += dgwImageResults_CellDoubleClick; 

          
        }

        private void TabCtrlContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (CustomTabSelector CustomTabSelector in flwlyTabControlButtons.Controls.OfType<CustomTabSelector>())
            {

                if (CustomTabSelector.attachedTabIndex == tabCtrlContent.SelectedIndex)
                {
                    CustomTabSelector.BorderStyle = BorderStyle.Fixed3D;
                }
                else { CustomTabSelector.BorderStyle = BorderStyle.None; }
            }



        }

        private void TabBlinker_Tick(object sender, EventArgs e)
        {
           isBlinking = !isBlinking;
            tabCtrlContent.Invalidate();    
        }

        private void InitializeDataGridView() {



            //dgwImageResults.AutoGenerateColumns = false;
            //dgwImageResults.AllowUserToAddRows = false;
            //dgwImageResults.AllowUserToDeleteRows = false;


            // Column for Thumbnail
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Image Preview";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Zoom to fit cell size
            imageColumn.Width = ThumbnailSize;
            imageColumn.Name = "ImagePreview";
            imageColumn.DataPropertyName = "Preview"; // DataPropertyName should match the property in ImageEntry
            //dgwImageResults.Columns.Add(imageColumn);

            // Column for Filename
            DataGridViewTextBoxColumn filenameColumn = new DataGridViewTextBoxColumn();
            filenameColumn.HeaderText = "Image Name";
            filenameColumn.Width = 400;
            filenameColumn.DataPropertyName = "Image Name";
            filenameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgwImageResults.Columns.Add(filenameColumn);


            // Column for Expected Result (ComboBox)
            DataGridViewComboBoxColumn expectedColumn = new DataGridViewComboBoxColumn();
            expectedColumn.HeaderText = "Expected Result";
            expectedColumn.Width = 100;
            expectedColumn.DataPropertyName = "ExpectedResult";
            expectedColumn.DisplayMember = "Text"; // Display member for the combo box
            expectedColumn.ValueMember = "Value"; // Value member for the combo box
            expectedColumn.DataSource = new List<object>
        {
            new { Text = "Pass", Value = true },
            new { Text = "Fail", Value = false }
        };
            expectedColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            expectedColumn.Name = "ExpectedResult";
            //dgwImageResults.Columns.Add(expectedColumn);

            // Column for Actual Result
            DataGridViewTextBoxColumn actualColumn = new DataGridViewTextBoxColumn();
            actualColumn.HeaderText = "Actual Result";
            actualColumn.DataPropertyName = "ActualResult";
            actualColumn.Name = "ActualResult";
            //dgwImageResults.Columns.Add(actualColumn);

            //dgwImageResults.RowTemplate.Height = RowHeight;
        }

        private void PopulateGridView() {


            m_imageEntries = LoadImagesFromPaths(imgspath);
            UpdateDataGridView();

        }


        private List<ImageEntry> LoadImagesFromPaths(List<string> imagePaths)
        {
            var imageEntries = new List<ImageEntry>();

            foreach (var imagePath in imagePaths)
            {
                string filename = Path.GetFileName(imagePath);
                imageEntries.Add(new ImageEntry
                {
                    Path = imagePath,
                    Filename = filename
                });
            }

            return imageEntries;
        }

        private string ConvertToJson(List<InSightDevice.ImageEntry> imageEntries)
        {
            return JsonConvert.SerializeObject(imageEntries);
        }

        private System.Drawing.Image ResizeImage(System.Drawing.Image originalImage, int width, int height)
        {
            // Create a new Bitmap with the desired dimensions
            Bitmap resizedImage = new Bitmap(width, height);

            // Draw the original image onto the resized image
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(originalImage, 0, 0, width, height);
            }

            return resizedImage;
        }

        private void AutoResizeRowHeights()
        {
            // Autoresize row heights based on ThumbnailSize + padding
            /*foreach (DataGridViewRow row in dgwImageResults.Rows)
            {
                int desiredHeight = ThumbnailSize + dgwImageResults.RowTemplate.DefaultCellStyle.Padding.Vertical;
                row.Height = desiredHeight;
            }*/
        }


        private void AutoResizeColumnWidths()
        {
            // Autoresize column widths to fill DataGridView
            /*int totalColumnWidths = dgwImageResults.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            int dataGridViewWidth = dgwImageResults.ClientSize.Width;

            // Adjust only if the total column widths are less than the DataGridView width
            if (totalColumnWidths < dataGridViewWidth)
            {
                foreach (DataGridViewColumn column in dgwImageResults.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }*/
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Handle form resize event to adjust column widths dynamically
            AutoResizeColumnWidths();
        }


        private  void UpdateDataGridView()
        {/*
            dgwImageResults.Invoke((Action)delegate
            {
                dgwImageResults.Rows.Clear();
                if (m_imageEntries.Count > 0) { m_ImagesLoaded = true; }

                foreach (var entry in m_imageEntries)
                {
                    DataGridViewRow row = new DataGridViewRow();


                    // Add Thumbnail (Image) column
                    DataGridViewImageCell imageCell = new DataGridViewImageCell();
                    System.Drawing.Image image = System.Drawing.Image.FromFile(entry.Path);
                    imageCell.Value = ResizeImage(image, ThumbnailSize, ThumbnailSize); // Resize image
                    row.Cells.Add(imageCell);

                    // Add Filename column
                    DataGridViewTextBoxCell filenameCell = new DataGridViewTextBoxCell();
                    filenameCell.Value = entry.Filename;
                    filenameCell.Style.ForeColor = System.Drawing.Color.White;
                    filenameCell.Style.Font = new Font("Times New Roman",16.0f,FontStyle.Bold);
                    row.Cells.Add(filenameCell);

                    // Add Expected Result (ComboBox) column
                    DataGridViewComboBoxCell expectedCell = new DataGridViewComboBoxCell();
                    expectedCell.DisplayMember = "Text";
                    expectedCell.ValueMember = "Value";
                    expectedCell.DataSource = new List<object>
                        {
                            new { Text = "Pass", Value = true },
                           new { Text = "Fail", Value = false }
                         };
                    expectedCell.Value = entry.ExpectedResult;
                    expectedCell.ReadOnly = false;
                    expectedCell.Style.ForeColor = System.Drawing.Color.White;
                    expectedCell.Style.Font = new Font("Times New Roman", 16.0f, FontStyle.Bold);


                    row.Cells.Add(expectedCell);

                    // Add Actual Result (CheckBox) column
                        
                    DataGridViewTextBoxCell actualCell = new DataGridViewTextBoxCell();
                    actualCell.Value = entry.ActualResult ? "Pass" : "Fail";
                    actualCell.Style.ForeColor = System.Drawing.Color.White;
                    actualCell.Style.Font = new Font("Times New Roman", 16.0f, FontStyle.Bold);

                    //Color Background based on results
                    if ((bool)expectedCell.Value != entry.ActualResult) row.DefaultCellStyle.BackColor = Color.Red; else row.DefaultCellStyle.BackColor = Color.Green;  

                    row.Cells.Add(actualCell);

                    // Add the row to the DataGridView
                    dgwImageResults.Rows.Add(row);
                    AutoResizeRowHeights();
                    AutoResizeColumnWidths();
                    UpdateValidationResult();   
                    

                }
            });

           */ 
        }

        private void  UpdateValidationResult() {

            /*m_ValidationResult = true;  
            foreach (DataGridViewRow row in dgwImageResults.Rows)
            {
                bool actual = false;    
                bool expected = (bool)row.Cells["ExpectedResult"].Value;
                if (row.Cells["ActualResult"].Value.ToString() == "Pass") actual = true;else actual = false;    
                if (expected != actual) m_ValidationResult = false;
            }

            /*lblValidationResult.Invoke((Action)delegate { 

            if (m_ValidationResult)
            {
                lblValidationResult.Text = "Pass";
                lblValidationResult.ForeColor = Color.Green;
            }
            else {
                lblValidationResult.Text = "Fail";
                lblValidationResult.ForeColor = Color.Red;

            }

            });
            */
        }
        private void dgwImageResults_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {/*
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure valid cell
            {
                //  DataGridViewRow row = dgwImageResults.Rows[e.RowIndex];
                ImageEntry entry = m_imageEntries[e.RowIndex];

                // Update ImageEntry object based on DataGridView change
                switch (e.ColumnIndex)
                {
                    case 0: // Path column (assuming index 0)
                        entry.Path = Convert.ToString(row.Cells[e.ColumnIndex].Value);
                        break;
                    case 1: // Filename column (assuming index 1)
                        entry.Filename = Convert.ToString(row.Cells[e.ColumnIndex].Value);
                        break;
                    case 2: // ExpectedResult column (assuming index 2)
                        entry.ExpectedResult = Convert.ToBoolean(row.Cells[e.ColumnIndex].Value);
                        break;
                    case 3: // ActualResult column (assuming index 3)
                        entry.ActualResult = Convert.ToBoolean(row.Cells[e.ColumnIndex].Value);
                        break;
                    default:
                        break;
                }

                // Update the list if necessary
                m_imageEntries[e.RowIndex] = entry;
            }
        */}

        private void dgwImageResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
          /*  if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Check if the double-clicked cell is in the thumbnail column
                if (dgwImageResults.Columns[e.ColumnIndex].Name == "ImagePreview")
                {
                    // Retrieve the filename or other identifier from the DataGridView cell
                    DataGridViewRow row = dgwImageResults.Rows[e.RowIndex];
                    string filename = m_imageEntries[e.RowIndex].Path; 
                    m_currentIndex = e.RowIndex; 
                    // Call LoadImage async method
                    LoadImage(filename);
                    
                }
            }

        */}


        /// <summary>
        /// Unsubscribe any events before shutting down.
        /// </summary>
        private void UnsubscribeEvents()
        {
            _inSight.PreviewMessage -= _inSight_PreviewMessage;
            _inSight.ResultsChanged -= _inSight_ResultsChanged;
            _inSight.ConnectedChanged -= _inSight_ConnectedChanged;
            _inSight.StateChanged -= _inSight_StateChanged;
            _inSight.LiveModeChanged -= _inSight_LiveModeChanged;
            _inSight.JobInfoChanged -= _inSight_JobInfoChanged;
            _inSight.JobLoadingChanged -= _inSight_JobLoadingChanged;
            _inSight.EditorAttachedChanged -= _inSight_EditorAttachedChanged;
        }

        private void _inSight_JobInfoChanged(object sender, EventArgs e)
        {
            InitForNewJob(); // Handle sheet re-format
            _inSight_ResultsChanged(sender, e); // Be sure we re-process the result after job load
            UpdateState();
            
        }

        private void _inSight_JobLoadingChanged(object sender, EventArgs e)
        {
            InitForNewJob();
        }

        private async void _inSight_EditorAttachedChanged(object sender, EventArgs e)
        {
            InitForNewJob();
            UpdateState();
            //  await cvsDisplay.UpdateResults();
            //cvsFilmstrip.UpdateResults();
        }

        /// <summary>
        /// Optionally displays the messages that are sent and received on the CogSocket.
        /// </summary>
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
                Debug.WriteLine($"[{Name}] [Len:{len}] {msg}");
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

        /// <summary>
        /// Handles the ResultsChanged event by updating the displayed image and results.
        /// </summary>
        private async void _inSight_ResultsChanged(object sender, EventArgs e)
        {
            JToken results = _inSight.Results;
            m_results = results;
            
            //If Camera is connected and Images Loaded into GridView retrieve Job Result 

            if (_inSight.Connected && m_ImagesLoaded && m_currentIndex < m_imageEntries.Count && m_Ignore == false)
            {
               // MessageBox.Show(m_currentIndex.ToString());
                if (results["jobStatus"].Value<int>() != 1) {
                    m_imageEntries[m_currentIndex].ActualResult = false;
                }
                else
                {
                    m_imageEntries[m_currentIndex].ActualResult = true;
                }
            

            }



            //cvsSpreadsheet.UpdateResults(results);
            //cvsCustomView.UpdateResults(results);
            UpdateDataGridView();   
            UpdateMessages();
            if (_inSight.Connected) UpdateValidationResult();
            //await cvsDisplay.UpdateResults();

            //cvsFilmstrip.UpdateResults();
            if (m_Secuence && m_currentIndex < m_imageEntries.Count)
            {
                m_currentIndex++;
                m_imageProcessedSignal.TrySetResult(true);
            }
        }

        /// <summary>
        /// Handles the ConnectedChanged event by updating the controls that use the state.
        /// </summary>
        private void _inSight_ConnectedChanged(object sender, EventArgs e)
        {
            InitForNewJob(); // Re-format the sheet
            UpdateState();
        }

        /// <summary>
        /// Handles the ConnectingChanged event by updating the controls that use the state.
        /// </summary>
        private void _inSight_ConnectingChanged(object sender, EventArgs e)
        {
            UpdateState();
        }

        /// <summary>
        /// Handles the StateChanged event by updating the controls that use the state.
        /// </summary>
        private void _inSight_StateChanged(object sender, EventArgs e)
        {
            UpdateState();
        }

        /// <summary>
        /// Handles the LiveModeChanged event by updating the controls that use the state.
        /// </summary>
        private void _inSight_LiveModeChanged(object sender, EventArgs e)
        {
            UpdateState();
        }


        private void InitForNewJob()
        {/*
            cvsSpreadsheet.Invoke((Action)delegate
            {
                cvsSpreadsheet.InitSpreadsheet(); // Clear the spreadsheet
                cvsCustomView.InitSpreadsheet(); // Clear the custom View
                cvsDisplay.InitDisplay(); // Clear the graphics

            });
            */
        }

        /// <summary>
        /// Updates the controls that use the state (i.e.  not connected/connected, offline/online, live mode)
        /// </summary>
        private void UpdateState()
        {/*
            try
            {
                lblState.Invoke((Action)delegate
                {
                    btnConnectDisconnect.Enabled = !_inSight.Connecting;
                    btnConnectDisconnect.Text = _inSight.Connected ? "Disconnect" : "Connect";
                    

                    if (_inSight.Connected)
                    {
                        string stateText = _inSight.Online ? "Online" : "Offline";
                        if (_inSight.EditorAttached)
                            stateText = "Editor Attached, " + stateText;

                        if(_inSight.Online) lblState.ForeColor = Color.Green;else lblState.ForeColor = Color.Yellow;
                        lblState.Font = new Font("Times New Roman", 16.0f, FontStyle.Bold);
                        lblState.Text = stateText;
                        onlineMenuItem.Text = _inSight.Online ? "Go Offline" : "Go Online";
                        liveModeMenuItem.Checked = _inSight.LiveMode;
                        lblJobInfo.Text = "Current Job: " +_inSight.JobInfo["name"].Value<String>();
                         

                    }
                    else
                    {
                        lblState.Text = _inSight.Connecting ? "Connecting..." : "Not Connected";
                        lblState.Font = new Font("Times New Roman", 16.0f, FontStyle.Bold);
                        if(_inSight.Connecting) lblState.ForeColor = Color.Blue; else lblState.ForeColor = Color.Red;
                        onlineMenuItem.Text = "Go Online";
                        liveModeMenuItem.Checked = false;
                        //dgwImageResults.Rows.Clear();
                        m_imageEntries.Clear();
                        m_ImagesLoaded =false;
                    }

                    aboutMenuItem.Enabled = _inSight.Connected;

                    bool connectedButNotBusy = _inSight.Connected && !_inSight.EditorAttached && !_inSight.JobLoading;
                    bool isOffline = connectedButNotBusy && !_inSight.Online;
                    triggerMenuItem.Enabled = connectedButNotBusy;
                    onlineMenuItem.Enabled = connectedButNotBusy;
                    liveModeMenuItem.Enabled = isOffline;
                    //loadImageMenuItem.Enabled = isOffline;
                    loadImageMenuItem.Enabled = true;
                    loadHmiCellsMenuItem.Enabled = isOffline;
                    saveImageMenuItem.Enabled = connectedButNotBusy;
                    loadJobMenuItem.Enabled = isOffline;
                    hmiCustomViewMenuItem.Enabled = isOffline;
                    hmiSettingsMenuItem.Enabled = isOffline;
                    openHMIMenuItem.Enabled = connectedButNotBusy;

                    //Update Results on Mainform

                   // if(m_results != null ) MessageBox.Show(m_results.ToString());

                    //cvsFilmstrip.Enabled = _inSight.Connected && !_inSight.JobLoading;
                    saveQueuedImagesToolStripMenuItem.Enabled = _inSight.Connected;

                    // this.splitContainer1.Panel2Collapsed = !showSpreadsheetToolStripMenuItem.Checked;

                    /*      cvsCustomView.Visible = _inSight.Connected && !_inSight.JobLoading && (_inSight.CustomViewSettings.Length > 0) && (_inSight.CustomViewSettings?[0] != null) && showCustomViewToolStripMenuItem.Checked;
                    if (cvsCustomView.Visible)
                    {
                        CenterCustomView();
                        cvsCustomView.setCustomViewName(_inSight);
                    }


                });
            }
            catch (Exception)
            {
                // Ignore
            }
        */}

        private void CenterCustomView()
        {
            if ((_inSight != null) && (_inSight.CustomViewSettings != null))
            {
                HmiCustomViewSettings cvSettings = _inSight.CustomViewSettings?[0];
                if (cvSettings != null)
                {
                    // Always display it centered for now,
                    //cvsCustomView.SetBounds((cvsDisplay.Width - cvSettings.Width) / 2, (cvsDisplay.Height - cvSettings.Height) / 2, cvSettings.Width, cvSettings.Height);
                }
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {/*
            if (cvsCustomView.Visible)
            {
                CenterCustomView();
            }
            base.OnSizeChanged(e);
        */}

        protected override void OnClientSizeChanged(EventArgs e)
        {
            /*if (cvsCustomView.Visible)
            {
                CenterCustomView();
            }
            base.OnClientSizeChanged(e);
        */}


        #region Formatting/Output

        // Holds the content for the tbMessages when it will be updated.
        private string _loggedMessages = "";

        /// <summary>
        /// Add a message for the tbMessages.
        /// </summary>
        /// <param name="msg">The message to log</param>
        private void LogMessage(string msg)
        {
            _loggedMessages = msg;
        }

        /// <summary>
        /// Invokes to update the display messages.
        /// </summary>
        private void UpdateMessages()
        {
            tbMessages.Invoke((Action)delegate
            {
                tbMessages.Text = _loggedMessages;
            });
        }

        /// <summary>
        /// Formats the JSON so that it is readable.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        private static string JsonPrettify(string json)
        {
            using (var stringReader = new StringReader(json))
            using (var stringWriter = new StringWriter())
            {
                var jsonReader = new JsonTextReader(stringReader);
                var jsonWriter = new JsonTextWriter(stringWriter) { Formatting = Formatting.Indented };
                jsonWriter.WriteToken(jsonReader);
                return stringWriter.ToString();
            }
        }

        #endregion Formatting/Output

        /// <summary>
        /// Cleans up before the form is closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            try
            {
                UnsubscribeEvents();
                await _inSight.Disconnect();
            }
            catch (Exception)
            {
                MessageBox.Show("Error on disconnect");
            }
        }

        /// <summary>
        /// Handles loading images in sequence 
        /// </summary>
        private async void LoadImagestoInSight()
        {
            if (_inSight.Connected && m_ImagesLoaded)
            {

                m_Ignore = true;  
                await SetCameraStatus(false);

                m_currentIndex = 0; //Start from begining 
                m_Secuence = true;

                foreach (var entry in m_imageEntries)
                {
                    try
                    {
                        m_Ignore = false;
                        await SendImageAndWait(entry.Path);
                         
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show($"LoadImage Exception: {e.Message}");

                    }
                }
                
                await SetCameraStatus(true);
                m_Secuence = false; 
            }
        }
        /// <summary>
        /// Handles loading setting camera status 
        /// </summary>
        private async Task SetCameraStatus(bool state)
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

        /// <summary>
        /// Handles loading an image 
        /// </summary>
        /// 

        private async void LoadImage(string imgpath) {

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

        /// <summary>
        /// Handles loading an image and wait for it to be processed 
        /// </summary>
        ///
        private async Task SendImageAndWait(string imgpath) {

            m_imageProcessedSignal = new TaskCompletionSource<bool>();

            try
            {
                await _inSight.LoadImage(imgpath);
                await m_imageProcessedSignal.Task;  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"LoadImage Exception: {ex.Message}");
                m_imageProcessedSignal.TrySetResult(true); 
            }
        
        
        } 


        /// <summary>
        /// Loads Validation Json Configuration File  
        /// </summary>
        private async void loadValidationConfig(object sender)
        {
             
            InsightValidationControl selectedControl = sender as InsightValidationControl;
            //Set Camera connection Parameters
            string ipwithport = String.Empty;
            JToken cameraConnection = selectedControl.InSight.Configuration["CameraConnection"].Value<JToken>();
            JToken ImageEntryData = selectedControl.InSight.Configuration["Images"].Value<JToken>();
            selectedControl.tbIpAddressWithPort.Text = cameraConnection["IPAddressPort"].Value<String>();
            selectedControl.tbUsername.Text = cameraConnection["User"].Value<String>();
            selectedControl.tbPassword.Text = cameraConnection["Password"].Value<String>();

            //Connect if specified
            if (cameraConnection["AutoConnect"].Value<Boolean>() || selectedControl.chkAutoConnect.Checked)
            {
                selectedControl.chkAutoConnect.CheckState = CheckState.Checked;
                if(!selectedControl.InSight._inSight.Connected) await selectedControl.InSight.Connect();
            }
            string configurationJob = selectedControl.InSight.Configuration["JobFile"].Value<String>();
            
            if (selectedControl.InSight._inSight.Connected)
            {
                string cameraJob = selectedControl.InSight._inSight.JobInfo["name"].Value<String>();
                cameraJob = cameraJob.Replace("/", "").Replace("\\", "");

                //LoadJobFile If neccesary
                if (configurationJob != cameraJob)
                {
                    await selectedControl.InSight.LoadJob(selectedControl.InSight.Configuration["JobFile"].Value<String>());

                }

            }

            //Set Image Folder Parameters and load images
            selectedControl.InSight._imageEntries.Clear();
            selectedControl.InSight._imageLoaded= false;

            selectedControl.InSight._imageEntries = JsonConvert.DeserializeObject<List<InSightDevice.ImageEntry>> (ImageEntryData.ToString());
            
            selectedControl.UpdateDataGridView();
            selectedControl.UpdateState();   
        }

        private async Task Connect()
        {
            try
            {
                if (_inSight.Connected)
                {
                    await _inSight.Disconnect();
                    _loggedMessages = "";
                    UpdateMessages();//GUI
                }
                else
                {
                    // To limit the cell results that are returned, use the following...
                    HmiSessionInfo sessionInfo = new HmiSessionInfo();
                    sessionInfo.SheetName = "Inspection";
                    sessionInfo.CellNames = new string[1] { "A0:Z599" }; // Designating a cell range requires 6.3 or newer firmware
                    sessionInfo.EnableQueuedResults = true; // When the queue is frozen, then show the queued results
                    sessionInfo.IncludeCustomView = true;
                    ////await _inSight.Connect(tbIpAddressWithPort.Text, tbUsername.Text, tbPassword.Text, sessionInfo);

                    //await cvsDisplay.OnConnected();//GUI
                    //cvsFilmstrip.OnConnected();
                }

                UpdateState();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Connect error: " + ex.Message);
                MessageBox.Show("Unable to connect: " + ex.Message);
            }

        }
        /// <summary>
        /// Handles loading a job saved in camera memory
        /// </summary>
        private async Task LoadJob(string fileName) {
            try
            {
                if (_inSight.Connected)
                {
                    await _inSight.LoadJob(fileName).ConfigureAwait(false); 
                
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"LoadJob Exception: {ex.Message}");
            }
        }


     
      
        /// <summary>
        /// Handles the click event to connect and disconnect from a camera.
        /// </summary>
        private async void btnConnectDisconnect_Click(object sender, EventArgs e)
        {
            await Connect();
        }

        /// <summary>
        /// Makes sure that the controls are in the correct state when the application begins.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            AdjustWindowSizeToFitScreen();  
            InitForNewJob(); // Initialize the sheet
            UpdateState();

           LoadCameraLayout();
        }

        private void AdjustWindowSizeToFitScreen()
        {
            // Get the working area of the primary screen (this excludes the taskbar)
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            // Set the window size to the working area's size
            this.Size = new Size(workingArea.Width, workingArea.Height);

            // Optionally, set the window's position to the top-left corner
            this.Location = new Point(workingArea.Left, workingArea.Top);
        }

        /// <summary>
        /// Handles the click event to display information about the camera.
        /// </summary>
        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            InsightValidationControl selectedControl = tabCtrlContent.SelectedTab.Controls.OfType<InsightValidationControl>().FirstOrDefault();
            CvsCameraInfo info = selectedControl.InSight._inSight.CameraInfo;
           
            if (info != null)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Name: " + info.HostName);
                sb.AppendLine("IP Address: " + info.IPAddress);
                sb.AppendLine("Model: " + info.ModelNumber);
                sb.AppendLine("MAC: " + info.MacAddress);
                sb.AppendLine("Serial: " + info.SerialNumber);
                sb.AppendLine("Firmware: " + info.FirmwareVersion);
                sb.AppendLine("HMI API: " + info.ApiVersion);
                MessageBox.Show(sb.ToString(), "Camera Info");
            }
        }

        private async void hmiSettingsMenuItem_Click(object sender, EventArgs e)
        {
            InsightValidationControl selectedControl = tabCtrlContent.SelectedTab.Controls.OfType<InsightValidationControl>().FirstOrDefault();
            try
            {
                if (selectedControl.InSight._inSight.Connected)
                {
                    JToken hmiSettingsToken = selectedControl.InSight._inSight.Settings.SelectToken("hmi");
                    string hmiSettingsAsString = hmiSettingsToken.ToString();
                    hmiSettingsAsString = Prompt.ShowDialog("Enter HMI Settings:", hmiSettingsAsString, "HMI Settings");

                    if (hmiSettingsAsString.Length > 0)
                    {
                        HmiSettings hmiSettings = CvsInSight.JsonSerializer.DeserializeObject(hmiSettingsAsString) as HmiSettings;

                        await selectedControl.InSight._inSight.SetHmiSettingsAsync(hmiSettings);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"HmiSettings Exception: {ex.Message}");
            }
        }

        /// <summary>
        /// Handles the click event to go online/offline.
        /// </summary>
        private  void onlineMenuItem_Click(object sender, EventArgs e)
        {
            InsightValidationControl selectedControl = tabCtrlContent.SelectedTab.Controls.OfType<InsightValidationControl>().FirstOrDefault();

            if (selectedControl != null) { 
            
                selectedControl.OnlineOffline();    
            }
            else
            {
                MessageBox.Show("No control found in the selected tab.");
            }   

        }

        private async void liveModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsightValidationControl selectedControl = tabCtrlContent.SelectedTab.Controls.OfType<InsightValidationControl>().FirstOrDefault();
            if (selectedControl.InSight._inSight.Connected)
            {
                try
                {
                    bool nextLiveMode = !selectedControl.InSight._inSight.LiveMode;
                    await selectedControl.InSight._inSight.SetLiveModeAsync(nextLiveMode);
                    this.showSpreadsheetToolStripMenuItem.Checked = !nextLiveMode;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error setting live mode. Verify that ISE is not connected.");
                }
            }
        }

        private void openHMIMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_inSight.Connected)
                {
                    System.Diagnostics.Process.Start(_inSight.RemoteIPAddressUrl);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"OpenHmi Exception: {ex.Message}");
            }
        }

        private async void hmiCustomViewMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_inSight.Connected)
                {
                    HmiCustomViewSettings[] settings = _inSight.CustomViewSettings;
                    if (settings == null || settings.Length == 0)
                    {
                        settings = new HmiCustomViewSettings[] { new HmiCustomViewSettings() };
                    }
                    CvsCustomViewSettingsDialog dlg = new CvsCustomViewSettingsDialog(settings);
                    DialogResult res = dlg.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        await _inSight.SetCustomViewSettingsAsync(dlg.Settings);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"CustomViewSettings Exception: {ex.Message}");
            }
        }

        /// <summary>
        /// Handles the click event to perform a manual acquisition.
        /// </summary>
        private async void triggerMenuItem_Click(object sender, EventArgs e)
        {
            InsightValidationControl selectedControl = tabCtrlContent.SelectedTab.Controls.OfType<InsightValidationControl>().FirstOrDefault();
            if (selectedControl.InSight._inSight.Connected)
            {
                try
                {
                    Debug.WriteLine("Manual Acquire Ticks: " + (Environment.TickCount - _startTicks).ToString());
                    await selectedControl.InSight._inSight.ManualAcquire();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error sending manual trigger");
                }
            }
        }

        private async void loadJobMenuItem_Click(object sender, EventArgs e)
        {
            InsightValidationControl selectedControl = tabCtrlContent.SelectedTab.Controls.OfType<InsightValidationControl>().FirstOrDefault();

            if (selectedControl.InSight._inSight.Connected)
            {
                var filePath = string.Empty;

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "Job files (*.jobx, *.job)|*.jobx;*.job";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        try
                        {
                                
                            await _inSight.LoadJobData(filePath).ConfigureAwait(false);
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"LoadJob Exception: {ex.Message}");
                        }
                    }
                }
            }
        }

        private async void loadImageMenuItem_Click(object sender, EventArgs e)
        {
            InsightValidationControl selectedControl = tabCtrlContent.SelectedTab.Controls.OfType<InsightValidationControl>().FirstOrDefault();
            //ChangeStatetoOffline
            if (selectedControl.InSight._inSight.Connected)
            {
                try
                {
                    await selectedControl.InSight.SetCameraStatus(false);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error setting soft online. Verify that ISE is not connected.");
                }
            }

            if (selectedControl.InSight._inSight.Connected)
            //if(true)
            {
                var filePath = string.Empty;

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "BMP files (*.bmp)|*.bmp";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        try
                        {
                            await selectedControl.InSight.LoadImage(filePath);    
                            //await _inSight.LoadImage(filePath);
                            selectedControl.InSight._imageLoaded = true;    
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"LoadImage Exception: {ex.Message}");
                        }
                    }
                }
            }

            //Change State to online and then send async event to send resuls to PLC

        }

        private void saveImageMenuItem_Click(object sender, EventArgs e)
        {
            InsightValidationControl selectedControl = tabCtrlContent.SelectedTab.Controls.OfType<InsightValidationControl>().FirstOrDefault();
            if (selectedControl.InSight._inSight.Connected)
            //if(true)
            {
                string imageUrl = selectedControl.InSight._inSight.GetMainImageUrl();
                if (imageUrl.Length > 0)
                {
                    var filePath = string.Empty;

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.InitialDirectory = "c:\\";
                        saveFileDialog.Filter = "BMP files (*.bmp)|*.bmp";
                        saveFileDialog.FilterIndex = 1;
                        saveFileDialog.RestoreDirectory = true;

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Get the path of specified file
                            filePath = saveFileDialog.FileName;

                            try
                            {
                                using (WebClient webClient = new WebClient())
                                {
                                    byte[] data = webClient.DownloadData(imageUrl);

                                    using (MemoryStream mem = new MemoryStream(data))
                                    {
                                        using (var myImage = System.Drawing.Image.FromStream(mem))
                                        {
                                            myImage.Save(filePath, ImageFormat.Bmp);
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine($"LoadImage Exception: {ex.Message}");
                            }
                        }
                    }
                }
            }
        }

        private void showCustomViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void loadHmiCellsMenuItem_Click(object sender, EventArgs e)
        {
            InsightValidationControl selectedControl = tabCtrlContent.SelectedTab.Controls.OfType<InsightValidationControl>().FirstOrDefault();

            if (selectedControl.InSight._inSight.Connected)
            {
                var filePath = string.Empty;

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = ".";
                    openFileDialog.Filter = "JSON files (*.json)|*.json";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Get the path of specified file
                        filePath = openFileDialog.FileName;

                        try
                        {
                            string strHmiCells = File.ReadAllText(filePath);
                            HmiSpreadsheetCells hmiCells = CvsInSight.JsonSerializer.DeserializeObject(strHmiCells) as HmiSpreadsheetCells;
                            if (hmiCells != null)
                            {
                                hmiCells.FilePath = filePath;
                            }
                            //cvsCustomView.SetHmiSpreadsheetCells(hmiCells);
                            //cvsSpreadsheet.SetHmiSpreadsheetCells(hmiCells);
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"LoadImage Exception: {ex.Message}");
                        }
                    }
                }
            }
        }

        private void showSpreadsheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsightValidationControl selectedControl = tabCtrlContent.SelectedTab.Controls.OfType<InsightValidationControl>().FirstOrDefault();

            if (selectedControl.InSight._inSight.Connected)
            {
                selectedControl.cvsSpreadsheet1.Visible = showSpreadsheetToolStripMenuItem.Checked;
                selectedControl.dgwImageResults.Visible = !showSpreadsheetToolStripMenuItem.Checked;
                // cvsSpreadsheet.Visible = showSpreadsheetToolStripMenuItem.Checked;
                //dgwImageResults.Visible = !showSpreadsheetToolStripMenuItem.Checked;
                selectedControl.UpdateState();  
                //UpdateState();
            }
        }

        private async void getQueuedImageURLsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_inSight.Connected)
            {
                JToken results = _inSight.Results;
                if (results != null)
                {
                    try
                    {
                        var timer = new Stopwatch();
                        timer.Start();
                        await _inSight.FreezeQueue(true);
                        timer.Stop();
                        Console.WriteLine($"{timer.ElapsedMilliseconds} ms");

                        JToken token = results.SelectToken("rq.slots");
                        if (token == null)
                            return;

                        StringBuilder sb = new StringBuilder();

                        int numSlots = (int)token.ToObject(typeof(int));
                        if (numSlots > 0)
                        {
                            for (int n = 0; n < numSlots; n++)
                            {
                                string url = await _inSight.RequestQueuedImageUrl(n);
                                url = _inSight.RemoteIPAddressUrl + url; // Complete the URL
                                sb.AppendLine(url);
                            }

                            MessageBox.Show(sb.ToString(), "Result Queue URLs");
                        }
                        else
                        {
                            MessageBox.Show("None", "Result Queue URLs");
                        }
                    }
                    finally
                    {
                        await _inSight.SendReady(); // Be sure that the next result will be accepted into the session
                        await _inSight.FreezeQueue(false);
                    }
                }

            }
        }

        private void shwMenuBar_CheckedChanged(object sender, EventArgs e)
        {
            //  this.menuStrip.Visible = shwMenuBar.Checked;
        }

        private void imgsFolderbtn_Click(object sender, EventArgs e)
        {
            if (_inSight.Connected)
            {


                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = ".";
                    openFileDialog.Filter = "BMP files (*.bmp)|*.bmp";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;
                    openFileDialog.Multiselect = true;


                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Get the path of specified file

                        imgspath = openFileDialog.FileNames.ToList<String>();
                        //lblimgsload.Text = imgspath.Count.ToString() + "/tImages Loaded";
                        PopulateGridView();
                    }
                }
            }
        }

        private void btnRunValidation_Click(object sender, EventArgs e)
        {
            if (_inSight.Connected)
            {
                // this.btnRunValidation.Enabled = false;   
                LoadImagestoInSight();
                //  this.btnRunValidation.Enabled = true;

            }
        }

        private void loadValidationFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GrabCurrent Tab control
            InsightValidationControl selectedControl = tabCtrlContent.SelectedTab.Controls.OfType<InsightValidationControl>().FirstOrDefault();
            
            //Make Sure Recipes Folder Exists
            CheckCreateForRecipeFolder();

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),"ValidationRecipes"); 
                    openFileDialog.Filter = "JSON files (*.json)|*.json";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;
                    openFileDialog.Multiselect = false;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {


                        using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                        {
                            string jsonfile = sr.ReadToEnd();
                            selectedControl.InSight.Configuration = JToken.Parse(jsonfile);
                            
                            //m_configuration = JToken.Parse(jsonfile);
                            loadValidationConfig(selectedControl);
                        }

                    }

                }

            
        }
        /// <summary>
        /// Handles modifying current configuration to save latest values
        /// </summary>
        private void setupSaveConfiguration() { 
            JObject CameraConnection = new JObject();
            JObject ImageResultData = new JObject();
            JObject config = new JObject();

            InsightValidationControl selectedControl = tabCtrlContent.SelectedTab.Controls.OfType<InsightValidationControl>().FirstOrDefault();


            //Clear Current Configuration
             selectedControl.InSight.Configuration = null;
              
            //Save Camera connection Parameters
            CameraConnection.Add("IPAddressPort", selectedControl.tbIpAddressWithPort.Text);
            CameraConnection.Add("User",selectedControl.tbUsername.Text);
            CameraConnection.Add("Password",selectedControl.tbPassword.Text);
            CameraConnection.Add("AutoConnect", selectedControl.chkAutoConnect.Checked);


            //Save Job FileName
           // JobFileName.Add("JobFile",selectedControl.lblJobInfo.Text);


            string jobFile = selectedControl.InSight._inSight.JobInfo["name"].Value<String>();
            jobFile = jobFile.Replace("/", "").Replace("\\", "");
            config.Add("CameraConnection", CameraConnection);
            config.Add("JobFile", jobFile);
            config.Add("Images", ConvertToJson(selectedControl.InSight._imageEntries));

            selectedControl.InSight.Configuration = config;


        }

        /// <summary>
        /// Handles the click event to perform validation file saving to Json
        /// </summary>
        private void saveValidationFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsightValidationControl selectedControl = tabCtrlContent.SelectedTab.Controls.OfType<InsightValidationControl>().FirstOrDefault();

            CheckCreateForRecipeFolder();
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {

                saveFileDialog.InitialDirectory = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),"ValidationRecipes"); 
                saveFileDialog.Filter = "JSON files (*.json)|*.json";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.Title = "Save Validation File...";
                saveFileDialog.FileName = Path.GetFileNameWithoutExtension( selectedControl.InSight._inSight.JobInfo["name"].Value<String>());


                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    string filePath = saveFileDialog.FileName;
                    setupSaveConfiguration();
                    string json = JsonConvert.SerializeObject(selectedControl.InSight.Configuration,Formatting.Indented);
                    System.IO.File.WriteAllText(filePath, json);
                }
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;    
        }

        private void btnRestoreMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;

            tbllyMainWindow.Width = ClientSize.Width;
            tbllyMainWindow.Height = ClientSize.Height; 

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tabCtrlContent.Dispose();
            menuStrip.Dispose();
            System.Windows.Forms.Application.Exit(); 
        }

        private void pnlTopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            m_mouseDown = true;
            m_lastLocation = e.Location;
        }

        private void pnlTopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - m_lastLocation.X) + e.X, (this.Location.Y - m_lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void pnlTopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            m_mouseDown = false;
        }

        private void insightValidationControl1_Load(object sender, EventArgs e)
        {

        }



        private void InSightControlUpdate(object sender, EventArgs e) {

            UpdateWindowState();
        }

        private void InSightControlJobLoad(object sender, EventArgs e) {
            CheckRecipe(sender);
        }

        private void InSightControlConnected(object sender, EventArgs e) {
            CheckRecipe(sender);

        }

        private void InSightControlDisconnected(object sender, EventArgs e) { 
        
        }

        private void CheckRecipe(object sender) {
            CheckCreateForRecipeFolder();
            LoadConfigurationFromFolder(sender);
            UpdateWindowState();

        }

        private void InSightControlValidationStart(object sender, String status) {
            //Modify Tab Behaviour
            if (sender is InsightValidationControl InSightValidationControl)
            {

                TabPage tabPage = InSightValidationControl.Parent as TabPage;

                if (tabPage != null)
                {
                    int tabIndex = tabCtrlContent.TabPages.IndexOf(tabPage);
                    CustomTabSelector tabSelector = (CustomTabSelector) flwlyTabControlButtons.Controls[tabIndex];
                    tabSelector.UpdateSelectorColor("neutral");    
                    // tabResults.Insert(tabIndex, status);
                   // if(tabCtrlContent != null)tabCtrlContent.Invalidate();
                }

            }
        }

        private void InSightControlValidationCompleted(Object sender, String status) {
            if (sender is InsightValidationControl InSightValidationControl)
            {

                TabPage tabPage = InSightValidationControl.Parent as TabPage;

                if (tabPage != null)
                {
                    int tabIndex = tabCtrlContent.TabPages.IndexOf(tabPage);
                    CustomTabSelector tabSelector = (CustomTabSelector)flwlyTabControlButtons.Controls[tabIndex];
                    tabSelector.UpdateSelectorColor(status);
                }

            }


        }

        private void UpdateTabResult(object sender, string status) {
            //Modify Tab Behaviour
            if (sender is InsightValidationControl InSightValidationControl)
            {

                TabPage tabPage = InSightValidationControl.Parent as TabPage;

                if (tabPage != null)
                {
                    int tabIndex = tabCtrlContent.TabPages.IndexOf(tabPage);
                    tabResults[tabIndex] = status;
                   // if(tabCtrlContent != null)tabCtrlContent.Invalidate();
                }

            }

        }

        private void LoadConfigurationFromFolder(object sender  )
        {
            
           InsightValidationControl selectedControl = sender as InsightValidationControl;


                string jobFileName = selectedControl.InSight._inSight.JobInfo["name"].Value<String>();
                jobFileName = jobFileName.Replace("/", "").Replace("\\", "").Replace(".jobx", ".json");

                //Check if configuration File Already Exists for this JobFile
                 string validationPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "ValidationRecipes", jobFileName);
            

            if (!File.Exists(validationPath))
            {
                //If the Recipe doesn't Exists yet let user know
                MessageBox.Show("Validation Recipe for this JobFile/Camera not yet Created");
            }
            else {
                using (StreamReader sr = new StreamReader(validationPath))
                {
                    //Automatically load configuration if configuration exists
                    string jsonfile = sr.ReadToEnd();
                    selectedControl.InSight.Configuration = JToken.Parse(jsonfile);
                    loadValidationConfig(selectedControl);
                }

            }
        }
        private void CheckCreateForRecipeFolder() { 
            string folderPath =  Path.GetDirectoryName(Application.ExecutablePath);
            //If Recipe Folder doesn't exist create it 
            if (!Directory.Exists(Path.Combine(folderPath,"ValidationRecipes"))) { 
            
                Directory.CreateDirectory(Path.Combine(folderPath,"ValidationRecipes"));
            }
        }

        private void InitializeNewTab() { 
            //Create Tab Selector for this tab, just before the "+" button

            CustomTabSelector tabSelector = new CustomTabSelector();
            

            this.flwlyTabControlButtons.Controls.Remove(btnAddTab);
            this.flwlyTabControlButtons.Controls.Add(tabSelector);

            tabSelector.OnCloseTabClick += TabSelector_OnCloseTabClick;
            tabSelector.OnSelectTabClick += TabSelector_OnSelectTabClick;
            
            //Create new InSightValidation Control for this tab
            TabPage tabPage = new TabPage();
            tabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            tabPage.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tabPage.Location = new System.Drawing.Point(4, 26);
            tabPage.Margin = new System.Windows.Forms.Padding(0);
            tabPage.Padding = new System.Windows.Forms.Padding(3);
            tabPage.Size = new System.Drawing.Size(1906, 980);
            tabPage.TabIndex = 0;
            tabPage.Text = "DefaultConnection";

            InsightValidationControl insightValidationControl = new InsightValidationControl();
            insightValidationControl.Dock = System.Windows.Forms.DockStyle.Fill;
            insightValidationControl.Location = new System.Drawing.Point(3, 3);
            insightValidationControl.Name = "insightValidationControl1";
            insightValidationControl.Size = new System.Drawing.Size(1900, 974);
            insightValidationControl.TabIndex = 0;
            insightValidationControl.InSightValidationControl_OnUpdate += InSightControlUpdate;
            insightValidationControl.InSightValidationControl_OnJobLoad += InSightControlJobLoad;
            insightValidationControl.InSightValidationControl_OnConnected += InSightControlConnected;
            insightValidationControl.InSightValidationControl_OnValidationStart += InSightControlValidationStart;
            insightValidationControl.InSightValidationControl_OnValidationCompleted += InSightControlValidationCompleted;   
           
            
            this.flwlyTabControlButtons.Controls.Add(btnAddTab);
            tabPage.Controls.Add(insightValidationControl);
            tabCtrlContent.Controls.Add(tabPage);
            tabCtrlContent.SelectTab(tabPage);
            tabSelector.attachedTabIndex = tabCtrlContent.SelectedIndex;
            


         // tabCtrlContent.Controls.Add(tabPage2);
        }

        private void TabSelector_OnSelectTabClick(object sender, EventArgs e)
        {
            if (sender is CustomTabSelector CustomTabSelector) {
                tabCtrlContent.SelectTab(CustomTabSelector.attachedTabIndex);
                UpdateWindowState();    
            }
        }

  
            private void TabSelector_OnCloseTabClick(object sender, EventArgs e)
            {
                if (sender is CustomTabSelector customTabSelector)
                {
                  if (customTabSelector.attachedTabIndex >= 0 && customTabSelector.attachedTabIndex < tabCtrlContent.TabPages.Count)
                    {
                        
                        CleanUpTabPage(tabCtrlContent.TabPages[customTabSelector.attachedTabIndex]);
                    }

                    
                    customTabSelector.Dispose();

                    
                    UpdateCustomTabSelectorsIndex();

                  if (tabCtrlContent.TabCount > 0)
                    {
                        
                        tabCtrlContent.SelectTab(tabCtrlContent.TabCount - 1);
                    }
                }

               
                if (flwlyTabControlButtons.Controls.Count == 1 && tabCtrlContent.TabPages.Count > 0)
                {
                    CleanUpTabPage(tabCtrlContent.TabPages[0]);
                }
            }

        

        private void UpdateCustomTabSelectorsIndex() {
            int index = 0;
            foreach (CustomTabSelector customTabSelector in flwlyTabControlButtons.Controls.OfType<CustomTabSelector>())
            {
                customTabSelector.attachedTabIndex = index; 
            }   
        }

        private void UpdateWindowState() {
            tabCtrlContent.Invoke((Action)delegate
            {
                InsightValidationControl selectedControl = tabCtrlContent.SelectedTab.Controls.OfType<InsightValidationControl>().FirstOrDefault();

                if (selectedControl != null)
                {
                    try
                    {
                        selectedControl.lblState.Invoke((Action)delegate
                        {
                            if (selectedControl.InSight._inSight.Connected)
                            {
                                onlineMenuItem.Text = selectedControl.InSight._inSight.Online ? "Go Offline" : "Go Online";
                                liveModeMenuItem.Checked = selectedControl.InSight._inSight.LiveMode;
                                CvsCameraInfo info = selectedControl.InSight._inSight.CameraInfo;
                                // tabCtrlContent.SelectedTab.Text = info.HostName;
                                CustomTabSelector customTabSelector = (CustomTabSelector)flwlyTabControlButtons.Controls[tabCtrlContent.SelectedIndex];

                                customTabSelector.UpdateConnectionName(info.HostName);
                                customTabSelector.UpdateSelectorColor("neutral");


                                info = null;
                            }
                            else
                            {
                                onlineMenuItem.Text = "Go Online";
                                liveModeMenuItem.Checked = false;
                                tabCtrlContent.SelectedTab.Text = "Default Connection";
                            }
                            aboutMenuItem.Enabled = selectedControl.InSight._inSight.Connected;

                            bool connectedButNotBusy = selectedControl.InSight._inSight.Connected && !selectedControl.InSight._inSight.EditorAttached && !selectedControl.InSight._inSight.JobLoading;
                            bool isOffline = connectedButNotBusy && !selectedControl.InSight._inSight.Online;

                            triggerMenuItem.Enabled = connectedButNotBusy;
                            onlineMenuItem.Enabled = connectedButNotBusy;
                            liveModeMenuItem.Enabled = isOffline;
                            loadImageMenuItem.Enabled = isOffline;
                            loadImageMenuItem.Enabled = true;
                            loadHmiCellsMenuItem.Enabled = isOffline;
                            saveImageMenuItem.Enabled = connectedButNotBusy;
                            loadJobMenuItem.Enabled = isOffline;
                            hmiCustomViewMenuItem.Enabled = isOffline;
                            hmiSettingsMenuItem.Enabled = isOffline;
                            openHMIMenuItem.Enabled = connectedButNotBusy;
                            saveQueuedImagesToolStripMenuItem.Enabled = selectedControl.InSight._inSight.Connected;



                        });


                    }
                    catch (Exception)
                    {

                        //Ignore
                    }
                }
            });

        }



     
        private void DrawCloseButton(Graphics g, Rectangle tabRect)
        {
            int buttonSize = 15;
            Rectangle closeButtonRect = new Rectangle(tabRect.Right - buttonSize - 5, tabRect.Top + (tabRect.Height - buttonSize) / 2, buttonSize, buttonSize);

            // Create a circular path for the button
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(closeButtonRect);

                // Create a gradient brush for the 3D effect
                using (LinearGradientBrush brush = new LinearGradientBrush(closeButtonRect, Color.Black, Color.Black, LinearGradientMode.Vertical))
                {
                    g.FillPath(brush, path);
                }

                // Draw the border of the button
                using (Pen pen = new Pen(Color.Black, 1))
                {
                    g.DrawPath(pen, path);
                }

                // Draw the 'x' symbol
                using (Pen pen = new Pen(Color.White, 2))
                {
                    int padding = 3;
                    g.DrawLine(pen, closeButtonRect.Left + padding, closeButtonRect.Top + padding, closeButtonRect.Right - padding, closeButtonRect.Bottom - padding);
                    g.DrawLine(pen, closeButtonRect.Right - padding, closeButtonRect.Top + padding, closeButtonRect.Left + padding, closeButtonRect.Bottom - padding);
                }
            }
        }

        private void TabCtrl_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabCtrlContent.TabCount; i++)
            {
                Rectangle tabRect = tabCtrlContent.GetTabRect(i);
                Rectangle closeButtonRect = new Rectangle(tabRect.Right - 15, tabRect.Top + 5, 10, 10);
                if (closeButtonRect.Contains(e.Location))
                {

                    
                    CleanUpTabPage(tabCtrlContent.TabPages[i]);
                    tabCtrlContent.SelectTab(tabCtrlContent.TabCount-2);
                    break;
                }
            }
              
        }

        private void CleanUpTabPage(TabPage tabPage)
        {
            // Detach any event handlers associated with controls on the TabPage
            foreach (Control control in tabPage.Controls)
            {
                control.Dispose(); // Dispose of control resources
            }

            // Optionally, clear any remaining controls from the TabPage
            tabPage.Controls.Clear();

            // Remove the TabPage from the TabControl
            tabCtrlContent.TabPages.Remove(tabPage);

            // Dispose of the TabPage itself if necessary
            tabPage.Dispose();
        }


        private void btnAddTab_Click(object sender, EventArgs e)
        {
            InitializeNewTab();
           
        }

        private void saveCameraLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckCreateForRecipeFolder();
            JObject CameraTabs = new JObject();
            //Save Current Page Layout
            int index = 0;
            foreach (TabPage tabPage in tabCtrlContent.TabPages) {

                InsightValidationControl insightValidationControl = tabPage.Controls.OfType<InsightValidationControl>().FirstOrDefault();

                if (insightValidationControl != null)
                {
                    JObject CameraConnection = new JObject();
                    
                    CameraConnection.Add("IPAddressPort", insightValidationControl.tbIpAddressWithPort.Text);
                    CameraConnection.Add("User", insightValidationControl.tbUsername.Text);
                    CameraConnection.Add("Password", insightValidationControl.tbPassword.Text);
                    CameraConnection.Add("AutoConnect", insightValidationControl.chkAutoConnect.Checked);
                    CameraTabs.Add(String.Concat("Camera",index.ToString()), CameraConnection);
                    index++;    

                   
                }
            }

            string folderPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "ValidationRecipes");
            string fileName = "DefaultLayout.json";


            System.IO.File.WriteAllText(Path.Combine(folderPath, fileName), JsonConvert.SerializeObject(CameraTabs, Formatting.Indented));

            if (File.Exists(Path.Combine(folderPath, fileName))) MessageBox.Show("Layout File Saved to HDD");
            else MessageBox.Show("Error Saving Layout File");

        }

        private async void LoadCameraLayout() {

            //Make Sure Recipes Folder Exists
            CheckCreateForRecipeFolder();

            //Check if Validation Tool Layout file exists
            string folderPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "ValidationRecipes"); 
            string fileName = "DefaultLayout.json";

            if (File.Exists(Path.Combine(folderPath, fileName))) {

                using (StreamReader sr = new StreamReader(Path.Combine(folderPath, fileName)))
                {
                    string jsonfile = sr.ReadToEnd();
                    
                    JToken layoutConfig = JToken.Parse(jsonfile);

                    //m_configuration = JToken.Parse(jsonfile);
                    await loadLayoutConfig(layoutConfig);
                }

            }
            else MessageBox.Show("No Layout File Saved Yet");

        }

        private async Task loadLayoutConfig(JToken layoutConfig)
        {
            int index = 0;
            //If there's not enough tabs Create them 

            int currentTabs = flwlyTabControlButtons.Controls.Count - 1;
            int tabsToCreate = layoutConfig.Count <JToken>() - currentTabs;

            //Create the tabs

            for (int i = 0; i < tabsToCreate; i++) {
                InitializeNewTab();
            }


            foreach (TabPage tabPage in tabCtrlContent.TabPages)
            {
                InsightValidationControl insightValidationControl = tabPage.Controls.OfType<InsightValidationControl>().FirstOrDefault();
                if (insightValidationControl != null)
                {

                    JToken connectionSettings = layoutConfig.ElementAt(index);
                    connectionSettings = connectionSettings.ElementAt(0);

                    //Load information at index
                    //IPWithAddress
                    insightValidationControl.tbIpAddressWithPort.Text = connectionSettings["IPAddressPort"].Value<String>();
                    //UserName
                    insightValidationControl.tbUsername.Text = connectionSettings["User"].Value<String>();
                    //Password
                    insightValidationControl.tbPassword.Text = connectionSettings["Password"].Value<String>();
                    //AutoConnect
                    insightValidationControl.tbUsername.Text = connectionSettings["User"].Value<String>();

                    if (connectionSettings["AutoConnect"].Value<Boolean>()) {

                        insightValidationControl.chkAutoConnect.CheckState = CheckState.Checked;
                        if (!insightValidationControl.InSight._inSight.Connected) await insightValidationControl.InSight.Connect();
                       
                    }
                    
                    index++;
                }

            }
        }
    }
}
