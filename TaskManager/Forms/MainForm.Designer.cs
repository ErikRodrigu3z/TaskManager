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
            this.btnNotes = new FontAwesome.Sharp.IconButton();
            this.btnMenu = new RJCodeUI_M1.RJControls.RJMenuIcon();
            this.pRight = new System.Windows.Forms.Panel();
            this.pTop = new System.Windows.Forms.Panel();
            this.rjButton2 = new RJCodeUI_M1.RJControls.RJButton();
            this.rjButton1 = new RJCodeUI_M1.RJControls.RJButton();
            this.pMain = new System.Windows.Forms.Panel();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.maxRestMinButtons1 = new TaskManager.UserControls.MaxRestMinButtons();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
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
            this.pMenu.Controls.Add(this.iconButton1);
            this.pMenu.Controls.Add(this.iconButton2);
            this.pMenu.Controls.Add(this.btnHome);
            this.pMenu.Controls.Add(this.btnNotes);
            this.pMenu.Controls.Add(this.btnMenu);
            this.pMenu.Location = new System.Drawing.Point(-4, -3);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(166, 645);
            this.pMenu.TabIndex = 3;
            this.pMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pMenu_MouseDown);
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
            this.btnNotes.Location = new System.Drawing.Point(8, 94);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(150, 36);
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
            this.btnMenu.IconSize = 28;
            this.btnMenu.Location = new System.Drawing.Point(8, 8);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(39, 28);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 43;
            this.btnMenu.TabStop = false;
            // 
            // pRight
            // 
            this.pRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pRight.Controls.Add(this.maxRestMinButtons1);
            this.pRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pRight.Location = new System.Drawing.Point(1006, 1);
            this.pRight.Name = "pRight";
            this.pRight.Size = new System.Drawing.Size(222, 625);
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
            this.pTop.Location = new System.Drawing.Point(160, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(848, 51);
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
            this.rjButton2.Location = new System.Drawing.Point(58, 4);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(44, 38);
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
            this.rjButton1.Location = new System.Drawing.Point(8, 4);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(44, 38);
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
            this.pMain.Location = new System.Drawing.Point(160, 47);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(848, 579);
            this.pMain.TabIndex = 6;
            this.pMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pMain_MouseDown);
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
            this.btnHome.Location = new System.Drawing.Point(8, 55);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(150, 36);
            this.btnHome.TabIndex = 45;
            this.btnHome.Text = "Notes";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // maxRestMinButtons1
            // 
            this.maxRestMinButtons1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxRestMinButtons1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maxRestMinButtons1.Location = new System.Drawing.Point(130, -3);
            this.maxRestMinButtons1.Name = "maxRestMinButtons1";
            this.maxRestMinButtons1.Size = new System.Drawing.Size(94, 31);
            this.maxRestMinButtons1.TabIndex = 2;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(8, 133);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(150, 36);
            this.iconButton1.TabIndex = 47;
            this.iconButton1.Text = "Notes";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.BookDead;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(8, 172);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(150, 36);
            this.iconButton2.TabIndex = 46;
            this.iconButton2.Text = "Notes";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1229, 627);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pTop);
            this.Controls.Add(this.pRight);
            this.Controls.Add(this.pMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(1);
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
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}