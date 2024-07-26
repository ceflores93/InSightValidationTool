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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblValidationResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblJobInfo = new System.Windows.Forms.Label();
            this.lblimgsload = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbIpAddressWithPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAutoConnect = new System.Windows.Forms.CheckBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cvsCustomView1 = new Cognex.InSight.Web.Controls.CvsCustomView();
            this.cvsDisplay1 = new Cognex.InSight.Web.Controls.CvsDisplay();
            this.cvsSpreadsheet1 = new Cognex.InSight.Web.Controls.CvsSpreadsheet();
            this.dgwImageResults = new System.Windows.Forms.DataGridView();
            this.lblState = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRunValidation = new System.Windows.Forms.Button();
            this.imgsFolderbtn = new System.Windows.Forms.Button();
            this.btnConnectDisconnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1600, 800);
            this.splitContainer1.SplitterDistance = 97;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblState);
            this.groupBox1.Controls.Add(this.lblValidationResult);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblJobInfo);
            this.groupBox1.Controls.Add(this.lblimgsload);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Controls.Add(this.tbIpAddressWithPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkAutoConnect);
            this.groupBox1.Controls.Add(this.btnRunValidation);
            this.groupBox1.Controls.Add(this.imgsFolderbtn);
            this.groupBox1.Controls.Add(this.btnConnectDisconnect);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1600, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Parameters";
            // 
            // lblValidationResult
            // 
            this.lblValidationResult.AutoSize = true;
            this.lblValidationResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValidationResult.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidationResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblValidationResult.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblValidationResult.Location = new System.Drawing.Point(1157, 66);
            this.lblValidationResult.Margin = new System.Windows.Forms.Padding(0);
            this.lblValidationResult.Name = "lblValidationResult";
            this.lblValidationResult.Size = new System.Drawing.Size(63, 28);
            this.lblValidationResult.TabIndex = 42;
            this.lblValidationResult.Text = "None";
            this.lblValidationResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(982, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 28);
            this.label4.TabIndex = 41;
            this.label4.Text = "Validation Result";
            // 
            // lblJobInfo
            // 
            this.lblJobInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJobInfo.AutoSize = true;
            this.lblJobInfo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobInfo.ForeColor = System.Drawing.Color.White;
            this.lblJobInfo.Location = new System.Drawing.Point(982, 47);
            this.lblJobInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJobInfo.Name = "lblJobInfo";
            this.lblJobInfo.Size = new System.Drawing.Size(97, 21);
            this.lblJobInfo.TabIndex = 40;
            this.lblJobInfo.Text = "Current Job:";
            this.lblJobInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblimgsload
            // 
            this.lblimgsload.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblimgsload.AutoSize = true;
            this.lblimgsload.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimgsload.ForeColor = System.Drawing.Color.White;
            this.lblimgsload.Location = new System.Drawing.Point(982, 23);
            this.lblimgsload.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblimgsload.Name = "lblimgsload";
            this.lblimgsload.Size = new System.Drawing.Size(121, 21);
            this.lblimgsload.TabIndex = 39;
            this.lblimgsload.Text = "Images Loaded:";
            this.lblimgsload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tbPassword.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(258, 55);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(124, 23);
            this.tbPassword.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "User";
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tbUsername.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.White;
            this.tbUsername.Location = new System.Drawing.Point(154, 52);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(82, 28);
            this.tbUsername.TabIndex = 35;
            this.tbUsername.Text = "admin";
            // 
            // tbIpAddressWithPort
            // 
            this.tbIpAddressWithPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tbIpAddressWithPort.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIpAddressWithPort.ForeColor = System.Drawing.Color.White;
            this.tbIpAddressWithPort.Location = new System.Drawing.Point(9, 52);
            this.tbIpAddressWithPort.Margin = new System.Windows.Forms.Padding(2);
            this.tbIpAddressWithPort.Name = "tbIpAddressWithPort";
            this.tbIpAddressWithPort.Size = new System.Drawing.Size(132, 28);
            this.tbIpAddressWithPort.TabIndex = 34;
            this.tbIpAddressWithPort.Text = "127.0.0.1:80";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "Address and port";
            // 
            // chkAutoConnect
            // 
            this.chkAutoConnect.AutoSize = true;
            this.chkAutoConnect.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.chkAutoConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAutoConnect.Location = new System.Drawing.Point(387, 52);
            this.chkAutoConnect.Name = "chkAutoConnect";
            this.chkAutoConnect.Size = new System.Drawing.Size(69, 28);
            this.chkAutoConnect.TabIndex = 32;
            this.chkAutoConnect.Text = "Auto";
            this.chkAutoConnect.UseVisualStyleBackColor = true;
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
            this.splitContainer2.Panel2.Controls.Add(this.cvsSpreadsheet1);
            this.splitContainer2.Panel2.Controls.Add(this.dgwImageResults);
            this.splitContainer2.Size = new System.Drawing.Size(1600, 699);
            this.splitContainer2.SplitterDistance = 800;
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
            this.cvsDisplay1.Size = new System.Drawing.Size(800, 699);
            this.cvsDisplay1.TabIndex = 0;
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
            this.cvsSpreadsheet1.Size = new System.Drawing.Size(796, 699);
            this.cvsSpreadsheet1.TabIndex = 35;
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
            this.dgwImageResults.Size = new System.Drawing.Size(796, 699);
            this.dgwImageResults.TabIndex = 34;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(1459, 66);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(136, 24);
            this.lblState.TabIndex = 43;
            this.lblState.Text = "Not Connected";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1429, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 24);
            this.label5.TabIndex = 44;
            this.label5.Text = "PLC Not Connected";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRunValidation
            // 
            this.btnRunValidation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRunValidation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnRunValidation.FlatAppearance.BorderSize = 3;
            this.btnRunValidation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunValidation.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunValidation.ForeColor = System.Drawing.Color.White;
            this.btnRunValidation.Image = global::WebAPISampleApp.Properties.Resources.icons8_check_mark_28green;
            this.btnRunValidation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunValidation.Location = new System.Drawing.Point(813, 23);
            this.btnRunValidation.Margin = new System.Windows.Forms.Padding(2);
            this.btnRunValidation.Name = "btnRunValidation";
            this.btnRunValidation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRunValidation.Size = new System.Drawing.Size(165, 61);
            this.btnRunValidation.TabIndex = 7;
            this.btnRunValidation.Text = "Run Validation";
            this.btnRunValidation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRunValidation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRunValidation.UseVisualStyleBackColor = false;
            // 
            // imgsFolderbtn
            // 
            this.imgsFolderbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.imgsFolderbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.imgsFolderbtn.FlatAppearance.BorderSize = 3;
            this.imgsFolderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgsFolderbtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgsFolderbtn.ForeColor = System.Drawing.Color.White;
            this.imgsFolderbtn.Image = global::WebAPISampleApp.Properties.Resources.folder;
            this.imgsFolderbtn.Location = new System.Drawing.Point(632, 29);
            this.imgsFolderbtn.Margin = new System.Windows.Forms.Padding(2);
            this.imgsFolderbtn.Name = "imgsFolderbtn";
            this.imgsFolderbtn.Size = new System.Drawing.Size(152, 53);
            this.imgsFolderbtn.TabIndex = 6;
            this.imgsFolderbtn.Text = "Load Images";
            this.imgsFolderbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imgsFolderbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.imgsFolderbtn.UseVisualStyleBackColor = false;
            // 
            // btnConnectDisconnect
            // 
            this.btnConnectDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnConnectDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnConnectDisconnect.FlatAppearance.BorderSize = 3;
            this.btnConnectDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectDisconnect.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectDisconnect.ForeColor = System.Drawing.Color.White;
            this.btnConnectDisconnect.Image = global::WebAPISampleApp.Properties.Resources.connecticon1;
            this.btnConnectDisconnect.Location = new System.Drawing.Point(465, 22);
            this.btnConnectDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnectDisconnect.Name = "btnConnectDisconnect";
            this.btnConnectDisconnect.Size = new System.Drawing.Size(163, 61);
            this.btnConnectDisconnect.TabIndex = 5;
            this.btnConnectDisconnect.Text = "Connect";
            this.btnConnectDisconnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConnectDisconnect.UseVisualStyleBackColor = false;
            // 
            // InsightValidationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "InsightValidationControl";
            this.Size = new System.Drawing.Size(1600, 800);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private Cognex.InSight.Web.Controls.CvsCustomView cvsCustomView1;
        private Cognex.InSight.Web.Controls.CvsSpreadsheet cvsSpreadsheet1;
        private System.Windows.Forms.DataGridView dgwImageResults;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnectDisconnect;
        private System.Windows.Forms.Button imgsFolderbtn;
        private System.Windows.Forms.Button btnRunValidation;
        private System.Windows.Forms.CheckBox chkAutoConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIpAddressWithPort;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblimgsload;
        private System.Windows.Forms.Label lblJobInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblValidationResult;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label label5;
    }
}
