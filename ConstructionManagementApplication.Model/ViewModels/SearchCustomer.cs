using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagementApplication.Model.ViewModels
{
    public class SearchCustomer
    {
        public int Customerid { get; set; }
        public string Fullname { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
