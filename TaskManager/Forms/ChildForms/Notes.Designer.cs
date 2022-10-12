
namespace TaskManager.Forms.ChildForms
{
    partial class Notes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notes));
            this.gvArticles = new System.Windows.Forms.DataGridView();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtArticle = new System.Windows.Forms.TextBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddCategory = new FontAwesome.Sharp.IconButton();
            this.btnAddArticle = new FontAwesome.Sharp.IconButton();
            this.btnEditArticle = new FontAwesome.Sharp.IconButton();
            this.btnClearArticle = new FontAwesome.Sharp.IconButton();
            this.btnCopy = new FontAwesome.Sharp.IconButton();
            this.lblIdCategory = new System.Windows.Forms.Label();
            this.lblIdArticle = new System.Windows.Forms.Label();
            this.btnEditCategory = new FontAwesome.Sharp.IconButton();
            this.cmbFontSize = new System.Windows.Forms.ComboBox();
            this.StatusSuccessPic = new System.Windows.Forms.PictureBox();
            this.StatusErrorPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusSuccessPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusErrorPic)).BeginInit();
            this.SuspendLayout();
            // 
            // gvArticles
            // 
            this.gvArticles.AllowUserToAddRows = false;
            this.gvArticles.AllowUserToDeleteRows = false;
            this.gvArticles.AllowUserToResizeColumns = false;
            this.gvArticles.AllowUserToResizeRows = false;
            this.gvArticles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gvArticles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvArticles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.gvArticles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvArticles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvArticles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvArticles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvArticles.ColumnHeadersHeight = 30;
            this.gvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvArticles.EnableHeadersVisualStyles = false;
            this.gvArticles.Location = new System.Drawing.Point(18, 146);
            this.gvArticles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gvArticles.Name = "gvArticles";
            this.gvArticles.ReadOnly = true;
            this.gvArticles.RowHeadersVisible = false;
            this.gvArticles.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            this.gvArticles.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gvArticles.Size = new System.Drawing.Size(360, 655);
            this.gvArticles.TabIndex = 0;
            this.gvArticles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvArticles_CellClick);
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(387, 74);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(772, 26);
            this.txtTitle.TabIndex = 1;
            // 
            // txtArticle
            // 
            this.txtArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArticle.Location = new System.Drawing.Point(387, 146);
            this.txtArticle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArticle.Multiline = true;
            this.txtArticle.Name = "txtArticle";
            this.txtArticle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArticle.Size = new System.Drawing.Size(772, 653);
            this.txtArticle.TabIndex = 2;
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(18, 75);
            this.cmbCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(358, 28);
            this.cmbCategories.TabIndex = 3;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(18, 43);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(134, 29);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(387, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Article";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(382, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Title";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.Green;
            this.btnAddCategory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddCategory.IconColor = System.Drawing.Color.White;
            this.btnAddCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCategory.IconSize = 30;
            this.btnAddCategory.Location = new System.Drawing.Point(316, 18);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(62, 52);
            this.btnAddCategory.TabIndex = 7;
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddArticle.BackColor = System.Drawing.Color.Green;
            this.btnAddArticle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddArticle.FlatAppearance.BorderSize = 0;
            this.btnAddArticle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddArticle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArticle.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddArticle.IconColor = System.Drawing.Color.White;
            this.btnAddArticle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddArticle.IconSize = 30;
            this.btnAddArticle.Location = new System.Drawing.Point(1100, 18);
            this.btnAddArticle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(62, 52);
            this.btnAddArticle.TabIndex = 8;
            this.btnAddArticle.UseVisualStyleBackColor = false;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // btnEditArticle
            // 
            this.btnEditArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnEditArticle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditArticle.FlatAppearance.BorderSize = 0;
            this.btnEditArticle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditArticle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditArticle.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditArticle.IconColor = System.Drawing.Color.White;
            this.btnEditArticle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditArticle.IconSize = 30;
            this.btnEditArticle.Location = new System.Drawing.Point(1029, 18);
            this.btnEditArticle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditArticle.Name = "btnEditArticle";
            this.btnEditArticle.Size = new System.Drawing.Size(62, 52);
            this.btnEditArticle.TabIndex = 9;
            this.btnEditArticle.UseVisualStyleBackColor = false;
            this.btnEditArticle.Click += new System.EventHandler(this.btnEditArticle_Click);
            // 
            // btnClearArticle
            // 
            this.btnClearArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnClearArticle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClearArticle.FlatAppearance.BorderSize = 0;
            this.btnClearArticle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClearArticle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClearArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearArticle.IconChar = FontAwesome.Sharp.IconChar.Recycle;
            this.btnClearArticle.IconColor = System.Drawing.Color.White;
            this.btnClearArticle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearArticle.IconSize = 30;
            this.btnClearArticle.Location = new System.Drawing.Point(958, 18);
            this.btnClearArticle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearArticle.Name = "btnClearArticle";
            this.btnClearArticle.Size = new System.Drawing.Size(62, 52);
            this.btnClearArticle.TabIndex = 10;
            this.btnClearArticle.UseVisualStyleBackColor = false;
            this.btnClearArticle.Click += new System.EventHandler(this.btnClearArticle_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.BackColor = System.Drawing.Color.Gray;
            this.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.btnCopy.IconColor = System.Drawing.Color.White;
            this.btnCopy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCopy.IconSize = 15;
            this.btnCopy.Location = new System.Drawing.Point(1100, 114);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(62, 32);
            this.btnCopy.TabIndex = 11;
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblIdCategory
            // 
            this.lblIdCategory.AutoSize = true;
            this.lblIdCategory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCategory.ForeColor = System.Drawing.Color.White;
            this.lblIdCategory.Location = new System.Drawing.Point(160, 48);
            this.lblIdCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdCategory.Name = "lblIdCategory";
            this.lblIdCategory.Size = new System.Drawing.Size(23, 22);
            this.lblIdCategory.TabIndex = 12;
            this.lblIdCategory.Text = "0";
            // 
            // lblIdArticle
            // 
            this.lblIdArticle.AutoSize = true;
            this.lblIdArticle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdArticle.ForeColor = System.Drawing.Color.White;
            this.lblIdArticle.Location = new System.Drawing.Point(490, 118);
            this.lblIdArticle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdArticle.Name = "lblIdArticle";
            this.lblIdArticle.Size = new System.Drawing.Size(23, 22);
            this.lblIdArticle.TabIndex = 13;
            this.lblIdArticle.Text = "0";
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnEditCategory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditCategory.FlatAppearance.BorderSize = 0;
            this.btnEditCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategory.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditCategory.IconColor = System.Drawing.Color.White;
            this.btnEditCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditCategory.IconSize = 30;
            this.btnEditCategory.Location = new System.Drawing.Point(246, 18);
            this.btnEditCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(62, 52);
            this.btnEditCategory.TabIndex = 14;
            this.btnEditCategory.UseVisualStyleBackColor = false;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // cmbFontSize
            // 
            this.cmbFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFontSize.FormattingEnabled = true;
            this.cmbFontSize.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "16",
            "20",
            "22",
            "24",
            "26"});
            this.cmbFontSize.Location = new System.Drawing.Point(1029, 114);
            this.cmbFontSize.Name = "cmbFontSize";
            this.cmbFontSize.Size = new System.Drawing.Size(62, 28);
            this.cmbFontSize.TabIndex = 15;
            this.cmbFontSize.SelectedIndexChanged += new System.EventHandler(this.cmbFontSize_SelectedIndexChanged);
            // 
            // StatusSuccessPic
            // 
            this.StatusSuccessPic.Image = global::TaskManager.Properties.Resources.green_eye;
            this.StatusSuccessPic.Location = new System.Drawing.Point(694, 12);
            this.StatusSuccessPic.Name = "StatusSuccessPic";
            this.StatusSuccessPic.Size = new System.Drawing.Size(73, 50);
            this.StatusSuccessPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StatusSuccessPic.TabIndex = 16;
            this.StatusSuccessPic.TabStop = false;
            this.StatusSuccessPic.Visible = false;
            // 
            // StatusErrorPic
            // 
            this.StatusErrorPic.Image = global::TaskManager.Properties.Resources.red_eye;
            this.StatusErrorPic.Location = new System.Drawing.Point(694, 12);
            this.StatusErrorPic.Name = "StatusErrorPic";
            this.StatusErrorPic.Size = new System.Drawing.Size(73, 50);
            this.StatusErrorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StatusErrorPic.TabIndex = 17;
            this.StatusErrorPic.TabStop = false;
            this.StatusErrorPic.Visible = false;
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1179, 820);
            this.Controls.Add(this.StatusErrorPic);
            this.Controls.Add(this.StatusSuccessPic);
            this.Controls.Add(this.cmbFontSize);
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.lblIdArticle);
            this.Controls.Add(this.lblIdCategory);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnClearArticle);
            this.Controls.Add(this.btnEditArticle);
            this.Controls.Add(this.btnAddArticle);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.txtArticle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.gvArticles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Notes";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Notes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Notes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gvArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusSuccessPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusErrorPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvArticles;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtArticle;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnAddCategory;
        private FontAwesome.Sharp.IconButton btnAddArticle;
        private FontAwesome.Sharp.IconButton btnEditArticle;
        private FontAwesome.Sharp.IconButton btnClearArticle;
        private FontAwesome.Sharp.IconButton btnCopy;
        private System.Windows.Forms.Label lblIdCategory;
        private System.Windows.Forms.Label lblIdArticle;
        private FontAwesome.Sharp.IconButton btnEditCategory;
        private System.Windows.Forms.ComboBox cmbFontSize;
        private System.Windows.Forms.PictureBox StatusSuccessPic;
        private System.Windows.Forms.PictureBox StatusErrorPic;
    }
}