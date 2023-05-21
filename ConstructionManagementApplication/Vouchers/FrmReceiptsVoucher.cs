using ConstructionManagementApplication.Model.ViewModels;
using ContructionDBLayer.Repository;
using ContructionManagementApplication.common;
using System;
using System.Windows.Forms;
using System.Linq;
using ConstructionManagementApplication.Model.Models;
using ConstructionManagementApplication.Model;
using System.Globalization;
using ContructionManagementApplication.common.NepaliCalendar;

namespace ConstructionManagementApplication.Vouchers
{
    public partial class FrmReceiptsVoucher : Form
    {
        public FrmReceiptsVoucher()
        {
            InitializeComponent();
        }

        private void FrmReceiptsVoucher_Load(object sender, EventArgs e)
        {
            string countryName = RegionInfo.CurrentRegion.DisplayName;
            var regionName = RegionInfo.CurrentRegion.ThreeLetterWindowsRegionName;
            Console.WriteLine($"{countryName}, {regionName}");


            AutoCustomerSearch();
            LoadReceipt();
        }

        private void LoadReceipt()
        {
            if (ReceiptVoucherView.Receiptid <= 0)
            {
                return;
            }
            try
            {
                VoucherRepository voucherRepository = new VoucherRepository();
                ReceiptVoucherView.ReceiptVoucher = voucherRepository.GetReceiptVoucher();

                if (!ReceiptVoucherView.IsSuccess)
                {
                    MessageBox.Show(ReceiptVoucherView.Message);
                    return;
                }

                if (ReceiptVoucherView.ReceiptVoucher.Receiptid > 0)
                {
                    SearchCustomer searchCustomer = ReceiptVoucherView.SearchCustomer.Where(x => x.Customerid == ReceiptVoucherView.ReceiptVoucher.CustomerId).FirstOrDefault();
                    CmbClientname.SelectedValue = searchCustomer.Customerid;
                    DtpReceiptDate.Value = ReceiptVoucherView.ReceiptVoucher.CollectionDate;
                    TxtReceiptAmount.Text = ReceiptVoucherView.ReceiptVoucher.ReceiptAmount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AutoCustomerSearch()
        {
            try
            {
                VoucherRepository voucherRepository = new VoucherRepository();
                ReceiptVoucherView.SearchCustomer = voucherRepository.ChooseCustomer();

                if (ReceiptVoucherView.SearchCustomer.Count() > 0)
                {
                    CmbClientname.DataSource = SalesVoucherView.SearchCustomer;
                    CmbClientname.DisplayMember = "Fullname";
                    CmbClientname.ValueMember = "Customerid";
                }
                else
                {
                    MessageBox.Show("Name not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbClientname.SelectedIndex <= 0)
                {
                    MessageBox.Show("Please Enter Customer.");
                    return;
                }

                if (string.IsNullOrEmpty(TxtReceiptAmount.Text))
                {
                    MessageBox.Show("Please Enter Receipt Amount.");
                    return;
                }

                var BillReceipt = HelperMethod.ConvertDouble(TxtReceiptAmount.Text);
                if (BillReceipt <= 0)
                {
                    MessageBox.Show("Receipt Amount Can Not Be Zero.");
                    return;
                }

                if (ReceiptVoucherView.Receiptid > 0)
                {
                    ReceiptVoucherView.ReceiptVoucher.Receiptid = ReceiptVoucherView.Receiptid;
                    ReceiptVoucherView.ReceiptVoucher.ReceiptAmount = BillReceipt;
                    ReceiptVoucherView.ReceiptVoucher.CollectionDate = DtpReceiptDate.Value;
                    ReceiptVoucherView.ReceiptVoucher.Createdby = User.UserId;
                }
                else
                {
                    ReceiptVoucherView.ReceiptVoucher = new ReceiptVoucher()
                    {
                        CustomerId = ReceiptVoucherView.Customer.Customerid,
                        ReceiptAmount = BillReceipt,
                        CollectionDate = DtpReceiptDate.Value,
                        Createdby = User.UserId
                    };
                }


                VoucherRepository voucherRepository = new VoucherRepository();
                voucherRepository.SaveReceiptVoucher();

                if (ReceiptVoucherView.IsSuccess)
                {
                    ReceiptVoucherView.IsModified = true;
                    this.Close();
                }

                MessageBox.Show(ReceiptVoucherView.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DtpReceiptDate_ValueChanged(object sender, EventArgs e)
        {
            NepaliDate nepaliDate = new NepaliDate();
            CustomDateView resultOne = nepaliDate.AD2BS(DtpReceiptDate.Value);
            //CustomDateView resultTwo = nepaliDate.BS2AD(resultOne.DateTime);
            if (resultOne.IsSuccess)
            {
                LblNepaliDate.Text = string.Format("{0}-{1}-{2}", resultOne.customDate.Day, (NepaleseMonth)resultOne.customDate.Month, resultOne.customDate.Year);
            }
            else
            {
                MessageBox.Show(resultOne.Message);
            }
        }
    }
}
