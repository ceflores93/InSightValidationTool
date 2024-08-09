namespace WebAPISampleApp
{
    partial class InsightValidationControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tblCameraControls = new System.Windows.Forms.TableLayoutPanel();
            this.tblControlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnConnectDisconnect = new System.Windows.Forms.Button();
            this.imgsFolderbtn = new System.Windows.Forms.Button();
            this.btnRunValidation = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tblinfoBanners = new System.Windows.Forms.TableLayoutPanel();
            this.lblimgsload = new System.Windows.Forms.Label();
            this.lblJobInfo = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValidationResult = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tblConnectionParams = new System.Windows.Forms.TableLayoutPanel();
            this.chkAutoConnect = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIpAddressWithPort = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNativeStatus = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cvsCustomView1 = new Cognex.InSight.Web.Controls.CvsCustomView();
            this.cvsDisplay1 = new Cognex.InSight.Web.Controls.CvsDisplay();
            this.dgwImageResults = new System.Windows.Forms.DataGridView();
            this.cvsSpreadsheet1 = new Cognex.InSight.Web.Controls.CvsSpreadsheet();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tblCameraControls.SuspendLayout();
            this.tblControlButtons.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tblinfoBanners.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tblConnectionParams.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwImageResults)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tblCameraControls);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1900, 974);
            this.splitContainer1.SplitterDistance = 94;
            this.splitContainer1.TabIndex = 0;
            // 
            // tblCameraControls
            // 
            this.tblCameraControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblCameraControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tblCameraControls.ColumnCount = 4;
            this.tblCameraControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblCameraControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblCameraControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblCameraControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblCameraControls.Controls.Add(this.tblControlButtons, 1, 0);
            this.tblCameraControls.Controls.Add(this.panel2, 2, 0);
            this.tblCameraControls.Controls.Add(this.panel4, 0, 0);
            this.tblCameraControls.Controls.Add(this.tableLayoutPanel1, 3, 0);
            this.tblCameraControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCameraControls.ForeColor = System.Drawing.Color.White;
            this.tblCameraControls.Location = new System.Drawing.Point(0, 0);
            this.tblCameraControls.Margin = new System.Windows.Forms.Padding(0);
            this.tblCameraControls.Name = "tblCameraControls";
            this.tblCameraControls.RowCount = 1;
            this.tblCameraControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblCameraControls.Size = new System.Drawing.Size(1900, 94);
            this.tblCameraControls.TabIndex = 45;
            // 
            // tblControlButtons
            // 
            this.tblControlButtons.ColumnCount = 3;
            this.tblControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblControlButtons.Controls.Add(this.btnConnectDisconnect, 0, 0);
            this.tblControlButtons.Controls.Add(this.imgsFolderbtn, 1, 0);
            this.tblControlButtons.Controls.Add(this.btnRunValidation, 2, 0);
            this.tblControlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblControlButtons.Location = new System.Drawing.Point(573, 3);
            this.tblControlButtons.Name = "tblControlButtons";
            this.tblControlButtons.RowCount = 1;
            this.tblControlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblControlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblControlButtons.Size = new System.Drawing.Size(564, 100);
            this.tblControlButtons.TabIndex = 0;
            // 
            // btnConnectDisconnect
            // 
            this.btnConnectDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnConnectDisconnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConnectDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnConnectDisconnect.FlatAppearance.BorderSize = 3;
            this.btnConnectDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectDisconnect.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectDisconnect.ForeColor = System.Drawing.Color.White;
            this.btnConnectDisconnect.Image = global::WebAPISampleApp.Properties.Resources.connecticon1;
            this.btnConnectDisconnect.Location = new System.Drawing.Point(2, 2);
            this.btnConnectDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnectDisconnect.Name = "btnConnectDisconnect";
            this.btnConnectDisconnect.Size = new System.Drawing.Size(193, 70);
            this.btnConnectDisconnect.TabIndex = 5;
            this.btnConnectDisconnect.Text = "Connect";
            this.btnConnectDisconnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConnectDisconnect.UseVisualStyleBackColor = false;
            this.btnConnectDisconnect.Click += new System.EventHandler(this.btnConnectDisconnect_Click);
            // 
            // imgsFolderbtn
            // 
            this.imgsFolderbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.imgsFolderbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgsFolderbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.imgsFolderbtn.FlatAppearance.BorderSize = 3;
            this.imgsFolderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgsFolderbtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgsFolderbtn.ForeColor = System.Drawing.Color.White;
            this.imgsFolderbtn.Image = global::WebAPISampleApp.Properties.Resources.folder;
            this.imgsFolderbtn.Location = new System.Drawing.Point(199, 2);
            this.imgsFolderbtn.Margin = new System.Windows.Forms.Padding(2);
            this.imgsFolderbtn.Name = "imgsFolderbtn";
            this.imgsFolderbtn.Size = new System.Drawing.Size(165, 58);
            this.imgsFolderbtn.TabIndex = 6;
            this.imgsFolderbtn.Text = "Load Images";
            this.imgsFolderbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.imgsFolderbtn.UseVisualStyleBackColor = false;
            this.imgsFolderbtn.Click += new System.EventHandler(this.imgsFolderbtn_Click);
            // 
            // btnRunValidation
            // 
            this.btnRunValidation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRunValidation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRunValidation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRunValidation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnRunValidation.FlatAppearance.BorderSize = 3;
            this.btnRunValidation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunValidation.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunValidation.ForeColor = System.Drawing.Color.White;
            this.btnRunValidation.Image = global::WebAPISampleApp.Properties.Resources.icons8_check_mark_28green;
            this.btnRunValidation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunValidation.Location = new System.Drawing.Point(368, 2);
            this.btnRunValidation.Margin = new System.Windows.Forms.Padding(2);
            this.btnRunValidation.Name = "btnRunValidation";
            this.btnRunValidation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRunValidation.Size = new System.Drawing.Size(194, 70);
            this.btnRunValidation.TabIndex = 7;
            this.btnRunValidation.Text = "Run Validation";
            this.btnRunValidation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRunValidation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRunValidation.UseVisualStyleBackColor = false;
            this.btnRunValidation.Click += new System.EventHandler(this.btnRunValidation_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tblinfoBanners);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1143, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 100);
            this.panel2.TabIndex = 1;
            // 
            // tblinfoBanners
            // 
            this.tblinfoBanners.ColumnCount = 1;
            this.tblinfoBanners.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblinfoBanners.Controls.Add(this.lblimgsload, 0, 0);
            this.tblinfoBanners.Controls.Add(this.lblJobInfo, 0, 1);
            this.tblinfoBanners.Controls.Add(this.panel5, 0, 2);
            this.tblinfoBanners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblinfoBanners.Location = new System.Drawing.Point(0, 0);
            this.tblinfoBanners.Name = "tblinfoBanners";
            this.tblinfoBanners.RowCount = 3;
            this.tblinfoBanners.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblinfoBanners.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblinfoBanners.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblinfoBanners.Size = new System.Drawing.Size(564, 100);
            this.tblinfoBanners.TabIndex = 0;
            // 
            // lblimgsload
            // 
            this.lblimgsload.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblimgsload.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimgsload.ForeColor = System.Drawing.Color.White;
            this.lblimgsload.Location = new System.Drawing.Point(2, 0);
            this.lblimgsload.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblimgsload.Name = "lblimgsload";
            this.lblimgsload.Size = new System.Drawing.Size(560, 25);
            this.lblimgsload.TabIndex = 39;
            this.lblimgsload.Text = "Images Loaded:";
            this.lblimgsload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblJobInfo
            // 
            this.lblJobInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblJobInfo.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobInfo.ForeColor = System.Drawing.Color.White;
            this.lblJobInfo.Location = new System.Drawing.Point(2, 25);
            this.lblJobInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJobInfo.Name = "lblJobInfo";
            this.lblJobInfo.Size = new System.Drawing.Size(560, 25);
            this.lblJobInfo.TabIndex = 40;
            this.lblJobInfo.Text = "Current Job:";
            this.lblJobInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.splitContainer3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(558, 44);
            this.panel5.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.lblValidationResult);
            this.splitContainer3.Size = new System.Drawing.Size(558, 44);
            this.splitContainer3.SplitterDistance = 279;
            this.splitContainer3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 38);
            this.label4.TabIndex = 41;
            this.label4.Text = "Validation Result";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblValidationResult
            // 
            this.lblValidationResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblValidationResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValidationResult.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidationResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblValidationResult.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblValidationResult.Location = new System.Drawing.Point(0, 0);
            this.lblValidationResult.Margin = new System.Windows.Forms.Padding(0);
            this.lblValidationResult.Name = "lblValidationResult";
            this.lblValidationResult.Size = new System.Drawing.Size(275, 34);
            this.lblValidationResult.TabIndex = 42;
            this.lblValidationResult.Text = "None";
            this.lblValidationResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tblConnectionParams);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(564, 100);
            this.panel4.TabIndex = 3;
            // 
            // tblConnectionParams
            // 
            this.tblConnectionParams.ColumnCount = 4;
            this.tblConnectionParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblConnectionParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnectionParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblConnectionParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnectionParams.Controls.Add(this.chkAutoConnect, 3, 0);
            this.tblConnectionParams.Controls.Add(this.panel6, 0, 0);
            this.tblConnectionParams.Controls.Add(this.panel7, 1, 0);
            this.tblConnectionParams.Controls.Add(this.panel8, 2, 0);
            this.tblConnectionParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblConnectionParams.Location = new System.Drawing.Point(0, 0);
            this.tblConnectionParams.Name = "tblConnectionParams";
            this.tblConnectionParams.RowCount = 1;
            this.tblConnectionParams.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblConnectionParams.Size = new System.Drawing.Size(564, 100);
            this.tblConnectionParams.TabIndex = 0;
            // 
            // chkAutoConnect
            // 
            this.chkAutoConnect.AutoSize = true;
            this.chkAutoConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAutoConnect.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.chkAutoConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAutoConnect.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoConnect.Location = new System.Drawing.Point(453, 3);
            this.chkAutoConnect.Name = "chkAutoConnect";
            this.chkAutoConnect.Size = new System.Drawing.Size(108, 100);
            this.chkAutoConnect.TabIndex = 32;
            this.chkAutoConnect.Text = "Auto Connect";
            this.chkAutoConnect.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.tbIpAddressWithPort);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(163, 100);
            this.panel6.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 57);
            this.label3.TabIndex = 33;
            this.label3.Text = "Address and port";
            // 
            // tbIpAddressWithPort
            // 
            this.tbIpAddressWithPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIpAddressWithPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tbIpAddressWithPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIpAddressWithPort.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIpAddressWithPort.ForeColor = System.Drawing.Color.White;
            this.tbIpAddressWithPort.Location = new System.Drawing.Point(5, 59);
            this.tbIpAddressWithPort.Margin = new System.Windows.Forms.Padding(2);
            this.tbIpAddressWithPort.Name = "tbIpAddressWithPort";
            this.tbIpAddressWithPort.Size = new System.Drawing.Size(156, 25);
            this.tbIpAddressWithPort.TabIndex = 34;
            this.tbIpAddressWithPort.Text = "192.168.1.5:80";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.tbUsername);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(172, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(106, 100);
            this.panel7.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 53);
            this.label1.TabIndex = 36;
            this.label1.Text = "User";
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.White;
            this.tbUsername.Location = new System.Drawing.Point(3, 59);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(104, 25);
            this.tbUsername.TabIndex = 35;
            this.tbUsername.Text = "admin";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tbPassword);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(284, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(163, 100);
            this.panel8.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(5, 59);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(156, 25);
            this.tbPassword.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 57);
            this.label2.TabIndex = 37;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblNativeStatus, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblState, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1713, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(184, 88);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblNativeStatus
            // 
            this.lblNativeStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNativeStatus.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNativeStatus.ForeColor = System.Drawing.Color.White;
            this.lblNativeStatus.Location = new System.Drawing.Point(2, 29);
            this.lblNativeStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNativeStatus.Name = "lblNativeStatus";
            this.lblNativeStatus.Size = new System.Drawing.Size(180, 29);
            this.lblNativeStatus.TabIndex = 46;
            this.lblNativeStatus.Text = "Native Not Connected";
            this.lblNativeStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblState.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(0, 58);
            this.lblState.Margin = new System.Windows.Forms.Padding(0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(184, 30);
            this.lblState.TabIndex = 45;
            this.lblState.Text = "Not Connected";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.cvsCustomView1);
            this.splitContainer2.Panel1.Controls.Add(this.cvsDisplay1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgwImageResults);
            this.splitContainer2.Panel2.Controls.Add(this.cvsSpreadsheet1);
            this.splitContainer2.Size = new System.Drawing.Size(1900, 876);
            this.splitContainer2.SplitterDistance = 950;
            this.splitContainer2.TabIndex = 0;
            // 
            // cvsCustomView1
            // 
            this.cvsCustomView1.AllowDrop = true;
            this.cvsCustomView1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cvsCustomView1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cvsCustomView1.Location = new System.Drawing.Point(0, 13);
            this.cvsCustomView1.Margin = new System.Windows.Forms.Padding(0);
            this.cvsCustomView1.Name = "cvsCustomView1";
            this.cvsCustomView1.Size = new System.Drawing.Size(200, 199);
            this.cvsCustomView1.TabIndex = 1;
            // 
            // cvsDisplay1
            // 
            this.cvsDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cvsDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cvsDisplay1.Location = new System.Drawing.Point(0, 0);
            this.cvsDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.cvsDisplay1.Name = "cvsDisplay1";
            this.cvsDisplay1.Size = new System.Drawing.Size(950, 876);
            this.cvsDisplay1.TabIndex = 0;
            // 
            // dgwImageResults
            // 
            this.dgwImageResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwImageResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.dgwImageResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwImageResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwImageResults.Location = new System.Drawing.Point(0, 0);
            this.dgwImageResults.Margin = new System.Windows.Forms.Padding(4);
            this.dgwImageResults.Name = "dgwImageResults";
            this.dgwImageResults.RowHeadersWidth = 51;
            this.dgwImageResults.RowTemplate.Height = 24;
            this.dgwImageResults.Size = new System.Drawing.Size(946, 876);
            this.dgwImageResults.TabIndex = 34;
            // 
            // cvsSpreadsheet1
            // 
            this.cvsSpreadsheet1.AllowDrop = true;
            this.cvsSpreadsheet1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cvsSpreadsheet1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cvsSpreadsheet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cvsSpreadsheet1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvsSpreadsheet1.Location = new System.Drawing.Point(0, 0);
            this.cvsSpreadsheet1.Margin = new System.Windows.Forms.Padding(0);
            this.cvsSpreadsheet1.Name = "cvsSpreadsheet1";
            this.cvsSpreadsheet1.Size = new System.Drawing.Size(946, 876);
            this.cvsSpreadsheet1.TabIndex = 35;
            // 
            // InsightValidationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "InsightValidationControl";
            this.Size = new System.Drawing.Size(1900, 974);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tblCameraControls.ResumeLayout(false);
            this.tblControlButtons.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tblinfoBanners.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tblConnectionParams.ResumeLayout(false);
            this.tblConnectionParams.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwImageResults)).EndInit();
            this.ResumeLayout(false);

        }







        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Cognex.InSight.Web.Controls.CvsDisplay cvsDisplay1;
        public Cognex.InSight.Web.Controls.CvsCustomView cvsCustomView1;
        public Cognex.InSight.Web.Controls.CvsSpreadsheet cvsSpreadsheet1;
        public System.Windows.Forms.DataGridView dgwImageResults;
        private System.Windows.Forms.Button btnConnectDisconnect;
        private System.Windows.Forms.Button imgsFolderbtn;
        private System.Windows.Forms.Button btnRunValidation;
        public System.Windows.Forms.CheckBox chkAutoConnect;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbIpAddressWithPort;
        public System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblimgsload;
        public System.Windows.Forms.Label lblJobInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblValidationResult;
        private System.Windows.Forms.TableLayoutPanel tblCameraControls;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tblinfoBanners;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TableLayoutPanel tblControlButtons;
        private System.Windows.Forms.TableLayoutPanel tblConnectionParams;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNativeStatus;
    }
}
