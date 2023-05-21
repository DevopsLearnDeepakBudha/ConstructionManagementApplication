using ConstructionManagementApplication.Model.ViewModels;
using ContructionDBLayer.Repository;
using ContructionManagementApplication.common;
using System;
using System.Data;
using System.Windows.Forms;

namespace ConstructionManagementApplication.Vouchers
{
    public partial class FrmSalesVoucherReport : Form
    {
        public FrmSalesVoucherReport()
        {
            InitializeComponent();
        }
        private void FrmSalesVoucher_Load(object sender, EventArgs e)
        {
            LoadSalesVoucherData();
        }

        private void LoadSalesVoucherData()
        {
            try
            {
                VoucherRepository voucherRepository = new VoucherRepository();
                DataSet dataset = voucherRepository.LoadSalesVoucherData(SalesVoucherView.Customerid);
                DgvOrder.Rows.Clear();
                foreach (DataRow item in dataset.Tables[0].Rows)
                {
                    DataGridViewRow dgvr = DgvOrder.Rows[DgvOrder.Rows.Add()];
                    dgvr.Cells[Salesid.Index].Value = item["Salesid"].ToString();
                    dgvr.Cells[InvoiceDate.Index].Value = HelperMethod.ConvertDateTime(item["InvoiceDate"].ToString());
                    dgvr.Cells[InvoiceNumber.Index].Value = item["InvoiceNumber"].ToString();
                    dgvr.Cells[Status.Index].Value = item["Status"].ToString();
                    dgvr.Cells[TotalAmount.Index].Value = item["TotalAmount"].ToString();
                }

                DgvCollection.Rows.Clear();
                foreach (DataRow item in dataset.Tables[1].Rows)
                {
                    DataGridViewRow dgvr = DgvCollection.Rows[DgvCollection.Rows.Add()];
                    dgvr.Cells[Receiptid.Index].Value = HelperMethod.ConvertIntiger(item["Receiptid"].ToString());
                    dgvr.Cells[CollectionDate.Index].Value = HelperMethod.ConvertDateTime(item["CollectionDate"].ToString());
                    dgvr.Cells[ReceiptAmount.Index].Value = item["ReceiptAmount"].ToString();
                }

                var TotalSalesAmount = HelperMethod.ConvertDouble(dataset.Tables[0].Compute("sum(TotalAmount)", "StatusId=1").ToString());
                lblTotalAmount.Text = string.Format("Total Amount : {0}", TotalSalesAmount);
                lblTotalAmount.Update();

                var SalesReturn = HelperMethod.ConvertDouble(dataset.Tables[0].Compute("sum(TotalAmount)", "StatusId=3").ToString());
                LblSalesReturn.Text = string.Format("Sales Return : {0}", SalesReturn);
                LblSalesReturn.Update();

                var TotalCollection = HelperMethod.ConvertDouble(dataset.Tables[1].Compute("sum(ReceiptAmount)", "").ToString());
                lblTotalCollection.Text = string.Format("Total Collection : {0}", TotalCollection);
                lblTotalCollection.Update();

                LblOutstanding.Text = string.Format("OutStanding : {0}", (TotalSalesAmount - TotalCollection));
                LblOutstanding.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                ReceiptVoucherView.IsModified = false;
                ReceiptVoucherView.Receiptid = 0;
                FrmReceiptsVoucher item = new FrmReceiptsVoucher();
                item.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (ReceiptVoucherView.IsModified)
                {
                    LoadSalesVoucherData();
                }
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                SalesVoucherView.IsModified = false;
                SalesVoucherView.SalesId = 0;
                SalesVoucherView.IsModified = false;
                FrmSalesVoucher sale = new FrmSalesVoucher();
                sale.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (SalesVoucherView.IsModified)
                {
                    LoadSalesVoucherData();
                }
            }
        }

        private void DgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SalesVoucherView.IsModified = false;
                SalesVoucherView.SalesId = HelperMethod.ConvertIntiger(DgvOrder.Rows[e.RowIndex].Cells[Salesid.Index].Value.ToString());
                FrmSalesVoucher sale = new FrmSalesVoucher();
                sale.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (SalesVoucherView.IsModified)
                {
                    LoadSalesVoucherData();
                }
            }
        }

        private void DgvCollection_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ReceiptVoucherView.IsModified = false;
                ReceiptVoucherView.Receiptid = HelperMethod.ConvertIntiger(DgvCollection.Rows[e.RowIndex].Cells[Receiptid.Index].Value.ToString());
                FrmReceiptsVoucher receipt = new FrmReceiptsVoucher();
                receipt.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (ReceiptVoucherView.IsModified)
                {
                    LoadSalesVoucherData();
                }
            }
        }
    }
}
