using System;
using System.Windows.Forms;
using TaskManager.Forms.Modals;
using TaskManager.Helpers;
using TaskManager.Models;
using TaskManager.Repository.ArticleRepo;
using TaskManager.Repository.CategoryRepo;
using TaskManager.UserControls;
using static TaskManager.Helpers.Enums;

namespace TaskManager.Forms.ChildForms
{
    public partial class Notes : Form
    {
        int idCategory = 0; 
        private readonly ICategoryRepo _CatRepo;
        private readonly IArticleRepo _Article;
        private readonly CustomToolTip toolTip;
        AddEditCategory addEditModal;

        public Notes()
        {
            InitializeComponent();
            _CatRepo = new CategoryRepo();
            _Article = new ArticleRepo();
            toolTip = new CustomToolTip();
            addEditModal = new AddEditCategory();
            FillCmbCategory();
        }

        #region Form events
        private void Notes_Load(object sender, EventArgs e)
        {
            // Set up the ToolTip text for the Button and Checkbox.             
            SetToolTips();
            lblIdCategory.Text = cmbCategories.SelectedValue.ToString();

            #region event handler -> AddCategory, EditCategory forms
            addEditModal.RefreshCmb += new AddEditCategory.RefreshCmbCategory(FillCmbCategory);
            #endregion

            FillGridArticleByIdCat(Convert.ToInt32(lblIdCategory.Text));
            
        }

        #endregion

        #region gvArticle events
        private void gvArticles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = gvArticles.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView
            if (fila != null)
            {
                lblIdArticle.Text = Convert.ToString(fila.Cells[0].Value); //optengo valor de la primer columna
                txtArticle.Text = Convert.ToString(fila.Cells[1].Value).Replace("char(39)", "'"); //optengo valor de la segunda columna
                txtTitle.Text = Convert.ToString(fila.Cells[2].Value); //optengo valor de la tercer columna                
                btnAddArticle.Enabled = false;
                btnEditArticle.Enabled = true;
            }
        }
        #endregion


        #region controls events
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Statics.AddCategory = true;
            FormHelper.ShowDialog(addEditModal);
        }
        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            Statics.AddCategory = false;
            Statics.IdCategory = Convert.ToInt32(lblIdCategory.Text);
            FormHelper.ShowDialog(addEditModal);
        } 
        private void Notes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("siiii");
            }
        }
        private void btnClearArticle_Click(object sender, EventArgs e)
        {
            ClearArticle();
        }
        private void btnEditArticle_Click(object sender, EventArgs e)
        {
            var res = ValidateArticle();
            if (res == Result.success)
            {
                var article = _Article.GetById(Convert.ToInt32(lblIdArticle.Text));
                article.Title = txtTitle.Text;
                article.Content = txtArticle.Text;
                _Article.Update(article);
                FillGridArticleByIdCat(Convert.ToInt32(lblIdCategory.Text));                
            }
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtArticle.Text);
        }
        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            var res = ValidateArticle();            
            if (res == Result.success)
            {
                Articles article = new Articles
                {
                    Content = txtArticle.Text.Replace("'", "char(39)"),
                    Title = txtTitle.Text,
                    Date = DateTime.UtcNow,
                    IdCategory = Convert.ToInt32(lblIdCategory.Text)
                };
                _Article.Create(article);
                FillGridArticleByIdCat(Convert.ToInt32(lblIdCategory.Text));
                btnAddArticle.Enabled = false;                
            }
            
           
        }
        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            bool change = int.TryParse(cmbCategories.SelectedValue.ToString(), out idCategory);
            if (change)
            {
                lblIdCategory.Text = idCategory.ToString();
            }
            FillGridArticleByIdCat(Convert.ToInt32(lblIdCategory.Text));
        }
        #endregion

        #region Methods
        public void FillCmbCategory()
        {
            cmbCategories.DataSource = _CatRepo.GetAll();
            cmbCategories.DisplayMember = "Name";
            cmbCategories.ValueMember = "CategoryID";
        }

        public void ClearArticle()
        {
            txtTitle.ResetText();
            txtArticle.ResetText();
            btnAddArticle.Enabled = true;
            btnEditArticle.Enabled = false;
        }

        public Result ValidateArticle()
        {
            if (string.IsNullOrEmpty(txtArticle.Text) || string.IsNullOrEmpty(txtTitle.Text))
            {
                MessageHelper.Show("Debe llenar ambos campos", "Articulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return Result.fail;
            }
            return Result.success;
        }

        public void FillGridArticle()
        {
            gvArticles.DataSource = _Article.GetAll();
            FormatGridArticle();
        }
        public void FillGridArticleByIdCat(int idCategpry) 
        { 
            gvArticles.DataSource = _Article.FindByCondition(x => x.IdCategory == idCategpry);
            FormatGridArticle();
        }

        public void FormatGridArticle()
        {            
            gvArticles.Columns[0].Visible = false;
            gvArticles.Columns[1].Visible = false;
            gvArticles.Columns[3].Visible = false;
            gvArticles.Columns[4].Visible = false;
            gvArticles.Columns[2].Width = 400;
            gvArticles.Columns[2].HeaderText = "Articles";
        }
        public void SetToolTips() 
        {
            toolTip.SetToolTip(this.btnAddCategory, "Add Category \n ");
            toolTip.SetToolTip(this.btnEditCategory, "Edit Category \n ");
            toolTip.SetToolTip(this.btnCopy, "Copy Content \n ");
            toolTip.SetToolTip(this.btnAddArticle, "Add new article \n ");
            toolTip.SetToolTip(this.btnEditArticle, "Edit Article \n ");
            toolTip.SetToolTip(this.btnClearArticle, "Clear Article \n ");
        }
        #endregion

    }
}
