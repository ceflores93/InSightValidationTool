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

using Cognex.InSight.Web.Controls;

namespace InSightValidationTool
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param> name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnConnectDisconnect = new System.Windows.Forms.Button();
            this.tbIpAddressWithPort = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.tbMessages = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadValidationFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveValidationFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.loadJobMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadHmiCellsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hmiCustomViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openHMIMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCustomViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSpreadsheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triggerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveModeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveQueuedImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hmiSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shwMenuBar = new System.Windows.Forms.CheckBox();
            this.imgsFolderbtn = new System.Windows.Forms.Button();
            this.lblimgsload = new System.Windows.Forms.Label();
            this.btnRunValidation = new System.Windows.Forms.Button();
            this.chkAutoConnect = new System.Windows.Forms.CheckBox();
            this.lblJobInfo = new System.Windows.Forms.Label();
            this.dgwImageResults = new System.Windows.Forms.DataGridView();
            this.cvsCustomView = new Cognex.InSight.Web.Controls.CvsCustomView();
            this.cvsDisplay = new Cognex.InSight.Web.Controls.CvsDisplay();
            this.cvsSpreadsheet = new Cognex.InSight.Web.Controls.CvsSpreadsheet();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblValidationResultBanner = new System.Windows.Forms.Label();
            this.lblValidationResult = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwImageResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnectDisconnect
            // 
            this.btnConnectDisconnect.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectDisconnect.Location = new System.Drawing.Point(6, 88);
            this.btnConnectDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnectDisconnect.Name = "btnConnectDisconnect";
            this.btnConnectDisconnect.Size = new System.Drawing.Size(92, 27);
            this.btnConnectDisconnect.TabIndex = 4;
            this.btnConnectDisconnect.Text = "Connect";
            this.btnConnectDisconnect.UseVisualStyleBackColor = true;
            this.btnConnectDisconnect.Click += new System.EventHandler(this.btnConnectDisconnect_Click);
            // 
            // tbIpAddressWithPort
            // 
            this.tbIpAddressWithPort.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIpAddressWithPort.Location = new System.Drawing.Point(102, 91);
            this.tbIpAddressWithPort.Margin = new System.Windows.Forms.Padding(2);
            this.tbIpAddressWithPort.Name = "tbIpAddressWithPort";
            this.tbIpAddressWithPort.Size = new System.Drawing.Size(96, 23);
            this.tbIpAddressWithPort.TabIndex = 5;
            this.tbIpAddressWithPort.Text = "127.0.0.1:80";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(202, 91);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(69, 23);
            this.tbUsername.TabIndex = 6;
            this.tbUsername.Text = "admin";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(275, 91);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(89, 23);
            this.tbPassword.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Address and port:";
            // 
            // lblState
            // 
            this.lblState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(1708, 96);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(117, 19);
            this.lblState.TabIndex = 11;
            this.lblState.Text = "Not Connected";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMessages
            // 
            this.tbMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessages.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMessages.Location = new System.Drawing.Point(18, 2037);
            this.tbMessages.Margin = new System.Windows.Forms.Padding(2);
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMessages.Size = new System.Drawing.Size(1893, 27);
            this.tbMessages.TabIndex = 0;
            this.tbMessages.WordWrap = false;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.viewMenuItem,
            this.imageMenuItem,
            this.sensorMenuItem,
            this.systemMenuItem,
            this.helpMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(1902, 28);
            this.menuStrip.TabIndex = 25;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadValidationFileToolStripMenuItem,
            this.saveValidationFileToolStripMenuItem,
            this.toolStripSeparator2,
            this.loadJobMenuItem,
            this.loadHmiCellsMenuItem,
            this.toolStripSeparator1,
            this.loadImageMenuItem,
            this.saveImageMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileMenuItem.Text = "File";
            // 
            // loadValidationFileToolStripMenuItem
            // 
            this.loadValidationFileToolStripMenuItem.Name = "loadValidationFileToolStripMenuItem";
            this.loadValidationFileToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.loadValidationFileToolStripMenuItem.Text = "Load Validation File";
            this.loadValidationFileToolStripMenuItem.Click += new System.EventHandler(this.loadValidationFileToolStripMenuItem_Click);
            // 
            // saveValidationFileToolStripMenuItem
            // 
            this.saveValidationFileToolStripMenuItem.Name = "saveValidationFileToolStripMenuItem";
            this.saveValidationFileToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.saveValidationFileToolStripMenuItem.Text = "Save Validation File";
            this.saveValidationFileToolStripMenuItem.Click += new System.EventHandler(this.saveValidationFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(220, 6);
            // 
            // loadJobMenuItem
            // 
            this.loadJobMenuItem.Name = "loadJobMenuItem";
            this.loadJobMenuItem.Size = new System.Drawing.Size(223, 26);
            this.loadJobMenuItem.Text = "Load Job...";
            this.loadJobMenuItem.Click += new System.EventHandler(this.loadJobMenuItem_Click);
            // 
            // loadHmiCellsMenuItem
            // 
            this.loadHmiCellsMenuItem.Name = "loadHmiCellsMenuItem";
            this.loadHmiCellsMenuItem.Size = new System.Drawing.Size(223, 26);
            this.loadHmiCellsMenuItem.Text = "Load HMI Cells...";
            this.loadHmiCellsMenuItem.Click += new System.EventHandler(this.loadHmiCellsMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // loadImageMenuItem
            // 
            this.loadImageMenuItem.Name = "loadImageMenuItem";
            this.loadImageMenuItem.Size = new System.Drawing.Size(223, 26);
            this.loadImageMenuItem.Text = "Load Image...";
            this.loadImageMenuItem.Click += new System.EventHandler(this.loadImageMenuItem_Click);
            // 
            // saveImageMenuItem
            // 
            this.saveImageMenuItem.Name = "saveImageMenuItem";
            this.saveImageMenuItem.Size = new System.Drawing.Size(223, 26);
            this.saveImageMenuItem.Text = "Save Image...";
            this.saveImageMenuItem.Click += new System.EventHandler(this.saveImageMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hmiCustomViewMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editMenuItem.Text = "Edit";
            // 
            // hmiCustomViewMenuItem
            // 
            this.hmiCustomViewMenuItem.Name = "hmiCustomViewMenuItem";
            this.hmiCustomViewMenuItem.Size = new System.Drawing.Size(244, 26);
            this.hmiCustomViewMenuItem.Text = "Set HMI Custom View...";
            this.hmiCustomViewMenuItem.Click += new System.EventHandler(this.hmiCustomViewMenuItem_Click);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openHMIMenuItem,
            this.showCustomViewToolStripMenuItem,
            this.showSpreadsheetToolStripMenuItem});
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewMenuItem.Text = "View";
            // 
            // openHMIMenuItem
            // 
            this.openHMIMenuItem.Name = "openHMIMenuItem";
            this.openHMIMenuItem.Size = new System.Drawing.Size(218, 26);
            this.openHMIMenuItem.Text = "Open HMI...";
            this.openHMIMenuItem.Click += new System.EventHandler(this.openHMIMenuItem_Click);
            // 
            // showCustomViewToolStripMenuItem
            // 
            this.showCustomViewToolStripMenuItem.Checked = true;
            this.showCustomViewToolStripMenuItem.CheckOnClick = true;
            this.showCustomViewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showCustomViewToolStripMenuItem.Name = "showCustomViewToolStripMenuItem";
            this.showCustomViewToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.showCustomViewToolStripMenuItem.Text = "Show Custom View";
            this.showCustomViewToolStripMenuItem.Click += new System.EventHandler(this.showCustomViewToolStripMenuItem_Click);
            // 
            // showSpreadsheetToolStripMenuItem
            // 
            this.showSpreadsheetToolStripMenuItem.CheckOnClick = true;
            this.showSpreadsheetToolStripMenuItem.Name = "showSpreadsheetToolStripMenuItem";
            this.showSpreadsheetToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.showSpreadsheetToolStripMenuItem.Text = "Show Spreadsheet";
            this.showSpreadsheetToolStripMenuItem.Click += new System.EventHandler(this.showSpreadsheetToolStripMenuItem_Click);
            // 
            // imageMenuItem
            // 
            this.imageMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.triggerMenuItem});
            this.imageMenuItem.Name = "imageMenuItem";
            this.imageMenuItem.Size = new System.Drawing.Size(65, 24);
            this.imageMenuItem.Text = "Image";
            // 
            // triggerMenuItem
            // 
            this.triggerMenuItem.Name = "triggerMenuItem";
            this.triggerMenuItem.Size = new System.Drawing.Size(139, 26);
            this.triggerMenuItem.Text = "Trigger";
            this.triggerMenuItem.Click += new System.EventHandler(this.triggerMenuItem_Click);
            // 
            // sensorMenuItem
            // 
            this.sensorMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineMenuItem,
            this.liveModeMenuItem,
            this.saveQueuedImagesToolStripMenuItem});
            this.sensorMenuItem.Name = "sensorMenuItem";
            this.sensorMenuItem.Size = new System.Drawing.Size(67, 24);
            this.sensorMenuItem.Text = "Sensor";
            // 
            // onlineMenuItem
            // 
            this.onlineMenuItem.Name = "onlineMenuItem";
            this.onlineMenuItem.Size = new System.Drawing.Size(262, 26);
            this.onlineMenuItem.Text = "Online";
            this.onlineMenuItem.Click += new System.EventHandler(this.onlineMenuItem_Click);
            // 
            // liveModeMenuItem
            // 
            this.liveModeMenuItem.Name = "liveModeMenuItem";
            this.liveModeMenuItem.Size = new System.Drawing.Size(262, 26);
            this.liveModeMenuItem.Text = "Live Mode";
            this.liveModeMenuItem.Click += new System.EventHandler(this.liveModeToolStripMenuItem_Click);
            // 
            // saveQueuedImagesToolStripMenuItem
            // 
            this.saveQueuedImagesToolStripMenuItem.Name = "saveQueuedImagesToolStripMenuItem";
            this.saveQueuedImagesToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.saveQueuedImagesToolStripMenuItem.Text = "Get Queued Image URLs...";
            this.saveQueuedImagesToolStripMenuItem.Click += new System.EventHandler(this.getQueuedImageURLsToolStripMenuItem_Click);
            // 
            // systemMenuItem
            // 
            this.systemMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hmiSettingsMenuItem});
            this.systemMenuItem.Name = "systemMenuItem";
            this.systemMenuItem.Size = new System.Drawing.Size(70, 24);
            this.systemMenuItem.Text = "System";
            // 
            // hmiSettingsMenuItem
            // 
            this.hmiSettingsMenuItem.Name = "hmiSettingsMenuItem";
            this.hmiSettingsMenuItem.Size = new System.Drawing.Size(186, 26);
            this.hmiSettingsMenuItem.Text = "HMI Settings...";
            this.hmiSettingsMenuItem.Click += new System.EventHandler(this.hmiSettingsMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(195, 26);
            this.aboutMenuItem.Text = "About camera...";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // shwMenuBar
            // 
            this.shwMenuBar.AutoSize = true;
            this.shwMenuBar.Location = new System.Drawing.Point(1080, 7);
            this.shwMenuBar.Name = "shwMenuBar";
            this.shwMenuBar.Size = new System.Drawing.Size(87, 21);
            this.shwMenuBar.TabIndex = 27;
            this.shwMenuBar.Text = "ShowMenu";
            this.shwMenuBar.UseVisualStyleBackColor = true;
            this.shwMenuBar.CheckedChanged += new System.EventHandler(this.shwMenuBar_CheckedChanged);
            // 
            // imgsFolderbtn
            // 
            this.imgsFolderbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.imgsFolderbtn.AutoSize = true;
            this.imgsFolderbtn.Location = new System.Drawing.Point(379, 84);
            this.imgsFolderbtn.Name = "imgsFolderbtn";
            this.imgsFolderbtn.Size = new System.Drawing.Size(103, 34);
            this.imgsFolderbtn.TabIndex = 28;
            this.imgsFolderbtn.Text = "Load Images";
            this.imgsFolderbtn.UseVisualStyleBackColor = true;
            this.imgsFolderbtn.Click += new System.EventHandler(this.imgsFolderbtn_Click);
            // 
            // lblimgsload
            // 
            this.lblimgsload.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblimgsload.AutoSize = true;
            this.lblimgsload.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimgsload.Location = new System.Drawing.Point(487, 95);
            this.lblimgsload.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblimgsload.Name = "lblimgsload";
            this.lblimgsload.Size = new System.Drawing.Size(97, 15);
            this.lblimgsload.TabIndex = 29;
            this.lblimgsload.Text = "0 Images Found";
            this.lblimgsload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRunValidation
            // 
            this.btnRunValidation.Location = new System.Drawing.Point(761, 88);
            this.btnRunValidation.Name = "btnRunValidation";
            this.btnRunValidation.Size = new System.Drawing.Size(113, 32);
            this.btnRunValidation.TabIndex = 30;
            this.btnRunValidation.Text = "Run Validation";
            this.btnRunValidation.UseVisualStyleBackColor = true;
            this.btnRunValidation.Click += new System.EventHandler(this.btnRunValidation_Click);
            // 
            // chkAutoConnect
            // 
            this.chkAutoConnect.AutoSize = true;
            this.chkAutoConnect.Location = new System.Drawing.Point(6, 62);
            this.chkAutoConnect.Name = "chkAutoConnect";
            this.chkAutoConnect.Size = new System.Drawing.Size(92, 21);
            this.chkAutoConnect.TabIndex = 31;
            this.chkAutoConnect.Text = "AutoConnect";
            this.chkAutoConnect.UseVisualStyleBackColor = true;
            // 
            // lblJobInfo
            // 
            this.lblJobInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJobInfo.AutoSize = true;
            this.lblJobInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobInfo.Location = new System.Drawing.Point(1110, 99);
            this.lblJobInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJobInfo.Name = "lblJobInfo";
            this.lblJobInfo.Size = new System.Drawing.Size(101, 19);
            this.lblJobInfo.TabIndex = 32;
            this.lblJobInfo.Text = "Current Job:";
            this.lblJobInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgwImageResults
            // 
            this.dgwImageResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwImageResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwImageResults.Location = new System.Drawing.Point(0, 0);
            this.dgwImageResults.Margin = new System.Windows.Forms.Padding(4);
            this.dgwImageResults.Name = "dgwImageResults";
            this.dgwImageResults.RowHeadersWidth = 51;
            this.dgwImageResults.RowTemplate.Height = 24;
            this.dgwImageResults.Size = new System.Drawing.Size(849, 904);
            this.dgwImageResults.TabIndex = 33;
            // 
            // cvsCustomView
            // 
            this.cvsCustomView.AllowDrop = true;
            this.cvsCustomView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cvsCustomView.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cvsCustomView.Location = new System.Drawing.Point(108, 59);
            this.cvsCustomView.Margin = new System.Windows.Forms.Padding(0);
            this.cvsCustomView.Name = "cvsCustomView";
            this.cvsCustomView.Size = new System.Drawing.Size(125, 187);
            this.cvsCustomView.TabIndex = 25;
            // 
            // cvsDisplay
            // 
            this.cvsDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cvsDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cvsDisplay.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvsDisplay.Location = new System.Drawing.Point(0, 0);
            this.cvsDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.cvsDisplay.Name = "cvsDisplay";
            this.cvsDisplay.Size = new System.Drawing.Size(1043, 904);
            this.cvsDisplay.TabIndex = 19;
            // 
            // cvsSpreadsheet
            // 
            this.cvsSpreadsheet.AllowDrop = true;
            this.cvsSpreadsheet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cvsSpreadsheet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cvsSpreadsheet.Location = new System.Drawing.Point(3, 0);
            this.cvsSpreadsheet.Margin = new System.Windows.Forms.Padding(0);
            this.cvsSpreadsheet.Name = "cvsSpreadsheet";
            this.cvsSpreadsheet.Size = new System.Drawing.Size(846, 904);
            this.cvsSpreadsheet.TabIndex = 0;
            this.cvsSpreadsheet.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(2, 127);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cvsCustomView);
            this.splitContainer1.Panel1.Controls.Add(this.cvsDisplay);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cvsSpreadsheet);
            this.splitContainer1.Panel2.Controls.Add(this.dgwImageResults);
            this.splitContainer1.Size = new System.Drawing.Size(1894, 904);
            this.splitContainer1.SplitterDistance = 1043;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 26;
            // 
            // lblValidationResultBanner
            // 
            this.lblValidationResultBanner.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidationResultBanner.ForeColor = System.Drawing.Color.Blue;
            this.lblValidationResultBanner.Location = new System.Drawing.Point(1148, 43);
            this.lblValidationResultBanner.Name = "lblValidationResultBanner";
            this.lblValidationResultBanner.Size = new System.Drawing.Size(264, 40);
            this.lblValidationResultBanner.TabIndex = 33;
            this.lblValidationResultBanner.Text = "Validation Result: ";
            this.lblValidationResultBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValidationResult
            // 
            this.lblValidationResult.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidationResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblValidationResult.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblValidationResult.Location = new System.Drawing.Point(1380, 43);
            this.lblValidationResult.Name = "lblValidationResult";
            this.lblValidationResult.Size = new System.Drawing.Size(123, 40);
            this.lblValidationResult.TabIndex = 34;
            this.lblValidationResult.Text = "None";
            this.lblValidationResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.lblValidationResult);
            this.Controls.Add(this.lblValidationResultBanner);
            this.Controls.Add(this.lblJobInfo);
            this.Controls.Add(this.chkAutoConnect);
            this.Controls.Add(this.btnRunValidation);
            this.Controls.Add(this.lblimgsload);
            this.Controls.Add(this.imgsFolderbtn);
            this.Controls.Add(this.shwMenuBar);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbIpAddressWithPort);
            this.Controls.Add(this.btnConnectDisconnect);
            this.Controls.Add(this.tbMessages);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "In-Sight Vision Suite Validation Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwImageResults)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnConnectDisconnect;
    private System.Windows.Forms.TextBox tbIpAddressWithPort;
    private System.Windows.Forms.TextBox tbUsername;
    private System.Windows.Forms.TextBox tbPassword;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblState;
    private System.Windows.Forms.TextBox tbMessages;
    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
    private System.Windows.Forms.ToolStripMenuItem loadJobMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem loadImageMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveImageMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editMenuItem;
    private System.Windows.Forms.ToolStripMenuItem hmiCustomViewMenuItem;
    private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openHMIMenuItem;
    private System.Windows.Forms.ToolStripMenuItem imageMenuItem;
    private System.Windows.Forms.ToolStripMenuItem triggerMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sensorMenuItem;
    private System.Windows.Forms.ToolStripMenuItem onlineMenuItem;
    private System.Windows.Forms.ToolStripMenuItem systemMenuItem;
    private System.Windows.Forms.ToolStripMenuItem hmiSettingsMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
    private System.Windows.Forms.ToolStripMenuItem showCustomViewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem loadHmiCellsMenuItem;
    private System.Windows.Forms.ToolStripMenuItem showSpreadsheetToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem liveModeMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveQueuedImagesToolStripMenuItem;
        private System.Windows.Forms.CheckBox shwMenuBar;
        private System.Windows.Forms.Button imgsFolderbtn;
        private System.Windows.Forms.Label lblimgsload;
        private System.Windows.Forms.Button btnRunValidation;
        private System.Windows.Forms.ToolStripMenuItem loadValidationFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveValidationFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.CheckBox chkAutoConnect;
        private System.Windows.Forms.Label lblJobInfo;
        private System.Windows.Forms.DataGridView dgwImageResults;
        private CvsCustomView cvsCustomView;
        private CvsDisplay cvsDisplay;
        private CvsSpreadsheet cvsSpreadsheet;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblValidationResultBanner;
        private System.Windows.Forms.Label lblValidationResult;
    }
}

