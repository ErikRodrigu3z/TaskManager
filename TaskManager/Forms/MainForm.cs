﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TaskManager.Forms.ChildForms;
using TaskManager.Helpers;
using TaskManager.Models;
using TaskManager.Repository.CategoryRepo;

namespace TaskManager.Forms
{
    public partial class MainForm : Form
    {
        private readonly ICategoryRepo _catRepo;
        private readonly Notes notes;

        #region Constructor
        public MainForm()
        {
            InitializeComponent();

            #region user control event handlers           
            maxRestMinButtons1.ButtonClose += new EventHandler(User_Control_Close);
            maxRestMinButtons1.ButtonMinimize += new EventHandler(User_Control_Minimize);
            maxRestMinButtons1.ButtonMaximize += new EventHandler(User_Control_Maximize);
            maxRestMinButtons1.ButtonRestore += new EventHandler(User_Control_Restore);
            #endregion

            _catRepo = new CategoryRepo();
            notes = new Notes();
        } 
        #endregion

        #region User control events
        private void User_Control_Restore(object sender, EventArgs e)
        {
            FormHelper.WindowState(this);
        }

        private void User_Control_Maximize(object sender, EventArgs e)
        {
            FormHelper.WindowState(this);
        }

        private void User_Control_Minimize(object sender, EventArgs e)
        {
            FormHelper.WindowState(this);
        }

        private void User_Control_Close(object sender, EventArgs e)
        {
            FormHelper.CloseMain(this);
        }
        #endregion

        #region Menu buttons events       
        private void btnNotes_Click(object sender, EventArgs e)
        {             
            FormHelper.OpenChildForm(notes, pMain);
            FormHelper.SetActiveButtonMenu(btnNotes);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            FormHelper.SetActiveButtonMenu(btnHome);
            FormHelper.CloseAllChildForms(pMain);
        }
        private void btnTareas_Click(object sender, EventArgs e)
        {
            //MessageHelper.Show("mensaje", "Mensaje de prueba", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        #endregion



       
        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }





        #region Methods
        


        #endregion

        #region Drag Form and drag objects "panels, etc"
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pRight_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pMain_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
