using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagementApplication.Model.Models
{
    public class CustomrReport
    {
        public int Customerid { get; set; }
        public string CustomerName { get; set; }
        public double TotalAmount { get; set; }
        public double CollectionAmount { get; set; }
        public double OutStanding { get; set; }
    }
}
