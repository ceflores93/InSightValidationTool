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
            this.loadJobMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadHmiCellsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.controlBox = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRestoreMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.insightValidationControl1 = new WebAPISampleApp.InsightValidationControl();
            this.insightValidationControl2 = new WebAPISampleApp.InsightValidationControl();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwImageResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.controlBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.lblState.Location = new System.Drawing.Point(1715, 96);
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
            this.tbMessages.Size = new System.Drawing.Size(1900, 27);
            this.tbMessages.TabIndex = 0;
            this.tbMessages.WordWrap = false;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.viewMenuItem,
            this.imageMenuItem,
            this.sensorMenuItem,
            this.systemMenuItem,
            this.helpMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(2, 35);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(438, 29);
            this.menuStrip.TabIndex = 25;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadValidationFileToolStripMenuItem,
            this.saveValidationFileToolStripMenuItem,
            this.loadJobMenuItem,
            this.loadHmiCellsMenuItem,
            this.loadImageMenuItem,
            this.saveImageMenuItem});
            this.fileMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(49, 25);
            this.fileMenuItem.Text = "File";
            // 
            // loadValidationFileToolStripMenuItem
            // 
            this.loadValidationFileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.loadValidationFileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loadValidationFileToolStripMenuItem.Name = "loadValidationFileToolStripMenuItem";
            this.loadValidationFileToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.loadValidationFileToolStripMenuItem.Text = "Load Validation File";
            this.loadValidationFileToolStripMenuItem.Click += new System.EventHandler(this.loadValidationFileToolStripMenuItem_Click);
            // 
            // saveValidationFileToolStripMenuItem
            // 
            this.saveValidationFileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.saveValidationFileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveValidationFileToolStripMenuItem.Name = "saveValidationFileToolStripMenuItem";
            this.saveValidationFileToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.saveValidationFileToolStripMenuItem.Text = "Save Validation File";
            this.saveValidationFileToolStripMenuItem.Click += new System.EventHandler(this.saveValidationFileToolStripMenuItem_Click);
            // 
            // loadJobMenuItem
            // 
            this.loadJobMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.loadJobMenuItem.ForeColor = System.Drawing.Color.White;
            this.loadJobMenuItem.Name = "loadJobMenuItem";
            this.loadJobMenuItem.Size = new System.Drawing.Size(230, 26);
            this.loadJobMenuItem.Text = "Load Job...";
            this.loadJobMenuItem.Click += new System.EventHandler(this.loadJobMenuItem_Click);
            // 
            // loadHmiCellsMenuItem
            // 
            this.loadHmiCellsMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.loadHmiCellsMenuItem.ForeColor = System.Drawing.Color.White;
            this.loadHmiCellsMenuItem.Name = "loadHmiCellsMenuItem";
            this.loadHmiCellsMenuItem.Size = new System.Drawing.Size(230, 26);
            this.loadHmiCellsMenuItem.Text = "Load HMI Cells...";
            this.loadHmiCellsMenuItem.Click += new System.EventHandler(this.loadHmiCellsMenuItem_Click);
            // 
            // loadImageMenuItem
            // 
            this.loadImageMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.loadImageMenuItem.ForeColor = System.Drawing.Color.White;
            this.loadImageMenuItem.Name = "loadImageMenuItem";
            this.loadImageMenuItem.Size = new System.Drawing.Size(230, 26);
            this.loadImageMenuItem.Text = "Load Image...";
            this.loadImageMenuItem.Click += new System.EventHandler(this.loadImageMenuItem_Click);
            // 
            // saveImageMenuItem
            // 
            this.saveImageMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.saveImageMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveImageMenuItem.Name = "saveImageMenuItem";
            this.saveImageMenuItem.Size = new System.Drawing.Size(230, 26);
            this.saveImageMenuItem.Text = "Save Image...";
            this.saveImageMenuItem.Click += new System.EventHandler(this.saveImageMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hmiCustomViewMenuItem});
            this.editMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(51, 25);
            this.editMenuItem.Text = "Edit";
            // 
            // hmiCustomViewMenuItem
            // 
            this.hmiCustomViewMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.hmiCustomViewMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.hmiCustomViewMenuItem.Name = "hmiCustomViewMenuItem";
            this.hmiCustomViewMenuItem.Size = new System.Drawing.Size(264, 26);
            this.hmiCustomViewMenuItem.Text = "Set HMI Custom View...";
            this.hmiCustomViewMenuItem.Click += new System.EventHandler(this.hmiCustomViewMenuItem_Click);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openHMIMenuItem,
            this.showCustomViewToolStripMenuItem,
            this.showSpreadsheetToolStripMenuItem});
            this.viewMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(60, 25);
            this.viewMenuItem.Text = "View";
            // 
            // openHMIMenuItem
            // 
            this.openHMIMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.openHMIMenuItem.ForeColor = System.Drawing.Color.White;
            this.openHMIMenuItem.Name = "openHMIMenuItem";
            this.openHMIMenuItem.Size = new System.Drawing.Size(231, 26);
            this.openHMIMenuItem.Text = "Open HMI...";
            this.openHMIMenuItem.Click += new System.EventHandler(this.openHMIMenuItem_Click);
            // 
            // showCustomViewToolStripMenuItem
            // 
            this.showCustomViewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.showCustomViewToolStripMenuItem.Checked = true;
            this.showCustomViewToolStripMenuItem.CheckOnClick = true;
            this.showCustomViewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showCustomViewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showCustomViewToolStripMenuItem.Name = "showCustomViewToolStripMenuItem";
            this.showCustomViewToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.showCustomViewToolStripMenuItem.Text = "Show Custom View";
            this.showCustomViewToolStripMenuItem.Click += new System.EventHandler(this.showCustomViewToolStripMenuItem_Click);
            // 
            // showSpreadsheetToolStripMenuItem
            // 
            this.showSpreadsheetToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.showSpreadsheetToolStripMenuItem.CheckOnClick = true;
            this.showSpreadsheetToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showSpreadsheetToolStripMenuItem.Name = "showSpreadsheetToolStripMenuItem";
            this.showSpreadsheetToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.showSpreadsheetToolStripMenuItem.Text = "Show Spreadsheet";
            this.showSpreadsheetToolStripMenuItem.Click += new System.EventHandler(this.showSpreadsheetToolStripMenuItem_Click);
            // 
            // imageMenuItem
            // 
            this.imageMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.triggerMenuItem});
            this.imageMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.imageMenuItem.Name = "imageMenuItem";
            this.imageMenuItem.Size = new System.Drawing.Size(68, 25);
            this.imageMenuItem.Text = "Image";
            // 
            // triggerMenuItem
            // 
            this.triggerMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.triggerMenuItem.ForeColor = System.Drawing.Color.White;
            this.triggerMenuItem.Name = "triggerMenuItem";
            this.triggerMenuItem.Size = new System.Drawing.Size(142, 26);
            this.triggerMenuItem.Text = "Trigger";
            this.triggerMenuItem.Click += new System.EventHandler(this.triggerMenuItem_Click);
            // 
            // sensorMenuItem
            // 
            this.sensorMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineMenuItem,
            this.liveModeMenuItem,
            this.saveQueuedImagesToolStripMenuItem});
            this.sensorMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.sensorMenuItem.Name = "sensorMenuItem";
            this.sensorMenuItem.Size = new System.Drawing.Size(72, 25);
            this.sensorMenuItem.Text = "Sensor";
            // 
            // onlineMenuItem
            // 
            this.onlineMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.onlineMenuItem.ForeColor = System.Drawing.Color.White;
            this.onlineMenuItem.Name = "onlineMenuItem";
            this.onlineMenuItem.Size = new System.Drawing.Size(283, 26);
            this.onlineMenuItem.Text = "Online";
            this.onlineMenuItem.Click += new System.EventHandler(this.onlineMenuItem_Click);
            // 
            // liveModeMenuItem
            // 
            this.liveModeMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.liveModeMenuItem.ForeColor = System.Drawing.Color.White;
            this.liveModeMenuItem.Name = "liveModeMenuItem";
            this.liveModeMenuItem.Size = new System.Drawing.Size(283, 26);
            this.liveModeMenuItem.Text = "Live Mode";
            this.liveModeMenuItem.Click += new System.EventHandler(this.liveModeToolStripMenuItem_Click);
            // 
            // saveQueuedImagesToolStripMenuItem
            // 
            this.saveQueuedImagesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.saveQueuedImagesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveQueuedImagesToolStripMenuItem.Name = "saveQueuedImagesToolStripMenuItem";
            this.saveQueuedImagesToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.saveQueuedImagesToolStripMenuItem.Text = "Get Queued Image URLs...";
            this.saveQueuedImagesToolStripMenuItem.Click += new System.EventHandler(this.getQueuedImageURLsToolStripMenuItem_Click);
            // 
            // systemMenuItem
            // 
            this.systemMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hmiSettingsMenuItem});
            this.systemMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.systemMenuItem.Name = "systemMenuItem";
            this.systemMenuItem.Size = new System.Drawing.Size(76, 25);
            this.systemMenuItem.Text = "System";
            // 
            // hmiSettingsMenuItem
            // 
            this.hmiSettingsMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.hmiSettingsMenuItem.ForeColor = System.Drawing.Color.White;
            this.hmiSettingsMenuItem.Name = "hmiSettingsMenuItem";
            this.hmiSettingsMenuItem.Size = new System.Drawing.Size(200, 26);
            this.hmiSettingsMenuItem.Text = "HMI Settings...";
            this.hmiSettingsMenuItem.Click += new System.EventHandler(this.hmiSettingsMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(57, 25);
            this.helpMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.aboutMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(208, 26);
            this.aboutMenuItem.Text = "About camera...";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // shwMenuBar
            // 
            this.shwMenuBar.AutoSize = true;
            this.shwMenuBar.Location = new System.Drawing.Point(565, 43);
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
            this.imgsFolderbtn.Location = new System.Drawing.Point(386, 84);
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
            this.chkAutoConnect.Location = new System.Drawing.Point(644, 91);
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
            this.lblJobInfo.Location = new System.Drawing.Point(1117, 99);
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
            this.dgwImageResults.Size = new System.Drawing.Size(853, 904);
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
            this.cvsDisplay.Size = new System.Drawing.Size(1046, 904);
            this.cvsDisplay.TabIndex = 19;
            // 
            // cvsSpreadsheet
            // 
            this.cvsSpreadsheet.AllowDrop = true;
            this.cvsSpreadsheet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cvsSpreadsheet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cvsSpreadsheet.Location = new System.Drawing.Point(4, 133);
            this.cvsSpreadsheet.Margin = new System.Windows.Forms.Padding(0);
            this.cvsSpreadsheet.Name = "cvsSpreadsheet";
            this.cvsSpreadsheet.Size = new System.Drawing.Size(846, 781);
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
            this.splitContainer1.Size = new System.Drawing.Size(1901, 904);
            this.splitContainer1.SplitterDistance = 1046;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.controlBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1909, 30);
            this.panel1.TabIndex = 35;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 30);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.CausesValidation = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::WebAPISampleApp.Properties.Resources.Cognex_InSightViDiPC_1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 37);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "In-Sight Vision Suite Validation Tool";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // controlBox
            // 
            this.controlBox.Controls.Add(this.btnClose);
            this.controlBox.Controls.Add(this.btnRestoreMaximize);
            this.controlBox.Controls.Add(this.btnMinimize);
            this.controlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlBox.Location = new System.Drawing.Point(1759, 0);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(150, 30);
            this.controlBox.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::WebAPISampleApp.Properties.Resources.icons8_close_24;
            this.btnClose.Location = new System.Drawing.Point(100, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRestoreMaximize
            // 
            this.btnRestoreMaximize.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRestoreMaximize.FlatAppearance.BorderSize = 0;
            this.btnRestoreMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreMaximize.Image = global::WebAPISampleApp.Properties.Resources.icons8_restore_down_28;
            this.btnRestoreMaximize.Location = new System.Drawing.Point(50, 0);
            this.btnRestoreMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btnRestoreMaximize.Name = "btnRestoreMaximize";
            this.btnRestoreMaximize.Size = new System.Drawing.Size(50, 30);
            this.btnRestoreMaximize.TabIndex = 1;
            this.btnRestoreMaximize.UseVisualStyleBackColor = true;
            this.btnRestoreMaximize.Click += new System.EventHandler(this.btnRestoreMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::WebAPISampleApp.Properties.Resources.icons8_horizontal_line_24;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.Location = new System.Drawing.Point(0, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 30);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1909, 966);
            this.tabControl1.TabIndex = 36;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.insightValidationControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1901, 933);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.insightValidationControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1901, 933);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // insightValidationControl1
            // 
            this.insightValidationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insightValidationControl1.Location = new System.Drawing.Point(3, 3);
            this.insightValidationControl1.Name = "insightValidationControl1";
            this.insightValidationControl1.Size = new System.Drawing.Size(1895, 927);
            this.insightValidationControl1.TabIndex = 0;
            // 
            // insightValidationControl2
            // 
            this.insightValidationControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insightValidationControl2.Location = new System.Drawing.Point(3, 3);
            this.insightValidationControl2.Name = "insightValidationControl2";
            this.insightValidationControl2.Size = new System.Drawing.Size(1895, 927);
            this.insightValidationControl2.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1909, 1033);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.controlBox.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        private void Panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            throw new System.NotImplementedException();
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
        private System.Windows.Forms.CheckBox chkAutoConnect;
        private System.Windows.Forms.Label lblJobInfo;
        private System.Windows.Forms.DataGridView dgwImageResults;
        private CvsCustomView cvsCustomView;
        private CvsDisplay cvsDisplay;
        private CvsSpreadsheet cvsSpreadsheet;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel controlBox;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRestoreMaximize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private WebAPISampleApp.InsightValidationControl insightValidationControl1;
        private WebAPISampleApp.InsightValidationControl insightValidationControl2;
    }
}

