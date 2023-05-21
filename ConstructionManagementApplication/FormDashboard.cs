using ConstructionManagementApplication.Admin;
using ConstructionManagementApplication.Model.ViewModels;
using ConstructionManagementApplication.Report;
using ConstructionManagementApplication.Vouchers;
using System;
using System.Windows.Forms;

namespace ConstructionManagementApplication
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void DefaultHomeForm()
        {
            FrmCustomerReport sale = new FrmCustomerReport { MdiParent = this, WindowState = FormWindowState.Maximized };
            sale.Show();
            sale.BringToFront();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            DefaultHomeForm();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmCustomerCreation customer = new FrmCustomerCreation { MdiParent = this, WindowState = FormWindowState.Maximized };
            customer.Show();
            customer.BringToFront();
        }

        private void CreateItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItemCreation item = new FrmItemCreation { MdiParent = this, WindowState = FormWindowState.Maximized };
            item.Show();
            item.BringToFront();
        }

        private void SalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesVoucherView.SalesId = 0;
            FrmSalesVoucher sale = new FrmSalesVoucher();
            sale.ShowDialog();
        }

        private void ReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceiptVoucherView.Receiptid = 0;
            FrmReceiptsVoucher item = new FrmReceiptsVoucher();
            item.ShowDialog();
        }

        private void ToolStripMenuItemCustomerReport_Click(object sender, EventArgs e)
        {
            DefaultHomeForm();
        }
    }
}
