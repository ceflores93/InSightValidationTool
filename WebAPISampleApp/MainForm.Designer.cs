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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WebAPISampleApp;

namespace InSightValidationTool
{
  partial class MainFormWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormWindow));
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
            this.saveCameraLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlBox = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRestoreMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.tbllyMainWindow = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTopPanel = new System.Windows.Forms.Panel();
            this.btnWindowTitle = new System.Windows.Forms.Button();
            this.tabCtrlContent = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flwlyTabControlButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddTab = new System.Windows.Forms.Button();
            this.insightValidationControl1 = new WebAPISampleApp.InsightValidationControl();
            this.customTabSelector1 = new WebAPISampleApp.CustomTabSelector();
            this.menuStrip.SuspendLayout();
            this.controlBox.SuspendLayout();
            this.tbllyMainWindow.SuspendLayout();
            this.pnlTopPanel.SuspendLayout();
            this.tabCtrlContent.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flwlyTabControlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMessages
            // 
            this.tbMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessages.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMessages.Location = new System.Drawing.Point(18, 2084);
            this.tbMessages.Margin = new System.Windows.Forms.Padding(2);
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMessages.Size = new System.Drawing.Size(1911, 27);
            this.tbMessages.TabIndex = 0;
            this.tbMessages.WordWrap = false;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.viewMenuItem,
            this.imageMenuItem,
            this.sensorMenuItem,
            this.systemMenuItem,
            this.saveCameraLayoutToolStripMenuItem,
            this.helpMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 34);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(1920, 30);
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
            this.fileMenuItem.Size = new System.Drawing.Size(49, 26);
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
            this.editMenuItem.Size = new System.Drawing.Size(51, 26);
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
            this.viewMenuItem.Size = new System.Drawing.Size(60, 26);
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
            this.imageMenuItem.Size = new System.Drawing.Size(68, 26);
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
            this.sensorMenuItem.Size = new System.Drawing.Size(72, 26);
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
            this.systemMenuItem.Size = new System.Drawing.Size(76, 26);
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
            // saveCameraLayoutToolStripMenuItem
            // 
            this.saveCameraLayoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.saveCameraLayoutToolStripMenuItem.Name = "saveCameraLayoutToolStripMenuItem";
            this.saveCameraLayoutToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.saveCameraLayoutToolStripMenuItem.Text = "Save Layout";
            this.saveCameraLayoutToolStripMenuItem.Click += new System.EventHandler(this.saveCameraLayoutToolStripMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(57, 26);
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
            // controlBox
            // 
            this.controlBox.Controls.Add(this.btnClose);
            this.controlBox.Controls.Add(this.btnRestoreMaximize);
            this.controlBox.Controls.Add(this.btnMinimize);
            this.controlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlBox.Location = new System.Drawing.Point(1764, 0);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(150, 28);
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
            this.btnClose.Size = new System.Drawing.Size(50, 28);
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
            this.btnRestoreMaximize.Size = new System.Drawing.Size(50, 28);
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
            this.btnMinimize.Size = new System.Drawing.Size(50, 28);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // tbllyMainWindow
            // 
            this.tbllyMainWindow.AutoSize = true;
            this.tbllyMainWindow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tbllyMainWindow.ColumnCount = 1;
            this.tbllyMainWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbllyMainWindow.Controls.Add(this.menuStrip, 0, 1);
            this.tbllyMainWindow.Controls.Add(this.pnlTopPanel, 0, 0);
            this.tbllyMainWindow.Controls.Add(this.tabCtrlContent, 0, 3);
            this.tbllyMainWindow.Controls.Add(this.flwlyTabControlButtons, 0, 2);
            this.tbllyMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbllyMainWindow.Location = new System.Drawing.Point(0, 0);
            this.tbllyMainWindow.Margin = new System.Windows.Forms.Padding(0);
            this.tbllyMainWindow.Name = "tbllyMainWindow";
            this.tbllyMainWindow.RowCount = 4;
            this.tbllyMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tbllyMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbllyMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbllyMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbllyMainWindow.Size = new System.Drawing.Size(1920, 1080);
            this.tbllyMainWindow.TabIndex = 26;
            // 
            // pnlTopPanel
            // 
            this.pnlTopPanel.Controls.Add(this.btnWindowTitle);
            this.pnlTopPanel.Controls.Add(this.controlBox);
            this.pnlTopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopPanel.Location = new System.Drawing.Point(3, 3);
            this.pnlTopPanel.Name = "pnlTopPanel";
            this.pnlTopPanel.Size = new System.Drawing.Size(1914, 28);
            this.pnlTopPanel.TabIndex = 1;
            this.pnlTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopPanel_MouseDown);
            this.pnlTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTopPanel_MouseMove);
            this.pnlTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTopPanel_MouseUp);
            // 
            // btnWindowTitle
            // 
            this.btnWindowTitle.CausesValidation = false;
            this.btnWindowTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnWindowTitle.FlatAppearance.BorderSize = 0;
            this.btnWindowTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWindowTitle.ForeColor = System.Drawing.Color.White;
            this.btnWindowTitle.Image = global::WebAPISampleApp.Properties.Resources.Cognex_InSightViDiPC_1;
            this.btnWindowTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWindowTitle.Location = new System.Drawing.Point(0, 0);
            this.btnWindowTitle.Name = "btnWindowTitle";
            this.btnWindowTitle.Size = new System.Drawing.Size(391, 28);
            this.btnWindowTitle.TabIndex = 0;
            this.btnWindowTitle.TabStop = false;
            this.btnWindowTitle.Text = "In-Sight Vision Suite Validation Tool";
            this.btnWindowTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWindowTitle.UseVisualStyleBackColor = true;
            // 
            // tabCtrlContent
            // 
            this.tabCtrlContent.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabCtrlContent.Controls.Add(this.tabPage1);
            this.tabCtrlContent.Controls.Add(this.tabPage2);
            this.tabCtrlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlContent.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabCtrlContent.ItemSize = new System.Drawing.Size(0, 1);
            this.tabCtrlContent.Location = new System.Drawing.Point(3, 114);
            this.tabCtrlContent.Multiline = true;
            this.tabCtrlContent.Name = "tabCtrlContent";
            this.tabCtrlContent.Padding = new System.Drawing.Point(0, 0);
            this.tabCtrlContent.SelectedIndex = 0;
            this.tabCtrlContent.Size = new System.Drawing.Size(1914, 963);
            this.tabCtrlContent.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCtrlContent.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.tabPage1.Controls.Add(this.insightValidationControl1);
            this.tabPage1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1906, 954);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DefaultConnection";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1906, 950);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "+";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flwlyTabControlButtons
            // 
            this.flwlyTabControlButtons.AutoScroll = true;
            this.flwlyTabControlButtons.AutoSize = true;
            this.flwlyTabControlButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tbllyMainWindow.SetColumnSpan(this.flwlyTabControlButtons, 2);
            this.flwlyTabControlButtons.Controls.Add(this.customTabSelector1);
            this.flwlyTabControlButtons.Controls.Add(this.btnAddTab);
            this.flwlyTabControlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwlyTabControlButtons.Location = new System.Drawing.Point(3, 67);
            this.flwlyTabControlButtons.Name = "flwlyTabControlButtons";
            this.flwlyTabControlButtons.Size = new System.Drawing.Size(1914, 41);
            this.flwlyTabControlButtons.TabIndex = 26;
            // 
            // btnAddTab
            // 
            this.btnAddTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAddTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTab.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddTab.ForeColor = System.Drawing.Color.White;
            this.btnAddTab.Image = global::WebAPISampleApp.Properties.Resources.icons8_plus_28;
            this.btnAddTab.Location = new System.Drawing.Point(164, 3);
            this.btnAddTab.Name = "btnAddTab";
            this.btnAddTab.Size = new System.Drawing.Size(30, 30);
            this.btnAddTab.TabIndex = 1;
            this.btnAddTab.UseVisualStyleBackColor = false;
            this.btnAddTab.Click += new System.EventHandler(this.btnAddTab_Click);
            // 
            // insightValidationControl1
            // 
            this.insightValidationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insightValidationControl1.Location = new System.Drawing.Point(3, 3);
            this.insightValidationControl1.Margin = new System.Windows.Forms.Padding(3, 738, 3, 738);
            this.insightValidationControl1.Name = "insightValidationControl1";
            this.insightValidationControl1.Size = new System.Drawing.Size(1900, 948);
            this.insightValidationControl1.TabIndex = 0;
            // 
            // customTabSelector1
            // 
            this.customTabSelector1.attachedTabIndex = 0;
            this.customTabSelector1.attachedTabStatus = null;
            this.customTabSelector1.AutoSize = true;
            this.customTabSelector1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customTabSelector1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.customTabSelector1.Location = new System.Drawing.Point(3, 3);
            this.customTabSelector1.Name = "customTabSelector1";
            this.customTabSelector1.Size = new System.Drawing.Size(155, 35);
            this.customTabSelector1.TabIndex = 2;
            // 
            // MainFormWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.tbMessages);
            this.Controls.Add(this.tbllyMainWindow);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainFormWindow";
            this.Text = "In-Sight Vision Suite Validation Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.controlBox.ResumeLayout(false);
            this.tbllyMainWindow.ResumeLayout(false);
            this.tbllyMainWindow.PerformLayout();
            this.pnlTopPanel.ResumeLayout(false);
            this.tabCtrlContent.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flwlyTabControlButtons.ResumeLayout(false);
            this.flwlyTabControlButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TabCtrlContent_Selecting(object sender, TabControlCancelEventArgs e)
        {
            throw new System.NotImplementedException();
        }








        #endregion
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
        private System.Windows.Forms.ToolStripMenuItem loadValidationFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveValidationFileToolStripMenuItem;
        private System.Windows.Forms.Panel controlBox;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRestoreMaximize;
        private System.Windows.Forms.Button btnWindowTitle;
        private System.Windows.Forms.TableLayoutPanel tbllyMainWindow;
        private System.Windows.Forms.Panel pnlTopPanel;
        private System.Windows.Forms.TabControl tabCtrlContent;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private WebAPISampleApp.InsightValidationControl insightValidationControl1;
        private FlowLayoutPanel flwlyTabControlButtons;
        private ToolStripMenuItem saveCameraLayoutToolStripMenuItem;
        private Button btnAddTab;
        private CustomTabSelector customTabSelector1;
    }
}

