using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagementApplication.Model
{
    public class Product
    {
        public int Productid { get; set; }
        public string ProductName { get; set; }
        public int Unitid { get; set; }
        public string UnitCode { get; set; }
        public int OpenQnty { get; set; }
        public int BalQnty { get; set; }
        public double ProductRate { get; set; }
        public string ProductDescription { get; set; }
        public int IsActive { get; set; }
        public int Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public int Updatedby { get; set; }
        public DateTime Updatedon { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
