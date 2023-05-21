using System;

namespace ConstructionManagementApplication.Model
{
    public class SalesVoucherDetail
    {
        public int SalesDetailid { get; set; }
        public int Salesid { get; set; }
        public int Productid { get; set; }
        public string Productname { get; set; }
        public double Rate { get; set; }
        public double Qnty { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Updatedon { get; set; }
    }
}
