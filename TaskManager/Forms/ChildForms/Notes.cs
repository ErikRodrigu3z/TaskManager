using System;
using System.Windows.Forms;
using TaskManager.Forms.Modals;
using TaskManager.Helpers;
using TaskManager.Repository.CategoryRepo;
using TaskManager.UserControls;

namespace TaskManager.Forms.ChildForms
{
    public partial class Notes : Form
    {
        int idCategory = 0; 
        private readonly ICategoryRepo _CatRepo;
        private readonly CustomToolTip toolTip;
        AddEditCategory addEditModal;

        public Notes()
        {
            InitializeComponent();
            _CatRepo = new CategoryRepo();
            toolTip = new CustomToolTip();
            addEditModal = new AddEditCategory();
            FillCmbCategory();
        }

        #region Form events
        private void Notes_Load(object sender, EventArgs e)
        {
            // Set up the ToolTip text for the Button and Checkbox.             
            toolTip.SetToolTip(this.btnAddCategory, "Add Category \n ");
            toolTip.SetToolTip(this.btnCopy, "Copy Content \n ");

            lblIdCategory.Text = cmbCategories.SelectedValue.ToString();

            #region event handler -> AddCategory, EditCategory forms
            addEditModal.RefreshCmb += new AddEditCategory.RefreshCmbCategory(FillCmbCategory);
            #endregion

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

        }
        private void btnEditArticle_Click(object sender, EventArgs e)
        {

        }
        private void btnCopy_Click(object sender, EventArgs e)
        {

        }
        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            bool change = int.TryParse(cmbCategories.SelectedValue.ToString(), out idCategory);
            if (change)
            {
                lblIdCategory.Text = idCategory.ToString();
            }
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
