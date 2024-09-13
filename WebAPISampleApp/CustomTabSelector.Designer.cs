namespace WebAPISampleApp
{
    partial class CustomTabSelector
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
            this.lblConnectionName = new System.Windows.Forms.Label();
            this.btnCloseTab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConnectionName
            // 
            this.lblConnectionName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblConnectionName.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.lblConnectionName.ForeColor = System.Drawing.Color.White;
            this.lblConnectionName.Location = new System.Drawing.Point(3, 0);
            this.lblConnectionName.Name = "lblConnectionName";
            this.lblConnectionName.Size = new System.Drawing.Size(129, 30);
            this.lblConnectionName.TabIndex = 0;
            this.lblConnectionName.Text = "Default Connection";
            this.lblConnectionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblConnectionName.Click += new System.EventHandler(this.lblConnectionName_Click);
            // 
            // btnCloseTab
            // 
            this.btnCloseTab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCloseTab.FlatAppearance.BorderSize = 0;
            this.btnCloseTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTab.Image = global::WebAPISampleApp.Properties.Resources.icons8_close_24;
            this.btnCloseTab.Location = new System.Drawing.Point(138, 0);
            this.btnCloseTab.Name = "btnCloseTab";
            this.btnCloseTab.Size = new System.Drawing.Size(35, 30);
            this.btnCloseTab.TabIndex = 1;
            this.btnCloseTab.UseVisualStyleBackColor = true;
            this.btnCloseTab.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomTabSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.btnCloseTab);
            this.Controls.Add(this.lblConnectionName);
            this.Name = "CustomTabSelector";
            this.Size = new System.Drawing.Size(191, 33);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblConnectionName;
        private System.Windows.Forms.Button btnCloseTab;
    }
}
