using ConstructionManagementApplication.Model.Models;
using System.Collections.Generic;

namespace ConstructionManagementApplication.Model.ViewModels
{
    public class ReceiptVoucherView
    {
        public static int Receiptid { get; set; }
        public static ReceiptVoucher ReceiptVoucher { get; set; }
        public static SearchCustomer Customer { get; set; }
        public static List<SearchCustomer> SearchCustomer { get; set; }
        public static bool IsModified { get; set; }
        public static bool IsSuccess { get; set; }
        public static string Message { get; set; }
    }
}
