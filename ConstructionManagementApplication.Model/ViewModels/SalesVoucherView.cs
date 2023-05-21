using System.Collections.Generic;

namespace ConstructionManagementApplication.Model.ViewModels
{
    public class SalesVoucherView
    {
        public static int Customerid { get; set; }
        public static int SalesId { get; set; }
        public static int Productid { get; set; }
        public static int SelectedIndex { get; set; }
        public static SalesVoucher SalesVoucher { get; set; }
        public static SearchCustomer SelectedPerson { get; set; }
        public static SearchProduct SelectedProduct { get; set; }
        public static List<SearchCustomer> SearchCustomer { get; set; }
        public static List<SearchProduct> SearchProduct { get; set; }
        public static bool IsModified { get; set; }
        public static bool IsSuccess { get; set; }
        public static string Message { get; set; }
    }
}
