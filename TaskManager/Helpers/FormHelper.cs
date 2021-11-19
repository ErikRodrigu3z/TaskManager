using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Forms;

namespace TaskManager.Helpers
{
    public static class FormHelper
    {
        public static FormWindowState formWinodowState { get; set; }

        #region Open Forms
        public static void Show(Form form)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == form.Name)
                {                   
                    item.Visible = true;
                    item.Focus();
                    return;
                }                
            }
            // if not open, open it
            {
                form.Show();                
            }
        }

        public static void ShowDialog(Form form) 
        {  
            form.ShowDialog();            
        }

        #endregion

        public static void CloseForm(Form form)
        {
            if (form.Name == nameof(MainForm))
            {
                form.Dispose();
                Application.Exit();
            }
            form.Dispose();
        }

        public static void WindowState(Form form) 
        {
            switch (formWinodowState)
            {
                case FormWindowState.Maximized:
                    form.WindowState = FormWindowState.Normal;
                    break;
                case FormWindowState.Minimized:
                    form.WindowState = FormWindowState.Minimized;
                    break;
                case FormWindowState.Normal:
                    form.WindowState = FormWindowState.Maximized;
                    break;
                default:
                    form.WindowState = FormWindowState.Normal;
                    break;
            }
        }
    }
}
