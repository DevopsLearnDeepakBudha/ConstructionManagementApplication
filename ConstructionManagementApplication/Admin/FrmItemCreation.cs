using ConstructionManagementApplication.Model;
using ContructionDBLayer.AdminRepository;
using ContructionManagementApplication.common;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConstructionManagementApplication
{
    public partial class FrmItemCreation : Form
    {
        Product product;
        public FrmItemCreation()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                MasterRepository accountRepository = new MasterRepository();

                if (cboUnits.DataSource is null)
                {
                    List<Units> units = accountRepository.GetUnit();
                    cboUnits.DataSource = units;
                    cboUnits.DisplayMember = "UnitCode";
                    cboUnits.ValueMember = "Unitid";
                }

                List<Product> products = accountRepository.GetProduct();
                GrdContent.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItmename.Text))
            {
                MessageBox.Show("Please Enter Item Name");
                txtItmename.Focus();
                return;
            }

            if (cboUnits.SelectedIndex <= 0)
            {
                MessageBox.Show("Please Select Unit");
                cboUnits.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtOpeningQnty.Text))
            {
                MessageBox.Show("Please Enter Opening Quantity");
                txtOpeningQnty.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPerItemRate.Text))
            {
                MessageBox.Show("Please Enter Item Rate");
                txtPerItemRate.Focus();
                return;
            }

            if (product == null)
                product = new Product();

            product.ProductName = txtItmename.Text.Trim();
            product.Unitid = cboUnits.SelectedIndex;
            product.UnitCode = ((Units)cboUnits.SelectedItem).UnitCode;
            product.OpenQnty = HelperMethod.ConvertIntiger(txtOpeningQnty.Text.Trim());
            product.ProductRate = HelperMethod.ConvertDouble(txtPerItemRate.Text.Trim());
            product.ProductDescription = txtItemDescription.Text.Trim();
            product.IsActive = 1;

            if (btnSave.Text.Equals("Update", StringComparison.InvariantCultureIgnoreCase))
            {
                product.Updatedby = User.UserId;
                product.Updatedon = DateTime.Now;
            }
            else
            {
                product.Createdby = User.UserId;
            }

            MasterRepository accountRepository = new MasterRepository();
            accountRepository.CreateProduct(product);

            if (product.IsSuccess)
            {
                FrmDashboard_Load(null, null);
                MessageBox.Show(product.Message);
            }
            else
            {
                MessageBox.Show(product.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItmename.Text = "";
            cboUnits.SelectedIndex = 0;
            txtOpeningQnty.Text = "";
            txtPerItemRate.Text = "";
            txtItemDescription.Text = "";
            btnSave.Text = "Save";
            product = null;
        }

        private void GrdContent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Productid = HelperMethod.ConvertIntiger(GrdContent.Rows[e.RowIndex].Cells[0].Value.ToString());
                product = ((List<Product>)GrdContent.DataSource).Where(x => x.Productid == Productid).FirstOrDefault();
                btnSave.Text = "Update";
                txtItmename.Text = product.ProductName;
                cboUnits.SelectedIndex = product.Unitid;
                txtOpeningQnty.Text = product.OpenQnty.ToString();
                txtPerItemRate.Text = product.ProductRate.ToString();
                txtItemDescription.Text = product.ProductDescription;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
