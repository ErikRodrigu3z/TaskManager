using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager.UserControls
{
    public partial class MinCloseButtons : UserControl
    {
        //event handler
        public event EventHandler ButtonClose;
        public event EventHandler ButtonMinimize;

        public MinCloseButtons()
        {
            InitializeComponent();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (this.ButtonMinimize != null)
                this.ButtonMinimize(this, e);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           
            if (this.ButtonClose != null)
                this.ButtonClose(this, e);
        }
    }
}
