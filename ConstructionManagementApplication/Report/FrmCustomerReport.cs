using System;
using ContructionDBLayer.Repository;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConstructionManagementApplication.Model.ViewModels;
using ConstructionManagementApplication.Model.Models;
using ContructionManagementApplication.common;
using ConstructionManagementApplication.Vouchers;

namespace ConstructionManagementApplication.Report
{
    public partial class FrmCustomerReport : Form
    {
        CustomrReportView customrReportView;
        public FrmCustomerReport()
        {
            InitializeComponent();
        }

        private void FrmCustomerReport_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                ReportRepository reportRepository = new ReportRepository();
                customrReportView = reportRepository.LoadCustomerReport();

                if (!customrReportView.IsSuccess)
                {
                    MessageBox.Show(customrReportView.Message);
                    return;
                }

                DgvContent.Rows.Clear();
                foreach (CustomrReport item in customrReportView.CustomrReportList)
                {
                    DataGridViewRow dgvr = DgvContent.Rows[DgvContent.Rows.Add()];
                    dgvr.Cells[Customerid.Index].Value = item.Customerid;
                    dgvr.Cells[CustomerName.Index].Value = item.CustomerName;
                    dgvr.Cells[TotalAmount.Index].Value = item.TotalAmount;
                    dgvr.Cells[CollectionAmount.Index].Value = item.CollectionAmount;
                    dgvr.Cells[OutStanding.Index].Value = item.OutStanding;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvContent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SalesVoucherView.Customerid = HelperMethod.ConvertIntiger(DgvContent.Rows[e.RowIndex].Cells["Customerid"].Value.ToString());
                if (SalesVoucherView.Customerid > 0)
                {
                    if (this.MdiParent is FormDashboard frm)
                    {
                        FrmSalesVoucherReport sale = new FrmSalesVoucherReport { MdiParent = frm, WindowState = FormWindowState.Maximized };
                        sale.Show();
                        sale.BringToFront();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtSearchKeyword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<CustomrReport> FilterCustomrReport = customrReportView.CustomrReportList.Where(x => x.CustomerName.ToLower().Contains(txtSearchKeyword.Text.Trim().ToLower())).ToList();
                DgvContent.Rows.Clear();
                foreach (CustomrReport item in FilterCustomrReport)
                {
                    DataGridViewRow dgvr = DgvContent.Rows[DgvContent.Rows.Add()];
                    dgvr.Cells[Customerid.Index].Value = item.Customerid;
                    dgvr.Cells[CustomerName.Index].Value = item.CustomerName;
                    dgvr.Cells[TotalAmount.Index].Value = item.TotalAmount;
                    dgvr.Cells[CollectionAmount.Index].Value = item.CollectionAmount;
                    dgvr.Cells[OutStanding.Index].Value = item.OutStanding;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
