using System;
using System.Windows.Forms;
using TaskManager.Helpers;
using TaskManager.Models;
using TaskManager.Repository.CategoryRepo;

namespace TaskManager.Forms.Modals
{
    public partial class AddEditCategory : Form
    {
        private readonly ICategoryRepo _catRepo;
        Category category;

        #region Delegado
        //delegado
        public delegate void RefreshCmbCategory();
        //evento
        public event RefreshCmbCategory RefreshCmb;
        #endregion

        #region Constructor
        public AddEditCategory()
        {
            InitializeComponent();
            _catRepo = new CategoryRepo();
            category = new Category();
        }
        #endregion
        private void AddEditCategory_Load(object sender, EventArgs e)
        {
            if (Statics.AddCategory)
            {
                txtCategory.Text = "";
            }
            else
            {
                category = _catRepo.GetById(Statics.IdCategory);
                txtCategory.Text = category.Name;
            }
            lblMessage.Visible = false;
        }

        #region controls events

        private void txtCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddEdit();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddEdit();
        } 
        #endregion


        #region Methods
        public void AddEdit()
        {
            try
            {
                if (string.IsNullOrEmpty(txtCategory.Text))
                {
                    lblMessage.Visible = true;
                    lblMessage.Text = "La categoría es obligatoria";
                }
                else
                {
                    if (Statics.AddCategory)
                    {                        
                        Category category = new Category
                        {
                            Name = txtCategory.Text
                        };
                        _catRepo.Create(category);
                        txtCategory.ResetText();
                    }
                    else
                    {
                        category.Name = txtCategory.Text;
                        _catRepo.Update(category);
                        txtCategory.ResetText();
                    }
                    //refresh combo box category
                    this.RefreshCmb();
                    //MessageHelper.ShowSuccess();
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex);
            }
        }
        #endregion

    }
}
