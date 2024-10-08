﻿using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Web.Controls;
using InSightValidationTool;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebAPISampleApp
{
    public partial class InsightValidationControl : UserControl
    {
        private const int ThumbnailSize = 200; // Desired thumbnail size (width and height)
        private const int RowHeight = 100; // Desired row height
        public int currentIndex = 0;
        
        public List<String> imgspath = null;

        private bool previousState = false;
        private bool secuence = false;
        private string validationSecuenceSender = String.Empty;

        internal InSightDevice inSightSystem;

        private bool ignoreResult = false;


        public delegate void InSightValidationControlEventHandler(object sender, EventArgs e);
        public delegate void InSightValidationControlValidationEventHandler(object sender, String status);


        public event InSightValidationControlEventHandler InSightValidationControl_OnUpdate;

        public event InSightValidationControlEventHandler InSightValidationControl_OnJobLoad;

        public event InSightValidationControlEventHandler InSightValidationControl_OnConnected;

        public event InSightValidationControlEventHandler InSightValidationControl_OnDisconnected;

        public event InSightValidationControlValidationEventHandler InSightValidationControl_OnValidationStart;

        public event InSightValidationControlValidationEventHandler InSightValidationControl_OnValidationCompleted;

        protected virtual void onUpdateEvent(EventArgs e)
        {

           InSightValidationControl_OnUpdate(this, e); 
        }

        public virtual void onJobLoad(EventArgs e) {

            InSightValidationControl_OnJobLoad(this, e);
        }

        protected virtual void onConnected(EventArgs e)
        {

            InSightValidationControl_OnConnected(this, e);
        }

        public virtual void OnDisconnected(EventArgs e) { 
        
            InSightValidationControl_OnDisconnected(this, e);   
        }

        protected virtual void OnValidationStart(string result)
        {
            InSightValidationControl_OnValidationStart(this, result);

        }

        protected virtual void OnValidationCompleted(string result )
        {

            InSightValidationControl_OnValidationCompleted(this, result);
        }



        public InsightValidationControl()
        {
            //Create Default Connection
           
            InitializeComponent();
            
            //Make Sure important events are declared 
            this.tbIpAddressWithPort.TextChanged += TbIpAddressWithPort_TextChanged;
            this.tbUsername.TextChanged += TbUsername_TextChanged;
            this.tbPassword.TextChanged += TbPassword_TextChanged;


            inSightSystem = new InSightDevice(tbIpAddressWithPort.Text, tbUsername.Text, tbPassword.Text, false);
            inSightSystem.InSightDevice_NativeDataRecieved += InSightSystem_InSightDevice_NativeDataRecieved;

            InitializeDataGridView();

            cvsSpreadsheet1.SetInSight(inSightSystem._inSight);
            cvsDisplay1.SetInSight(inSightSystem._inSight);
           // cvsCustomView1.SetInSight(inSightSystem._inSight);

            //Suscribe to InSight Events
            inSightSystem._inSight.ResultsChanged += OnResultsChanged;
            inSightSystem._inSight.PreviewMessage += OnPreviewMessage;
            inSightSystem._inSight.ConnectedChanged += OnConnectedChanged;
            inSightSystem._inSight.ConnectingChanged += OnConnectingChanged;
            inSightSystem._inSight.StateChanged += OnStateChanged;
            inSightSystem._inSight.LiveModeChanged += OnLiveModeChanged;
            inSightSystem._inSight.JobInfoChanged += OnJobInfoChanged;
            inSightSystem._inSight.JobLoadingChanged += OnJobLoadingChanged;
            inSightSystem._inSight.EditorAttachedChanged += OnEditorAttachedChanged;

           
        }

        private void InSightSystem_InSightDevice_NativeDataRecieved(object sender, InSightDevice.NativeResponse e)
       {
            if (lblNativeStatus != null)
            {

                if (e.Result == "1.000" && !previousState)
                {
                    this.validationSecuenceSender = "PLC";

                    LoadImagestoInSight();
                }
                else if (e.Result == "0.000") { 
                
                    previousState = false;  
                }
                try
                {
                    if (lblNativeStatus.IsHandleCreated)
                    {
                        lblNativeStatus.BeginInvoke((Action)delegate
                        {
                            if (lblNativeStatus != null)
                            {
                                if (e.Status == InSightDevice.NativeResponse.StatusCode.CommandExecutedSuccessfully)
                                {
                                    lblNativeStatus.Text = "Native Online";
                                    lblNativeStatus.ForeColor = Color.Green;
                                }
                                else
                                {
                                    lblNativeStatus.Text = e.Status.ToString();
                                    lblNativeStatus.ForeColor = Color.Red;
                                }
                            }
                        });
                    }
                }
                catch (InvalidOperationException ex)
                {
                    // Handle exception (log it, display a message, etc.)
                }
            }

                        
        }

        ~InsightValidationControl()
        {
            UnsubscribeEvents();
            ConnectDisconnect();
        }

        /// <summary>
        /// Unsubscribe any events before shutting down.
        /// </summary>
        private void UnsubscribeEvents()
        {
            inSightSystem._inSight.ResultsChanged -= OnResultsChanged;
            inSightSystem._inSight.PreviewMessage -= OnPreviewMessage;
            inSightSystem._inSight.ConnectedChanged -= OnConnectedChanged;
            inSightSystem._inSight.ConnectingChanged += OnConnectingChanged;
            inSightSystem._inSight.StateChanged -= OnStateChanged;
            inSightSystem._inSight.LiveModeChanged -= OnLiveModeChanged;
            inSightSystem._inSight.JobInfoChanged -= OnJobInfoChanged;
            inSightSystem._inSight.JobLoadingChanged -= OnJobLoadingChanged;
            inSightSystem._inSight.EditorAttachedChanged -= OnEditorAttachedChanged;
        }

        private async void OnEditorAttachedChanged(object sender, EventArgs e)
        {
            InitForNewJob();
            UpdateState();
            await cvsDisplay1.UpdateResults();  
        }

        private void OnJobLoadingChanged(object sender, EventArgs e)
        {
            InitForNewJob();  
            onJobLoad(e);
        }

        private void OnJobInfoChanged(object sender, EventArgs e)
        {
            InitForNewJob(); // Handle sheet re-format
            OnResultsChanged(sender, e); // Be sure we re-process the result after job load
            UpdateState();
        }

        private void OnLiveModeChanged(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void OnStateChanged(object sender, EventArgs e)
        {
            UpdateState();  
        }

        private void OnConnectingChanged(object sender, EventArgs e)
        {
            UpdateState();
        }


        private void InitForNewJob()
        {
            cvsSpreadsheet1.Invoke((Action)delegate
            {
                cvsSpreadsheet1.InitSpreadsheet(); // Clear the spreadsheet
                //cvsCustomView1.InitSpreadsheet(); // Clear the custom View
                cvsDisplay1.InitDisplay(); // Clear the graphics

            });

        }

        /// <summary>
        /// Updates the controls that use the state (i.e.  not connected/connected, offline/online, live mode)
        /// </summary>
        public void UpdateState()
        {
            try
            {
                lblState.Invoke((Action)delegate
                {
                    btnConnectDisconnect.Enabled = !inSightSystem._inSight.Connecting;
                    btnConnectDisconnect.Text = inSightSystem._inSight.Connected ? "Disconnect" : "Connect";


                    if (inSightSystem._inSight.Connected)
                    {
                        string stateText = inSightSystem._inSight.Online ? "Online" : "Offline";
                        if (inSightSystem._inSight.EditorAttached)
                            stateText = "ISVS Connected, " + stateText;

                        if (inSightSystem._inSight.Online) lblState.ForeColor = Color.Green; else lblState.ForeColor = Color.Yellow;
                        lblState.Font = new Font("Times New Roman", 14.0f, FontStyle.Bold);
                        lblState.Text = stateText;


                        //onlineMenuItem.Text = inSightSystem._inSight.Online ? "Go Offline" : "Go Online";
                        //liveModeMenuItem.Checked = _inSight.LiveMode;
                        string jobName = inSightSystem._inSight.JobInfo["name"].Value<String>();
                        jobName = jobName.Replace("/", "").Replace("\\", ""); ;
                        lblJobInfo.Text = "Current Job: " + jobName;
                        jobName = String.Empty;
                        lblimgsload.Text ="Images Loaded: " + inSightSystem._imageEntries.Count.ToString();
                        
                        if (!this.btnRunValidation.Text.Contains("Validation In Process from"))
                        {
                            this.btnRunValidation.Enabled = true;
                            this.imgsFolderbtn.Enabled = true;
                        }



                    }
                    else
                    {
                        lblState.Text = inSightSystem._inSight.Connecting ? "Connecting..." : "Not Connected";
                        lblState.Font = new Font("Times New Roman", 14.0f, FontStyle.Bold);
                        if (inSightSystem._inSight.Connecting) lblState.ForeColor = Color.Blue; else lblState.ForeColor = Color.Red;
                        //onlineMenuItem.Text = "Go Online";
                        //liveModeMenuItem.Checked = false;
                        dgwImageResults.Rows.Clear();
                        inSightSystem._imageEntries.Clear();
                        inSightSystem._imageLoaded = false;
                        lblValidationResult.Text = "None";
                        lblValidationResult.ForeColor = Color.Orange;
                        this.lblNativeStatus.ForeColor = Color.Red;

                        this.btnRunValidation.Enabled = false;
                        this.imgsFolderbtn.Enabled = false;
                        this.lblimgsload.Text = "Images Loaded : 0";
                        this.lblJobInfo.Text = "Current Job";
                        this.lblNativeStatus.Text = "Native Not Connected";
                        //this.lblPLCStatus.Text = "PLC Not Connected";
                    }

                    //aboutMenuItem.Enabled = _inSight.Connected;

                   // bool connectedButNotBusy = inSightSystem._inSight.Connected && !inSightSystem._inSight.EditorAttached && !inSightSystem._inSight.JobLoading;
                    //bool isOffline = connectedButNotBusy && !inSightSystem._inSight.Online;

                    //triggerMenuItem.Enabled = connectedButNotBusy;
                    //onlineMenuItem.Enabled = connectedButNotBusy;
                    //liveModeMenuItem.Enabled = isOffline;
                    //loadImageMenuItem.Enabled = isOffline;
                    //loadImageMenuItem.Enabled = true;
                    //loadHmiCellsMenuItem.Enabled = isOffline;
                    //saveImageMenuItem.Enabled = connectedButNotBusy;
                    //loadJobMenuItem.Enabled = isOffline;
                    //hmiCustomViewMenuItem.Enabled = isOffline;
                    //hmiSettingsMenuItem.Enabled = isOffline;
                    //openHMIMenuItem.Enabled = connectedButNotBusy;

                    //Update Results on Mainform

                    // if(m_results != null ) MessageBox.Show(m_results.ToString());

                    //cvsFilmstrip.Enabled = _inSight.Connected && !_inSight.JobLoading;
                    //saveQueuedImagesToolStripMenuItem.Enabled = _inSight.Connected;

                    // this.splitContainer1.Panel2Collapsed = !showSpreadsheetToolStripMenuItem.Checked;

                    // cvsCustomView1.Visible = inSightSystem._inSight.Connected && !inSightSystem._inSight.JobLoading && (inSightSystem._inSight.CustomViewSettings.Length > 0) && (inSightSystem._inSight.CustomViewSettings?[0] != null) && showCustomViewToolStripMenuItem.Checked;
                    //cvsCustomView1.Visible = cvsCustomView1.Visible = inSightSystem._inSight.Connected && !inSightSystem._inSight.JobLoading && (inSightSystem._inSight.CustomViewSettings.Length > 0) && (inSightSystem._inSight.CustomViewSettings?[0] != null);
                    //if (cvsCustomView1.Visible)
                    //{
                      //  CenterCustomView();
                       // cvsCustomView1.setCustomViewName(inSightSystem._inSight);
                    //}
                    onUpdateEvent(EventArgs.Empty); 


                });
            }
            catch (Exception)
            {
                // Ignore
            }
        }

        private void CenterCustomView()
        {
            if ((inSightSystem._inSight != null) && (inSightSystem._inSight.CustomViewSettings != null))
            {
                HmiCustomViewSettings cvSettings = inSightSystem._inSight.CustomViewSettings?[0];
                if (cvSettings != null)
                {
                    // Always display it centered for now,
                  //  this.cvsCustomView1.SetBounds((cvsDisplay1.Width - cvSettings.Width) / 2, (cvsDisplay1.Height - cvSettings.Height) / 2, cvSettings.Width, cvSettings.Height);
                }
            }
        }

        private async void OnConnectedChanged(object sender, EventArgs e)
        {
            InitForNewJob();
            UpdateState();

            if (InSight._inSight.Connected)
            {
                await this.cvsDisplay1.OnConnected();
                onConnected(e);
            }
            else {  
                OnDisconnected(e);  
            }
        }



        private void OnPreviewMessage(object sender, Cognex.SimpleCogSocket.MessagePayloadPreviewEventArgs e)
        {
            string msg = (e.Payload?.ToString() ?? "");
            int len = msg.Length;

            if (msg.Length > 150)
            {
                msg = msg.Substring(0, 100) + "..." + msg.Substring(msg.Length - 50, 50);
            }

            if (inSightSystem._inSight.Connected)
            {
                Debug.WriteLine($"[{Name}] [Len:{len}] {msg}");
            }

            if (msg.Contains("manualTrigger"))
            {
                inSightSystem._startTicks = Environment.TickCount;
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

        public async void OnResultsChanged(object sender, EventArgs e)
        {
            JToken results = inSightSystem._inSight.Results;
            //inSightSystem.Results = results;

            //If Camera is connected and Images Loaded into GridView retrieve Job Result 
            


                if (inSightSystem._inSight.Connected == true && inSightSystem._imageLoaded == true && (currentIndex < inSightSystem._imageEntries.Count) == true)
                {
                    this.lblState.Invoke((Action)delegate
                    {
                        this.lblimgsload.Text = "Images Sent To Validation: " + currentIndex + "/" + inSightSystem._imageEntries.Count.ToString();

                    });


                if (!ignoreResult)
                {
                    // MessageBox.Show(m_currentIndex.ToString());
                    if (results["jobStatus"].Value<int>() != 1)
                    {
                        inSightSystem._imageEntries[currentIndex].ActualResult = false;
                    }
                    else
                    {
                        inSightSystem._imageEntries[currentIndex].ActualResult = true;
                    }
                    cvsSpreadsheet1.UpdateResults(results);
                }
                else
                { //TODO: Find a more elegant way to do this 
                    ignoreResult = false;
                    currentIndex = -1;
                }   //cvsCustomView1.UpdateResults(results);

                }

                UpdateDataGridView();
                //UpdateMessages();
                if (inSightSystem._inSight.Connected) UpdateValidationResult();
                await this.cvsDisplay1.UpdateResults();

                //cvsFilmstrip.UpdateResults();
                if (secuence && (currentIndex < inSightSystem._imageEntries.Count))
                {
                    currentIndex++;
                    inSightSystem._imageProcessedSignal.TrySetResult(true);
                }

            
           
        }

        internal InSightDevice InSight { get => inSightSystem; set => inSightSystem = value; }

        private void InitializeDataGridView()
        {


            dgwImageResults.AutoGenerateColumns = false;
            dgwImageResults.AllowUserToAddRows = false;
            dgwImageResults.AllowUserToDeleteRows = false;

            // Use a more efficient color initialization
            dgwImageResults.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgwImageResults.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgwImageResults.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 12.0f, FontStyle.Bold);

            // Column for Thumbnail
            var imageColumn = new DataGridViewImageColumn
            {
                HeaderText = "Image Preview",
                ImageLayout = DataGridViewImageCellLayout.Zoom, // Zoom to fit cell size
                Width = ThumbnailSize,
                Name = "ImagePreview",
                DataPropertyName = "Preview" // DataPropertyName should match the property in ImageEntry
            };
            dgwImageResults.Columns.Add(imageColumn);

            // Column for Filename
            var filenameColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Image Name",
                Width = 400,
                DataPropertyName = "Filename", // Corrected to match the property name
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            dgwImageResults.Columns.Add(filenameColumn);

            // Column for Expected Result (ComboBox)
            var expectedColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Expected Result",
                Width = 100,
                DataPropertyName = "ExpectedResult",
                DisplayMember = "Text",
                ValueMember = "Value",
                DataSource = new List<object>
        {
            new { Text = "Pass", Value = true },
            new { Text = "Fail", Value = false }
        },
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                Name = "ExpectedResult"
            };
            dgwImageResults.Columns.Add(expectedColumn);

            // Column for Actual Result
            var actualColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Actual Result",
                DataPropertyName = "ActualResult",
                Name = "ActualResult"
            };
            dgwImageResults.Columns.Add(actualColumn);

            dgwImageResults.RowTemplate.Height = RowHeight;

            // Manage event subscriptions
            dgwImageResults.CellValueChanged -= dgwImageResults_CellValueChanged; // Avoid duplicate subscriptions
            dgwImageResults.CellValueChanged += dgwImageResults_CellValueChanged;

            dgwImageResults.CellDoubleClick -= dgwImageResults_CellDoubleClick; // Avoid duplicate subscriptions
            dgwImageResults.CellDoubleClick += dgwImageResults_CellDoubleClick;
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
            foreach (DataGridViewRow row in dgwImageResults.Rows)
            {
                int desiredHeight = ThumbnailSize + dgwImageResults.RowTemplate.DefaultCellStyle.Padding.Vertical;
                row.Height = desiredHeight;
            }
        }

        private void AutoResizeColumnWidths()
        {
            // Autoresize column widths to fill DataGridView
            int totalColumnWidths = dgwImageResults.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            int dataGridViewWidth = dgwImageResults.ClientSize.Width;

            // Adjust only if the total column widths are less than the DataGridView width
            if (totalColumnWidths < dataGridViewWidth)
            {
                foreach (DataGridViewColumn column in dgwImageResults.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        public void UpdateDataGridView(bool updateResults = true)
        {
            // Avoid invoking on the UI thread if not necessary
            dgwImageResults.Invoke((Action)delegate
            {
                dgwImageResults.Rows.Clear();

                if (inSightSystem._imageEntries.Count > 0)
                {
                    inSightSystem._imageLoaded = true;
                }

                // Prepare data for batch update to avoid excessive UI updates
                var rows = new List<DataGridViewRow>();

                foreach (var entry in inSightSystem._imageEntries)
                {
                    // Create and configure a new row
                    var row = new DataGridViewRow();

                    // Add Thumbnail (Image) cell
                    var imageCell = new DataGridViewImageCell
                    {
                        Value = ResizeImage(System.Drawing.Image.FromFile(entry.Path), ThumbnailSize, ThumbnailSize)
                    };
                    row.Cells.Add(imageCell);

                    // Add Filename cell
                    var filenameCell = new DataGridViewTextBoxCell
                    {
                        Value = entry.Filename,
                        Style = { ForeColor = Color.White, Font = new Font("Times New Roman", 16.0f, FontStyle.Bold) }
                    };
                    row.Cells.Add(filenameCell);

                    // Add Expected Result (ComboBox) cell
                    var expectedCell = new DataGridViewComboBoxCell
                    {
                        DisplayMember = "Text",
                        ValueMember = "Value",
                        DataSource = new List<object>
                {
                    new { Text = "Pass", Value = true },
                    new { Text = "Fail", Value = false }
                },
                        Value = entry.ExpectedResult,
                        ReadOnly = false,
                        Style = { ForeColor = Color.White, Font = new Font("Times New Roman", 16.0f, FontStyle.Bold) }
                    };
                    row.Cells.Add(expectedCell);

                    // Add Actual Result (TextBox) cell
                    var actualCell = new DataGridViewTextBoxCell
                    {
                        Value = entry.ActualResult ? "Pass" : "Fail",
                        Style = { ForeColor = Color.White, Font = new Font("Times New Roman", 16.0f, FontStyle.Bold) }
                    };

                    // Color Background based on results
                    row.DefaultCellStyle.BackColor = (bool)expectedCell.Value != entry.ActualResult ? Color.Red : Color.Green;
                    row.Cells.Add(actualCell);

                    // Add the row to the list
                    rows.Add(row);
                }

                // Add all rows in one go to avoid multiple UI updates
                dgwImageResults.Rows.AddRange(rows.ToArray());

                // Auto-resize row heights and column widths
                AutoResizeRowHeights();
                AutoResizeColumnWidths();

                // Update the validation result
                if(updateResults)UpdateValidationResult();
            });
        }


        private void UpdateValidationResult()
        {
            //Console.WriteLine("Results to Update");

            inSightSystem._validationResult = true;
            foreach (DataGridViewRow row in dgwImageResults.Rows)
            {
                bool actual = false;
                bool expected = (bool)row.Cells["ExpectedResult"].Value;
                if (row.Cells["ActualResult"].Value.ToString() == "Pass") actual = true; else actual = false;
                if (expected != actual) inSightSystem._validationResult = false;
            }

            //if (inSightSystem._validationResult) InSight.WriteValidationResult("Pass"); else InSight.WriteValidationResult("Fail");
            try
            {
                if (lblValidationResult.IsHandleCreated)
                {
                    lblValidationResult.BeginInvoke((Action)delegate
                     {

                         if (inSightSystem._validationResult)
                         {
                             lblValidationResult.Text = "Pass";
                             lblValidationResult.ForeColor = Color.Green;
                         }
                         else
                         {
                             lblValidationResult.Text = "Fail";
                             lblValidationResult.ForeColor = Color.Red;

                         }

                     });
                }
            }
            catch (Exception ex) { 
            
            }
        }
        private void dgwImageResults_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure valid cell
            {
                DataGridViewRow row = dgwImageResults.Rows[e.RowIndex];
                InSightDevice.ImageEntry entry = inSightSystem._imageEntries[e.RowIndex];

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
                inSightSystem._imageEntries[e.RowIndex] = entry;
            }
        }

        private async void dgwImageResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Check if the double-clicked cell is in the thumbnail column
                if (dgwImageResults.Columns[e.ColumnIndex].Name == "ImagePreview")
                {
                    // Retrieve the filename or other identifier from the DataGridView cell
                    DataGridViewRow row = dgwImageResults.Rows[e.RowIndex];
                    string filename = inSightSystem._imageEntries[e.RowIndex].Path;
                    currentIndex = e.RowIndex;
                    // Call LoadImage async method
                    await inSightSystem.LoadImage(filename);
                    InSight.WriteValidationResult(lblValidationResult.Text);

                }
            }

        }
        private List<InSightDevice.ImageEntry> LoadImagesFromPaths(List<string> imagePaths)
        {
            var imageEntries = new List<InSightDevice.ImageEntry>();

            foreach (var imagePath in imagePaths)
            {
                string filename = Path.GetFileName(imagePath);
                imageEntries.Add(new InSightDevice.ImageEntry
                {
                    Path = imagePath,
                    Filename = filename
                });
            }

            return imageEntries;
        }
        private void PopulateGridView()
        {


            inSightSystem._imageEntries = LoadImagesFromPaths(imgspath);
            UpdateDataGridView();

        }


        /// <summary>
        /// Handles loading images in sequence 
        /// </summary>
        private async void LoadImagestoInSight()
        {
            if (inSightSystem._inSight.Connected && inSightSystem._imageLoaded)
            {
                // Disable validation button
                btnRunValidation.Invoke((Action)delegate
                {
                    btnRunValidation.Enabled = false;
                    btnRunValidation.Text = $"Validation In Process from {validationSecuenceSender}";
                });

                OnValidationStart("neutral");
                if (inSightSystem._inSight.Online) ignoreResult = true; 



                await inSightSystem.SetCameraStatus(false);

                // Start from beginning
                currentIndex = 0;
                secuence = true;
                previousState = true;

                foreach (var entry in inSightSystem._imageEntries)
                {
                    try
                    {
                        // Send image and wait
                        await inSightSystem.SendImageAndWait(entry.Path);

                        // Explicitly clear unused image resources
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show($"LoadImage Exception: {e.Message}");
                    }
                }

                await inSightSystem.SetCameraStatus(true);

                // Re-enable validation button
                btnRunValidation.Invoke((Action)delegate
                {
                    btnRunValidation.Enabled = true;
                    btnRunValidation.Text = "Run Validation";
                    lblimgsload.Text = $"Images Loaded: {inSightSystem._imageEntries.Count}";
                });

                // Write validation result
                InSight.WriteValidationResult(lblValidationResult.Text);

                //Write Last Time validation Ran
                lblValidationLastRun.Invoke((Action)delegate {
                    lblValidationLastRun.Text ="Last Validation: " + DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt");
                });


                // Perform manual trigger
                await InSight.ManualTrigger();

                OnValidationCompleted(lblValidationResult.Text);
                // Dispose resources
                validationSecuenceSender = string.Empty;

                // Optional: Reset validation trigger if needed
            }
        }

        //Action Buttons

        private void btnRunValidation_Click(object sender, EventArgs e)
        {
            if (inSightSystem._inSight.Connected)
            {
                this.validationSecuenceSender = "GUI";
                LoadImagestoInSight();
                

            }
        }

        private async void btnConnectDisconnect_Click(object sender, EventArgs e)
        {
            
            await InSight.Connect();

           
        }

        public async void ConnectDisconnect() {

           await inSightSystem.Connect();
        }


        private void imgsFolderbtn_Click(object sender, EventArgs e)
        {
            if (inSightSystem._inSight.Connected)
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
                        lblimgsload.Text ="Images Loaded: " + imgspath.Count.ToString();
                        PopulateGridView();
                    }
                }
            }
        }

        public async void OnlineOffline() {

            await inSightSystem.SetCameraStatus(!inSightSystem._inSight.Online);
        }

        public async void loadValidationConfig() {
            
            // Set Camera connection Parameters
            string ipwithport = String.Empty;
            
            JToken cameraConnection = InSight.Configuration["CameraConnection"].Value<JToken>();
            JToken ImageEntryData = InSight.Configuration["Images"].Value<JToken>();
            tbIpAddressWithPort.Text = cameraConnection["IPAddressPort"].Value<String>();
            tbUsername.Text = cameraConnection["User"].Value<String>();
            tbPassword.Text = cameraConnection["Password"].Value<String>();

            //Connect if specified
            if (cameraConnection["AutoConnect"].Value<Boolean>())
            {
                //  chkAutoConnect.CheckState = CheckState.Checked;
                await InSight.Connect();
            }

            //LoadJobFile If neccesary
            if (InSight.Configuration["JobFile"].Value<String>() != InSight._inSight.JobInfo["name"].Value<String>())
            {
                await InSight.LoadJob(InSight.Configuration["JobFile"].Value<String>());

            }
            //Set Image Folder Parameters and load image
            InSight._imageEntries.Clear();  
            InSight._imageLoaded = false;
            //m_ImagesLoaded = false;

            InSight._imageEntries = JsonConvert.DeserializeObject<List<InSightDevice.ImageEntry>>(ImageEntryData.ToString());

            UpdateDataGridView(updateResults:false);
           // UpdateState();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TbIpAddressWithPort_TextChanged(object sender, System.EventArgs e)
        {
            this.InSight.IpAddressWithPort = tbIpAddressWithPort.Text;   
        }
        private void TbUsername_TextChanged(object sender, System.EventArgs e)
        {
            this.InSight.UserName = tbUsername.Text; 
        }

        private void TbPassword_TextChanged(object sender, System.EventArgs e)
        {
            this.InSight.Password = tbPassword.Text; 
        }
    }
}
