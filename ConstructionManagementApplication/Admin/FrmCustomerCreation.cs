using ConstructionManagementApplication.Model;
using ContructionDBLayer.AdminRepository;
using ContructionManagementApplication.common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructionManagementApplication.Admin
{
    public partial class FrmCustomerCreation : Form
    {
        Customer customer;
        public FrmCustomerCreation()
        {
            InitializeComponent();
        }

        private void FrmCustomerCreation_Load(object sender, EventArgs e)
        {
            try
            {
                MasterRepository accountRepository = new MasterRepository();
                List<Customer> customers = accountRepository.GetCustomer();

                GrdContent.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please Enter First Name");
                return;
            }

            if (string.IsNullOrEmpty(txtLastname.Text))
            {
                MessageBox.Show("Please Enter Last Name");
                return;
            }

            if (string.IsNullOrEmpty(txtMobileNos.Text))
            {
                MessageBox.Show("Please Enter Mobile Number");
                return;
            }

            if (string.IsNullOrEmpty(txtEmailId.Text))
            {
                MessageBox.Show("Please Enter Email");
                return;
            }

            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please Enter Address");
                return;
            }

            if (customer == null)
                customer = new Customer();

            customer.FirstName = txtFirstName.Text.Trim();
            customer.MiddleName = txtMiddlename.Text.Trim();
            customer.LastName = txtLastname.Text.Trim();
            customer.Mobile = txtMobileNos.Text.Trim();
            customer.Email = txtEmailId.Text.Trim();
            customer.Address = txtAddress.Text.Trim();
            customer.IsActive = 1;

            if (btnSave.Text.Equals("Update", StringComparison.InvariantCultureIgnoreCase))
            {
                customer.Updatedby = User.UserId;
                customer.Updatedon = DateTime.Now;
            }
            else
            {
                customer.Createdby = User.UserId;
            }

            MasterRepository accountRepository = new MasterRepository();
            accountRepository.CreateCustomer(customer);

            if (customer.IsSuccess)
            {
                FrmCustomerCreation_Load(null, null);
                MessageBox.Show(customer.Message);
            }
            else
            {
                MessageBox.Show(customer.Message);
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtMiddlename.Text = "";
            txtLastname.Text = "";
            txtMobileNos.Text = "";
            txtEmailId.Text = "";
            txtAddress.Text = "";
            btnSave.Text = "Save";
            customer = null;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GrdContent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Customerid = HelperMethod.ConvertIntiger(GrdContent.Rows[e.RowIndex].Cells[0].Value.ToString());
                customer = ((List<Customer>)GrdContent.DataSource).Where(x => x.Customerid == Customerid).FirstOrDefault();
                btnSave.Text = "Update";
                txtFirstName.Text = customer.FirstName;
                txtMiddlename.Text = customer.MiddleName;
                txtLastname.Text = customer.LastName;
                txtMobileNos.Text = customer.Mobile;
                txtEmailId.Text = customer.Email;
                txtAddress.Text = customer.Address;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
