using ConstructionManagementApplication.Model;
using ConstructionManagementApplication.Model.Models;
using ConstructionManagementApplication.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContructionDBLayer.IRepository
{
    interface IVoucherRepository
    {
        DataSet LoadSalesVoucherData(int Customerid);
        SalesVoucher NewSalesVoucher();
        void SaveSalesVoucher(SalesVoucher salesVoucher);
        List<SearchCustomer> ChooseCustomer();
        List<SearchProduct> ChooseProduct();
        SalesVoucher GetSalesVoucher(int salesId);
        void SaveReceiptVoucher();
        ReceiptVoucher GetReceiptVoucher();
    }
}
