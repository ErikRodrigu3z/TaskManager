namespace TaskManager.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pMenu = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnTareas = new FontAwesome.Sharp.IconButton();
            this.btnUsers = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.btnNotes = new FontAwesome.Sharp.IconButton();
            this.btnMenu = new RJCodeUI_M1.RJControls.RJMenuIcon();
            this.pRight = new System.Windows.Forms.Panel();
            this.pTop = new System.Windows.Forms.Panel();
            this.rjButton2 = new RJCodeUI_M1.RJControls.RJButton();
            this.rjButton1 = new RJCodeUI_M1.RJControls.RJButton();
            this.pMain = new System.Windows.Forms.Panel();
            this.maxRestMinButtons1 = new TaskManager.UserControls.MaxRestMinButtons();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.pRight.SuspendLayout();
            this.pTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pMenu.BackColor = System.Drawing.Color.Black;
            this.pMenu.Controls.Add(this.iconButton3);
            this.pMenu.Controls.Add(this.iconButton1);
            this.pMenu.Controls.Add(this.btnTareas);
            this.pMenu.Controls.Add(this.btnUsers);
            this.pMenu.Controls.Add(this.btnHome);
            this.pMenu.Controls.Add(this.btnNotes);
            this.pMenu.Controls.Add(this.btnMenu);
            this.pMenu.Location = new System.Drawing.Point(-6, -5);
            this.pMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(249, 992);
            this.pMenu.TabIndex = 3;
            this.pMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pMenu_MouseDown);
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.iconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.BookDead;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 35;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(12, 394);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(225, 55);
            this.iconButton3.TabIndex = 49;
            this.iconButton3.Text = "Notes";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Visible = false;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.BookDead;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(12, 329);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(225, 55);
            this.iconButton1.TabIndex = 48;
            this.iconButton1.Text = "Notes";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Visible = false;
            // 
            // btnTareas
            // 
            this.btnTareas.FlatAppearance.BorderSize = 0;
            this.btnTareas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnTareas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTareas.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareas.ForeColor = System.Drawing.Color.White;
            this.btnTareas.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.btnTareas.IconColor = System.Drawing.Color.White;
            this.btnTareas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTareas.IconSize = 35;
            this.btnTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTareas.Location = new System.Drawing.Point(12, 205);
            this.btnTareas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTareas.Name = "btnTareas";
            this.btnTareas.Size = new System.Drawing.Size(225, 55);
            this.btnTareas.TabIndex = 47;
            this.btnTareas.Text = "Tasks";
            this.btnTareas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTareas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTareas.UseVisualStyleBackColor = true;
            this.btnTareas.Visible = false;
            this.btnTareas.Click += new System.EventHandler(this.btnTareas_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnUsers.IconColor = System.Drawing.Color.White;
            this.btnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsers.IconSize = 35;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(12, 265);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(225, 55);
            this.btnUsers.TabIndex = 46;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Visible = false;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 35;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 85);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(225, 55);
            this.btnHome.TabIndex = 45;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnNotes
            // 
            this.btnNotes.FlatAppearance.BorderSize = 0;
            this.btnNotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnNotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotes.ForeColor = System.Drawing.Color.White;
            this.btnNotes.IconChar = FontAwesome.Sharp.IconChar.BookDead;
            this.btnNotes.IconColor = System.Drawing.Color.White;
            this.btnNotes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNotes.IconSize = 35;
            this.btnNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotes.Location = new System.Drawing.Point(12, 145);
            this.btnNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(225, 55);
            this.btnNotes.TabIndex = 44;
            this.btnNotes.Text = "Notes";
            this.btnNotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackIcon = true;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Customizable = true;
            this.btnMenu.DropdownMenu = null;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.EllipsisH;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMenu.IconSize = 43;
            this.btnMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(58, 43);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 43;
            this.btnMenu.TabStop = false;
            // 
            // pRight
            // 
            this.pRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pRight.Controls.Add(this.maxRestMinButtons1);
            this.pRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pRight.Location = new System.Drawing.Point(1509, 2);
            this.pRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pRight.Name = "pRight";
            this.pRight.Size = new System.Drawing.Size(333, 961);
            this.pRight.TabIndex = 4;
            this.pRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pRight_MouseDown);
            // 
            // pTop
            // 
            this.pTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pTop.Controls.Add(this.rjButton2);
            this.pTop.Controls.Add(this.rjButton1);
            this.pTop.Location = new System.Drawing.Point(240, 0);
            this.pTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(1272, 78);
            this.pTop.TabIndex = 5;
            this.pTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTop_MouseDown);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.Black;
            this.rjButton2.BorderColor = System.Drawing.Color.Black;
            this.rjButton2.BorderRadius = 19;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.Design = RJCodeUI_M1.RJControls.ButtonDesign.Custom;
            this.rjButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.rjButton2.IconColor = System.Drawing.Color.White;
            this.rjButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjButton2.IconSize = 30;
            this.rjButton2.Location = new System.Drawing.Point(87, 6);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(66, 58);
            this.rjButton2.Style = RJCodeUI_M1.RJControls.ControlStyle.Solid;
            this.rjButton2.TabIndex = 48;
            this.rjButton2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rjButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Black;
            this.rjButton1.BorderColor = System.Drawing.Color.Black;
            this.rjButton1.BorderRadius = 19;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Design = RJCodeUI_M1.RJControls.ButtonDesign.Custom;
            this.rjButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.rjButton1.IconColor = System.Drawing.Color.White;
            this.rjButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjButton1.IconSize = 30;
            this.rjButton1.Location = new System.Drawing.Point(12, 6);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(66, 58);
            this.rjButton1.Style = RJCodeUI_M1.RJControls.ControlStyle.Solid;
            this.rjButton1.TabIndex = 47;
            this.rjButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rjButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // pMain
            // 
            this.pMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pMain.AutoScroll = true;
            this.pMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pMain.Location = new System.Drawing.Point(240, 72);
            this.pMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1272, 891);
            this.pMain.TabIndex = 6;
            this.pMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pMain_MouseDown);
            // 
            // maxRestMinButtons1
            // 
            this.maxRestMinButtons1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxRestMinButtons1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maxRestMinButtons1.Location = new System.Drawing.Point(200, -7);
            this.maxRestMinButtons1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.maxRestMinButtons1.Name = "maxRestMinButtons1";
            this.maxRestMinButtons1.Size = new System.Drawing.Size(138, 48);
            this.maxRestMinButtons1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1844, 965);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pTop);
            this.Controls.Add(this.pRight);
            this.Controls.Add(this.pMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.pRight.ResumeLayout(false);
            this.pTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.MaxRestMinButtons maxRestMinButtons1;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pRight;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Panel pMain;
        private RJCodeUI_M1.RJControls.RJMenuIcon btnMenu;
        private RJCodeUI_M1.RJControls.RJButton rjButton2;
        private RJCodeUI_M1.RJControls.RJButton rjButton1;
        private FontAwesome.Sharp.IconButton btnNotes;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnTareas;
        private FontAwesome.Sharp.IconButton btnUsers;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}