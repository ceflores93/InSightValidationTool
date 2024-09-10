using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            OnSelectTabClick(sender, e);    
        }

        protected virtual void  button1_Click(object sender, EventArgs e)
        {
            OnCloseTabClick(sender, e);     
        }

        public void UpdateSelectorColor(string status) { 
            attachedTabStatus = status; 
            modifyBackColor();
        }

        public void UpdateConnectionName(string ConnectionName) { 
        
            modifyConnectionName(ConnectionName);   
        }

        void modifyConnectionName(string ConnectionName) { 
        
            lblConnectionName.Text = ConnectionName;    
        }
        void modifyBackColor() { 
            string result = attachedTabStatus;

            Color backgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));

            if (result == "Pass")
            {
                backgroundColor = Color.Green;
            }
            else if (result == "neutral")
            {
                backgroundColor = Color.Yellow;
            }
            else if (result == "Fail" && isBlinking)
            {
                backgroundColor = Color.Red; // Blinking red
            }

            btnCloseTab.BackColor = backgroundColor;    
            lblConnectionName.BackColor = backgroundColor;  
        }
    }
}
