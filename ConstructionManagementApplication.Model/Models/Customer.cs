using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagementApplication.Model
{
    public class Customer
    {
        public int Customerid { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int IsActive { get; set; }
        public int Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public int Updatedby { get; set; }
        public DateTime Updatedon { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
