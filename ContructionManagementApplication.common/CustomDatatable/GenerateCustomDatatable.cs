using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContructionManagementApplication.common.CustomDatatable
{
    public class GenerateCustomDatatable
    {
        public static DataTable GetSalesVoucherDetailDatatable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("SalesDetailid", typeof(int));
            dt.Columns.Add("Salesid", typeof(int));
            dt.Columns.Add("Productid", typeof(int));
            dt.Columns.Add("Rate", typeof(double));
            dt.Columns.Add("Qnty", typeof(int));
            dt.Columns.Add("TotalPrice", typeof(double));
            dt.Columns.Add("IsRemoved", typeof(int));
            dt.Columns.Add("IsAlter", typeof(int));
            return dt;
        }
    }
}
