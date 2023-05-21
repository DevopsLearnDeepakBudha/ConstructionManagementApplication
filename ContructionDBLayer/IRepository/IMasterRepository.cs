using ConstructionManagementApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContructionDBLayer.IAdmim
{
    public interface IMasterRepository
    {
        void UserLoginValidate();
        Customer CreateCustomer(Customer customer);
        List<Customer> GetCustomer();
        Product CreateProduct(Product customer);
        List<Product> GetProduct();
    }
}
