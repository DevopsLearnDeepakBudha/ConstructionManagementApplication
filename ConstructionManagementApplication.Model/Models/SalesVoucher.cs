using ConstructionManagementApplication.Model.Enums;
using System;
using System.Collections.Generic;

namespace ConstructionManagementApplication.Model
{
    public class SalesVoucher
    {
        public int Salesid { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int Customerid { get; set; }
        public string CustomerName { get; set; }
        public int ProductCount { get; set; }
        public double TotalAmount { get; set; }
        public double ReceiptAmount { get; set; }
        public Status StatusEnum { get; set; }
        public int IsCancel { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<SalesVoucherDetail> ProductDetails { get; set; }
    }
}
