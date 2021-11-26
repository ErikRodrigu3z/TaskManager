using FontAwesome.Sharp;
using System.Drawing;
using System.Windows.Forms;
using TaskManager.Forms;

namespace TaskManager.Helpers
{
    public static class FormHelper
    {
        //Fields
        private static IconButton currentBtn;
        public static FormWindowState formWinodowState { get; set; }

        #region Open, close Forms
        public static void Show(Form form)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == form.Name)
                {
                    //if open, close de form instance
                    form.Dispose();
                    form.Close();
                    //focus de form
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
        public static void OpenChildForm(Form form, Panel panel)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            // 
            panel.Controls.Add(form);
            panel.AutoScrollMinSize = form.Size;

            form.Show();
        }
        public static void CloseApp(Form form)
        {
            if (form.Name == nameof(MainForm))
            {
                form.Dispose();
                Application.Exit();
            }
            form.Dispose();
        }
        public static void CloseMain(Form form) 
        {            
            form.Dispose();
            LoginForm login = new LoginForm();
            Show(login);
        }
        public static void CloseForm(Form form)
        {           
            form.Dispose();
        }
        public static void CloseAllChildForms(Panel panel) 
        {
            panel.Controls.Clear();
            panel.AutoScrollMinSize = new System.Drawing.Size(0, 0);
        }
        #endregion

        #region Active, disable menu buttons
        public static void SetActiveButtonMenu(object button)
        {
            if (button != null)
            {
                DisableButton();
                currentBtn = (IconButton)button;
                currentBtn.BackColor = Color.FromArgb(99, 99, 99);
            }
        }

        private static void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Black;
            }
        }
        #endregion

        #region Form WindowState
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
        #endregion
    }
}
