using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Forms;
using TaskManager.Helpers;

namespace TaskManager.UserControls
{
    public partial class MaxRestMinButtons : UserControl
    {
        //event handler
        public event EventHandler ButtonClose;
        public event EventHandler ButtonMinimize;
        public event EventHandler ButtonRestore;
        public event EventHandler ButtonMaximize; 

        public MaxRestMinButtons()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //event up to the parent
            if (this.ButtonClose != null) 
                this.ButtonClose(this, e);       
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            FormHelper.formWinodowState = FormWindowState.Minimized;
            if (this.ButtonMinimize != null)            
                this.ButtonMinimize(this, e);
            
                
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            FormHelper.formWinodowState = FormWindowState.Maximized;
            btnMaximize.Visible = true;
            btnRestore.Visible = false;
            if (this.ButtonRestore != null)
            {
                this.ButtonRestore(this, e);
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            FormHelper.formWinodowState = FormWindowState.Normal;
            btnMaximize.Visible = false;
            btnRestore.Visible = true;
            if (this.ButtonMaximize != null)
            {
                this.ButtonMaximize(this, e);
            }
        }
    }
}
