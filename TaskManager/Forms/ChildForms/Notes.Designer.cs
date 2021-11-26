
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notes));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 445);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(258, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(516, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(258, 95);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(516, 426);
            this.textBox2.TabIndex = 2;
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(12, 49);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(240, 21);
            this.cmbCategories.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(12, 28);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(89, 18);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(258, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Article";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(255, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
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
            this.btnAddCategory.Location = new System.Drawing.Point(211, 12);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(41, 34);
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
            this.btnAddArticle.Location = new System.Drawing.Point(733, 12);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(41, 34);
            this.btnAddArticle.TabIndex = 8;
            this.btnAddArticle.UseVisualStyleBackColor = false;
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
            this.btnEditArticle.Location = new System.Drawing.Point(686, 12);
            this.btnEditArticle.Name = "btnEditArticle";
            this.btnEditArticle.Size = new System.Drawing.Size(41, 34);
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
            this.btnClearArticle.Location = new System.Drawing.Point(639, 12);
            this.btnClearArticle.Name = "btnClearArticle";
            this.btnClearArticle.Size = new System.Drawing.Size(41, 34);
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
            this.btnCopy.Location = new System.Drawing.Point(733, 74);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(41, 21);
            this.btnCopy.TabIndex = 11;
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblIdCategory
            // 
            this.lblIdCategory.AutoSize = true;
            this.lblIdCategory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCategory.ForeColor = System.Drawing.Color.White;
            this.lblIdCategory.Location = new System.Drawing.Point(107, 31);
            this.lblIdCategory.Name = "lblIdCategory";
            this.lblIdCategory.Size = new System.Drawing.Size(16, 14);
            this.lblIdCategory.TabIndex = 12;
            this.lblIdCategory.Text = "1";
            // 
            // lblIdArticle
            // 
            this.lblIdArticle.AutoSize = true;
            this.lblIdArticle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdArticle.ForeColor = System.Drawing.Color.White;
            this.lblIdArticle.Location = new System.Drawing.Point(327, 77);
            this.lblIdArticle.Name = "lblIdArticle";
            this.lblIdArticle.Size = new System.Drawing.Size(16, 14);
            this.lblIdArticle.TabIndex = 13;
            this.lblIdArticle.Text = "1";
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
            this.btnEditCategory.Location = new System.Drawing.Point(164, 12);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(41, 34);
            this.btnEditCategory.TabIndex = 14;
            this.btnEditCategory.UseVisualStyleBackColor = false;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(786, 533);
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
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notes";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Notes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Notes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
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
    }
}