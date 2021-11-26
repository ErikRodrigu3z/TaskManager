using System;
using System.Windows.Forms;
using TaskManager.Repository.CategoryRepo;
using TaskManager.UserControls;

namespace TaskManager.Forms.ChildForms
{
    public partial class Notes : Form
    {
        private readonly ICategoryRepo _CatRepo;
        private readonly CustomToolTip toolTip;

        public Notes()
        {
            InitializeComponent();
            _CatRepo = new CategoryRepo();
            toolTip = new CustomToolTip();
            FillCmbCategory();
        }

        #region Form events
        private void Notes_Load(object sender, EventArgs e)
        {
            // Set up the ToolTip text for the Button and Checkbox.             
            toolTip.SetToolTip(this.btnAddCategory, "Add Category \n ");
            toolTip.SetToolTip(this.btnCopy, "Copy Content \n ");

        }

        #endregion

        #region controls events
        private void btnAddCategory_Click(object sender, EventArgs e)
        {

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

        }

        private void btnEditArticle_Click(object sender, EventArgs e)
        {

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {

        } 
        #endregion

        #region Methods
        public void FillCmbCategory()
        {
            cmbCategories.DataSource = _CatRepo.GetAll();
            cmbCategories.DisplayMember = "Name";
            cmbCategories.ValueMember = "CategoryID";
        }





        #endregion

    }
}
