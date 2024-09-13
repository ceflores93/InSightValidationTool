using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebAPISampleApp.Properties;

namespace WebAPISampleApp
{
    public partial class CustomTabSelector : UserControl
    {

        public int attachedTabIndex {  get; set; }  
        public string attachedTabStatus {  get; set; }  

        public delegate void CustomTabSelectorEventHandler(object sender, EventArgs e);

        public event CustomTabSelectorEventHandler OnSelectTabClick;
        public event CustomTabSelectorEventHandler OnCloseTabClick;

        private bool isBlinking = false;
        private Timer TabBlinker;
        public CustomTabSelector()
        {
            InitializeComponent();

            TabBlinker = new Timer { Interval = 500 };
            TabBlinker.Tick += TabBlinker_Tick;
            TabBlinker.Start();
        }

        private void TabBlinker_Tick(object sender, EventArgs e)
        {
            isBlinking = !isBlinking;
            modifyBackColor();
        }


        protected virtual void lblConnectionName_Click(object sender, EventArgs e)
        {
            OnSelectTabClick(this, e);    
        }

        protected virtual void  button1_Click(object sender, EventArgs e)
        {
            OnCloseTabClick(this, e);     
        }

        public void UpdateSelectorColor(string status) { 
            attachedTabStatus = status; 
            modifyBackColor();
        }

        public void UpdateConnectionName(string ConnectionName) { 
        
            modifyConnectionName(ConnectionName);   
        }

        public void modifyConnectionName(string ConnectionName) { 
           
            lblConnectionName.Text = ConnectionName;    
        }
        void modifyBackColor() { 
            string result = attachedTabStatus;

            Color backgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));

            if (result == "Pass")
            {
                lblConnectionName.ForeColor = Color.White;
                backgroundColor = Color.Green;
                btnCloseTab.Image = Resources.icons8_close_24;
            }
            else if (result == "neutral")
            {
                backgroundColor = Color.Yellow;
                lblConnectionName.ForeColor = Color.Black;   
                btnCloseTab.Image = Resources.icons8_close_24black;
            }
            else if (result == "Fail" && isBlinking)
            {
                backgroundColor = Color.Red; // Blinking red
                lblConnectionName.ForeColor = Color.White;
                btnCloseTab.Image = Resources.icons8_close_24;
            }

            this.BackColor = backgroundColor;   
          
        }
    }
}
