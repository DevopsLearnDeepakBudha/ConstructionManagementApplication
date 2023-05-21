using ConstructionManagementApplication.Model;
using ConstructionManagementApplication.Model.Enums;
using ConstructionManagementApplication.Model.ViewModels;
using ContructionDBLayer.Repository;
using ContructionManagementApplication.common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ConstructionManagementApplication.Vouchers
{
    public partial class FrmSalesVoucher : Form
    {
        public FrmSalesVoucher()
        {
            InitializeComponent();
        }
        private void FrmSalesVoucher_Load(object sender, EventArgs e)
        {
            AutoCustomerSearch();
            AutoProductSearch();
            LoadOrder();
        }
        private void LoadOrder()
        {
            if (SalesVoucherView.SalesId > 0) { EditOrder(SalesVoucherView.SalesId); } else { GetNewOrder(); }
        }
        private void GetNewOrder()
        {
            try
            {
                VoucherRepository voucherRepository = new VoucherRepository();
                SalesVoucherView.SalesVoucher = voucherRepository.NewSalesVoucher();
                if (SalesVoucherView.SalesVoucher.ProductDetails is null)
                {
                    SalesVoucherView.SalesVoucher.ProductDetails = new List<SalesVoucherDetail>();
                }
                if (SalesVoucherView.IsSuccess)
                {
                    TxtInvoice.Text = SalesVoucherView.SalesVoucher.InvoiceNumber;
                    SalesVoucherView.SalesVoucher.StatusEnum = Status.Cart;
                }
                else
                {
                    throw new Exception(SalesVoucherView.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EditOrder(int SalesId)
        {
            try
            {
                VoucherRepository voucherRepository = new VoucherRepository();
                SalesVoucherView.SalesVoucher = voucherRepository.GetSalesVoucher(SalesId);

                if (!SalesVoucherView.IsSuccess)
                {
                    MessageBox.Show(SalesVoucherView.Message);
                    return;
                }

                ChkSalesReturn.Checked = SalesVoucherView.SalesVoucher.StatusEnum == Status.Return;
                TxtInvoice.Text = SalesVoucherView.SalesVoucher.InvoiceNumber;
                CmbClientname.SelectedIndex = SalesVoucherView.SalesVoucher.Customerid;
                LblNoOfItems.Text = string.Format("No Of Items : {0}", SalesVoucherView.SalesVoucher.ProductCount);
                LblTotalAmount.Text = string.Format("Total Amount : {0}", SalesVoucherView.SalesVoucher.TotalAmount);
                DtpInvoiceDate.Value = SalesVoucherView.SalesVoucher.InvoiceDate;

                DgvProduct.Rows.Clear();
                foreach (SalesVoucherDetail item in SalesVoucherView.SalesVoucher.ProductDetails)
                {
                    DataGridViewRow dgvr = DgvProduct.Rows[DgvProduct.Rows.Add()];
                    dgvr.Cells[SalesDetailid.Index].Value = item.SalesDetailid;
                    dgvr.Cells[Productid.Index].Value = item.Productid;
                    dgvr.Cells[Productname.Index].Value = item.Productname;
                    dgvr.Cells[Rate.Index].Value = item.Rate;
                    dgvr.Cells[Qnty.Index].Value = item.Qnty;
                    dgvr.Cells[TotalPrice.Index].Value = item.TotalPrice;
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
                SalesVoucherView.SearchCustomer = voucherRepository.ChooseCustomer();

                if (SalesVoucherView.SearchCustomer.Count() > 0)
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
        private void AutoProductSearch()
        {
            try
            {
                VoucherRepository voucherRepository = new VoucherRepository();
                SalesVoucherView.SearchProduct = voucherRepository.ChooseProduct();

                if (SalesVoucherView.SearchProduct.Count() > 0)
                {
                    CmbItemname.DataSource = SalesVoucherView.SearchProduct;
                    CmbItemname.DisplayMember = "ProductName";
                    CmbItemname.ValueMember = "Productid";
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
        private void TxtQuantity_Leave(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }
        private void Txtitemrate_Leave(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }
        private void CalculateTotalPrice()
        {
            double Totalprice = (HelperMethod.ConvertDouble(txtQuantity.Text) * HelperMethod.ConvertDouble(txtitemrate.Text));
            txtTotalprice.Text = string.Format("{0}", Totalprice);
        }
        private void TxtClientname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SearchCustomer searchCustomer = SalesVoucherView.SearchCustomer.Where(x => x.Customerid == CmbClientname.SelectedIndex).FirstOrDefault();
                if (searchCustomer != null)
                {
                    txtAddress.Text = searchCustomer.Address;
                    SalesVoucherView.SelectedPerson = searchCustomer;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TxtItemname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SearchProduct searchProduct = SalesVoucherView.SearchProduct.Where(x => x.Productid == CmbItemname.SelectedIndex).FirstOrDefault();
                if (searchProduct != null)
                {
                    txtitemrate.Text = searchProduct.ProductRate.ToString();
                    SalesVoucherView.SelectedProduct = searchProduct;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool CheckNullValue(string ValidateOn)
        {
            if (ValidateOn == "Add")
            {
                if (CmbItemname.SelectedIndex <= 0)
                {
                    MessageBox.Show("Please Enter Item Name.");
                    return true;
                }
                if (string.IsNullOrEmpty(txtQuantity.Text.Trim()) || HelperMethod.ConvertIntiger(txtQuantity.Text.Trim()) <= 0)
                {
                    MessageBox.Show("Please Enter Quantity.");
                    return true;
                }
                if (string.IsNullOrEmpty(txtitemrate.Text.Trim()) || HelperMethod.ConvertIntiger(txtitemrate.Text.Trim()) <= 0)
                {
                    MessageBox.Show("Please Enter Product rate.");
                    return true;
                }
            }
            else
            {
                if (CmbClientname.SelectedIndex <= 0)
                {
                    MessageBox.Show("Please Enter Customer Name.");
                    return true;
                }
                if (DgvProduct.Rows.Count <= 0)
                {
                    MessageBox.Show("Please Add Product to Save.");
                    return true;
                }
            }
            return false;
        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                CheckNullValue("Submit");

                SalesVoucherView.SalesVoucher.InvoiceDate = DtpInvoiceDate.Value;
                SalesVoucherView.Customerid = SalesVoucherView.SalesVoucher.Customerid = SalesVoucherView.SelectedPerson.Customerid;
                SalesVoucherView.SalesVoucher.CustomerName = SalesVoucherView.SelectedPerson.Fullname;
                SalesVoucherView.SalesVoucher.StatusEnum = ChkSalesReturn.Checked ? Status.Return : Status.Sold;

                VoucherRepository voucherRepository = new VoucherRepository();
                voucherRepository.SaveSalesVoucher(SalesVoucherView.SalesVoucher);

                if (SalesVoucherView.IsSuccess)
                {
                    MessageBox.Show(SalesVoucherView.Message);

                    DgvProduct.Rows.Clear();
                    foreach (SalesVoucherDetail item in SalesVoucherView.SalesVoucher.ProductDetails)
                    {
                        DataGridViewRow dgvr = DgvProduct.Rows[DgvProduct.Rows.Add()];
                        dgvr.Cells[SalesDetailid.Index].Value = item.SalesDetailid;
                        dgvr.Cells[Productid.Index].Value = item.Productid;
                        dgvr.Cells[Productname.Index].Value = item.Productname;
                        dgvr.Cells[Rate.Index].Value = item.Rate;
                        dgvr.Cells[Qnty.Index].Value = item.Qnty;
                        dgvr.Cells[TotalPrice.Index].Value = item.TotalPrice;
                    }
                }
                else
                {
                    throw new Exception(SalesVoucherView.Message);
                }
                SalesVoucherView.IsModified = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetProductAdding();
        }
        private void ResetProductAdding()
        {
            BtnAdd.Text = "Add";
            BtnRemove.Visible = false;
            CmbItemname.SelectedIndex = 0;
            txtitemrate.Text = "";
            txtQuantity.Text = "";
            txtTotalprice.Text = "";
        }
        private void BtnReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReceiptsVoucher item = new FrmReceiptsVoucher();
                item.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BtnAdd.Text = "Update";
                BtnRemove.Visible = true;
                SalesVoucherView.SelectedIndex = e.RowIndex;
                SalesVoucherView.Productid = HelperMethod.ConvertIntiger(DgvProduct.Rows[e.RowIndex].Cells[Productid.Index].Value.ToString());
                CmbItemname.SelectedValue = SalesVoucherView.Productid;
                txtitemrate.Text = DgvProduct.Rows[e.RowIndex].Cells[Rate.Index].Value.ToString();
                txtQuantity.Text = DgvProduct.Rows[e.RowIndex].Cells[Qnty.Index].Value.ToString();
                txtTotalprice.Text = DgvProduct.Rows[e.RowIndex].Cells[TotalPrice.Index].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckNullValue("Add"))
                {
                    return;
                }
                if (BtnAdd.Text == "Update")
                {
                    SalesVoucherDetail removeItem = SalesVoucherView.SalesVoucher.ProductDetails.Where(x => x.Productid == SalesVoucherView.Productid).FirstOrDefault();
                    SalesVoucherView.SalesVoucher.ProductDetails.Remove(removeItem);
                }
                else
                {
                    SalesVoucherDetail DuplicateItem = SalesVoucherView.SalesVoucher.ProductDetails.Where(x => x.Productid == SalesVoucherView.Productid).FirstOrDefault();
                    if (DuplicateItem != null)
                    {
                        MessageBox.Show("Same Product can not add again, Kindly Alter the Product.");
                        CmbItemname.Focus();
                        return;
                    }
                }

                SalesVoucherDetail voucherDetail = new SalesVoucherDetail()
                {
                    Salesid = SalesVoucherView.SalesVoucher.Salesid,
                    Productid = SalesVoucherView.SelectedProduct.Productid,
                    Productname = SalesVoucherView.SelectedProduct.ProductName,
                    Rate = HelperMethod.ConvertDouble(txtitemrate.Text.Trim()),
                    Qnty = HelperMethod.ConvertDouble(txtQuantity.Text.Trim()),
                    TotalPrice = HelperMethod.ConvertDouble(txtTotalprice.Text.Trim()),
                };

                voucherDetail.TotalPrice = voucherDetail.Rate * voucherDetail.Qnty;
                SalesVoucherView.SalesVoucher.ProductDetails.Add(voucherDetail);

                SalesVoucherView.SalesVoucher.ProductCount = SalesVoucherView.SalesVoucher.ProductDetails.Count();
                SalesVoucherView.SalesVoucher.TotalAmount = SalesVoucherView.SalesVoucher.ProductDetails.Sum(x => x.TotalPrice);

                LblNoOfItems.Text = string.Format("No Of Items: {0}", SalesVoucherView.SalesVoucher.ProductCount);
                LblTotalAmount.Text = string.Format("Total Amount : {0}", SalesVoucherView.SalesVoucher.TotalAmount);

                if (BtnAdd.Text == "Update")
                {
                    DgvProduct.Rows[SalesVoucherView.SelectedIndex].Cells[SalesDetailid.Index].Value = voucherDetail.SalesDetailid;
                    DgvProduct.Rows[SalesVoucherView.SelectedIndex].Cells[Productid.Index].Value = voucherDetail.Productid;
                    DgvProduct.Rows[SalesVoucherView.SelectedIndex].Cells[Productname.Index].Value = voucherDetail.Productname;
                    DgvProduct.Rows[SalesVoucherView.SelectedIndex].Cells[Rate.Index].Value = voucherDetail.Rate;
                    DgvProduct.Rows[SalesVoucherView.SelectedIndex].Cells[Qnty.Index].Value = voucherDetail.Qnty;
                    DgvProduct.Rows[SalesVoucherView.SelectedIndex].Cells[TotalPrice.Index].Value = voucherDetail.TotalPrice;
                }
                else
                {
                    DataGridViewRow dgvr = DgvProduct.Rows[DgvProduct.Rows.Add()];
                    dgvr.Cells[SalesDetailid.Index].Value = voucherDetail.SalesDetailid;
                    dgvr.Cells[Productid.Index].Value = voucherDetail.Productid;
                    dgvr.Cells[Productname.Index].Value = voucherDetail.Productname;
                    dgvr.Cells[Rate.Index].Value = voucherDetail.Rate;
                    dgvr.Cells[Qnty.Index].Value = voucherDetail.Qnty;
                    dgvr.Cells[TotalPrice.Index].Value = voucherDetail.TotalPrice;
                }

                ResetProductAdding();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbClientname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbClientname.SelectedIndex > 0)
            {
                SalesVoucherView.SelectedPerson = CmbClientname.SelectedItem as SearchCustomer;
                txtAddress.Text = SalesVoucherView.SelectedPerson.Address;
            }
        }

        private void CmbItemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbItemname.SelectedIndex > 0)
            {
                SalesVoucherView.SelectedProduct = CmbItemname.SelectedItem as SearchProduct;

                txtitemrate.Text = SalesVoucherView.SelectedProduct.ProductRate.ToString();
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                //Removed from code collection
                SalesVoucherDetail removeItem = SalesVoucherView.SalesVoucher.ProductDetails.Where(x => x.Productid == SalesVoucherView.Productid).FirstOrDefault();
                SalesVoucherView.SalesVoucher.ProductDetails.Remove(removeItem);

                //Removed from UI Gridview
                DgvProduct.Rows.RemoveAt(SalesVoucherView.SelectedIndex);

                SalesVoucherView.SalesVoucher.ProductCount = SalesVoucherView.SalesVoucher.ProductDetails.Count();
                SalesVoucherView.SalesVoucher.TotalAmount = SalesVoucherView.SalesVoucher.ProductDetails.Sum(x => x.TotalPrice);
                LblNoOfItems.Text = string.Format("No Of Items: {0}", SalesVoucherView.SalesVoucher.ProductCount);
                LblTotalAmount.Text = string.Format("Total Amount : {0}", SalesVoucherView.SalesVoucher.TotalAmount);

                ResetProductAdding();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
