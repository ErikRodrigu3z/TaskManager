namespace TaskManager.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pLogin = new System.Windows.Forms.Panel();
            this.rjImageColorOverlay2 = new RJCodeUI_M1.RJControls.RJImageColorOverlay();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.icoPassword = new FontAwesome.Sharp.IconPictureBox();
            this.icoUser = new FontAwesome.Sharp.IconPictureBox();
            this.btnLogin = new RJCodeUI_M1.RJControls.RJButton();
            this.biYoutube = new RJCodeUI_M1.RJControls.RJMenuIcon();
            this.biWebPage = new RJCodeUI_M1.RJControls.RJMenuIcon();
            this.biGitHub = new RJCodeUI_M1.RJControls.RJMenuIcon();
            this.biFacebook = new RJCodeUI_M1.RJControls.RJMenuIcon();
            this.txtEmail = new RJCodeUI_M1.RJControls.RJTextBox();
            this.txtPassword = new RJCodeUI_M1.RJControls.RJTextBox();
            this.minCloseButtons = new TaskManager.UserControls.MinCloseButtons();
            this.pLogin.SuspendLayout();
            this.rjImageColorOverlay2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biYoutube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biWebPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biFacebook)).BeginInit();
            this.SuspendLayout();
            // 
            // pLogin
            // 
            this.pLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pLogin.Controls.Add(this.rjImageColorOverlay2);
            this.pLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLogin.Location = new System.Drawing.Point(0, 0);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(320, 246);
            this.pLogin.TabIndex = 0;
            // 
            // rjImageColorOverlay2
            // 
            this.rjImageColorOverlay2.BackColor = System.Drawing.Color.White;
            this.rjImageColorOverlay2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjImageColorOverlay2.BackgroundImage")));
            this.rjImageColorOverlay2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rjImageColorOverlay2.BorderRadius = 0;
            this.rjImageColorOverlay2.Controls.Add(this.lblDescription);
            this.rjImageColorOverlay2.Controls.Add(this.lblTitle);
            this.rjImageColorOverlay2.Controls.Add(this.label2);
            this.rjImageColorOverlay2.Controls.Add(this.label1);
            this.rjImageColorOverlay2.Customizable = true;
            this.rjImageColorOverlay2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjImageColorOverlay2.Image = ((System.Drawing.Image)(resources.GetObject("rjImageColorOverlay2.Image")));
            this.rjImageColorOverlay2.ImageMode = System.Windows.Forms.ImageLayout.Stretch;
            this.rjImageColorOverlay2.Location = new System.Drawing.Point(0, 0);
            this.rjImageColorOverlay2.Name = "rjImageColorOverlay2";
            this.rjImageColorOverlay2.Opacity = 80;
            this.rjImageColorOverlay2.OverlayColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjImageColorOverlay2.Size = new System.Drawing.Size(320, 246);
            this.rjImageColorOverlay2.TabIndex = 37;
            this.rjImageColorOverlay2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rjImageColorOverlay2_MouseDown);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Silver;
            this.lblDescription.Location = new System.Drawing.Point(84, 205);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(234, 32);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Custom themes, styles, forms and\r\ncontrols for WinForm";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblTitle.Location = new System.Drawing.Point(10, 38);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(302, 25);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "RJ Code Modern UI Template";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(134, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opacity 65 + Border radius";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(112, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Login";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.IndianRed;
            this.lblMessage.Location = new System.Drawing.Point(364, 136);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(72, 16);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "Message";
            this.lblMessage.Visible = false;
            // 
            // icoPassword
            // 
            this.icoPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.icoPassword.ForeColor = System.Drawing.Color.Gray;
            this.icoPassword.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.icoPassword.IconColor = System.Drawing.Color.Gray;
            this.icoPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoPassword.IconSize = 38;
            this.icoPassword.Location = new System.Drawing.Point(323, 91);
            this.icoPassword.Name = "icoPassword";
            this.icoPassword.Size = new System.Drawing.Size(43, 38);
            this.icoPassword.TabIndex = 14;
            this.icoPassword.TabStop = false;
            // 
            // icoUser
            // 
            this.icoUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.icoUser.ForeColor = System.Drawing.Color.Gray;
            this.icoUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.icoUser.IconColor = System.Drawing.Color.Gray;
            this.icoUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoUser.IconSize = 39;
            this.icoUser.Location = new System.Drawing.Point(322, 38);
            this.icoUser.Name = "icoUser";
            this.icoUser.Size = new System.Drawing.Size(43, 39);
            this.icoUser.TabIndex = 13;
            this.icoUser.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.BorderColor = System.Drawing.Color.Green;
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.BorderSize = 3;
            this.btnLogin.Design = RJCodeUI_M1.RJControls.ButtonDesign.Custom;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnLogin.FlatAppearance.BorderSize = 3;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Green;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnLogin.IconColor = System.Drawing.Color.Green;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.IconSize = 24;
            this.btnLogin.Location = new System.Drawing.Point(363, 160);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(256, 40);
            this.btnLogin.Style = RJCodeUI_M1.RJControls.ControlStyle.Glass;
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // biYoutube
            // 
            this.biYoutube.BackColor = System.Drawing.Color.Transparent;
            this.biYoutube.BackIcon = true;
            this.biYoutube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biYoutube.Customizable = false;
            this.biYoutube.DropdownMenu = null;
            this.biYoutube.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.biYoutube.IconChar = FontAwesome.Sharp.IconChar.Youtube;
            this.biYoutube.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.biYoutube.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.biYoutube.IconSize = 25;
            this.biYoutube.Location = new System.Drawing.Point(512, 221);
            this.biYoutube.Name = "biYoutube";
            this.biYoutube.Size = new System.Drawing.Size(25, 25);
            this.biYoutube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.biYoutube.TabIndex = 42;
            this.biYoutube.TabStop = false;
            // 
            // biWebPage
            // 
            this.biWebPage.BackColor = System.Drawing.Color.Transparent;
            this.biWebPage.BackIcon = true;
            this.biWebPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biWebPage.Customizable = false;
            this.biWebPage.DropdownMenu = null;
            this.biWebPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.biWebPage.IconChar = FontAwesome.Sharp.IconChar.Globe;
            this.biWebPage.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.biWebPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.biWebPage.IconSize = 25;
            this.biWebPage.Location = new System.Drawing.Point(543, 221);
            this.biWebPage.Name = "biWebPage";
            this.biWebPage.Size = new System.Drawing.Size(25, 25);
            this.biWebPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.biWebPage.TabIndex = 41;
            this.biWebPage.TabStop = false;
            // 
            // biGitHub
            // 
            this.biGitHub.BackColor = System.Drawing.Color.Transparent;
            this.biGitHub.BackIcon = true;
            this.biGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biGitHub.Customizable = false;
            this.biGitHub.DropdownMenu = null;
            this.biGitHub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.biGitHub.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.biGitHub.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.biGitHub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.biGitHub.IconSize = 25;
            this.biGitHub.Location = new System.Drawing.Point(574, 221);
            this.biGitHub.Name = "biGitHub";
            this.biGitHub.Size = new System.Drawing.Size(25, 25);
            this.biGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.biGitHub.TabIndex = 40;
            this.biGitHub.TabStop = false;
            this.biGitHub.Click += new System.EventHandler(this.biGitHub_Click);
            // 
            // biFacebook
            // 
            this.biFacebook.BackColor = System.Drawing.Color.Transparent;
            this.biFacebook.BackIcon = true;
            this.biFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biFacebook.Customizable = false;
            this.biFacebook.DropdownMenu = null;
            this.biFacebook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.biFacebook.IconChar = FontAwesome.Sharp.IconChar.FacebookSquare;
            this.biFacebook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.biFacebook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.biFacebook.IconSize = 25;
            this.biFacebook.Location = new System.Drawing.Point(605, 221);
            this.biFacebook.Name = "biFacebook";
            this.biFacebook.Size = new System.Drawing.Size(25, 25);
            this.biFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.biFacebook.TabIndex = 39;
            this.biFacebook.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail._Customizable = true;
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.BorderColor = System.Drawing.Color.Green;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtEmail.BorderRadius = 0;
            this.txtEmail.BorderSize = 3;
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtEmail.Location = new System.Drawing.Point(363, 34);
            this.txtEmail.MultiLine = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceHolderColor = System.Drawing.Color.Gray;
            this.txtEmail.PlaceHolderText = "User";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.Size = new System.Drawing.Size(256, 34);
            this.txtEmail.Style = RJCodeUI_M1.RJControls.TextBoxStyle.FlaringLine;
            this.txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword._Customizable = true;
            this.txtPassword.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.BorderColor = System.Drawing.Color.Green;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtPassword.BorderRadius = 0;
            this.txtPassword.BorderSize = 3;
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(363, 92);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.MultiLine = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceHolderColor = System.Drawing.Color.Gray;
            this.txtPassword.PlaceHolderText = "Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.Size = new System.Drawing.Size(256, 34);
            this.txtPassword.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteLine;
            this.txtPassword.TabIndex = 43;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // minCloseButtons
            // 
            this.minCloseButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minCloseButtons.Location = new System.Drawing.Point(575, -1);
            this.minCloseButtons.Name = "minCloseButtons";
            this.minCloseButtons.Size = new System.Drawing.Size(56, 25);
            this.minCloseButtons.TabIndex = 44;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(631, 246);
            this.Controls.Add(this.minCloseButtons);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.biYoutube);
            this.Controls.Add(this.biWebPage);
            this.Controls.Add(this.biGitHub);
            this.Controls.Add(this.biFacebook);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.icoPassword);
            this.Controls.Add(this.icoUser);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pLogin);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.pLogin.ResumeLayout(false);
            this.rjImageColorOverlay2.ResumeLayout(false);
            this.rjImageColorOverlay2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biYoutube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biWebPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biFacebook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Label lblMessage;
        private FontAwesome.Sharp.IconPictureBox icoUser;
        private FontAwesome.Sharp.IconPictureBox icoPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private RJCodeUI_M1.RJControls.RJImageColorOverlay rjImageColorOverlay2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RJCodeUI_M1.RJControls.RJButton btnLogin;
        private RJCodeUI_M1.RJControls.RJMenuIcon biYoutube;
        private RJCodeUI_M1.RJControls.RJMenuIcon biWebPage;
        private RJCodeUI_M1.RJControls.RJMenuIcon biGitHub;
        private RJCodeUI_M1.RJControls.RJMenuIcon biFacebook;
        private RJCodeUI_M1.RJControls.RJTextBox txtEmail;
        private RJCodeUI_M1.RJControls.RJTextBox txtPassword;       
        private UserControls.MinCloseButtons minCloseButtons;
    }
}