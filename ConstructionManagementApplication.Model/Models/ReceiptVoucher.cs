using System;

namespace ConstructionManagementApplication.Model.Models
{
    public class ReceiptVoucher
    {
        public int Receiptid { get; set; }
        public int CustomerId { get; set; }
        public DateTime CollectionDate { get; set; }
        public double ReceiptAmount { get; set; }
        public int Createdby { get; set; }
        public DateTime Createdon { get; set; }
    }
}
