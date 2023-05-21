using ConstructionManagementApplication.Model;
using ContructionDBLayer.AdminRepository;
using ContructionManagementApplication.common;
using System;
using System.IO;
using System.Windows.Forms;

namespace ConstructionManagementApplication
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show("Please Enter Username!!!");
                    return;
                }
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Please Enter Password!!!");
                    return;
                }

                User.UserName = txtUsername.Text.Trim();
                User.Password = txtPassword.Text.Trim();

                MasterRepository accountRepository = new MasterRepository();
                accountRepository.UserLoginValidate();

                if (User.IsSuccess)
                {
                    FormDashboard item = new FormDashboard();
                    item.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(User.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("helperCS.txt");
                Constants.DBCS = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ex)
            {
                btnSubmit.Enabled = false;
                MessageBox.Show(ex.Message);
            }
        }
    }
}
