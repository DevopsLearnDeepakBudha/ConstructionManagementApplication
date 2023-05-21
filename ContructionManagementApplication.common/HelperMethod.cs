using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContructionManagementApplication.common
{
    public class HelperMethod
    {
        public static int ConvertIntiger(string value)
        {
            int.TryParse(value, out int result);
            return result;
        }
        public static double ConvertDouble(string value)
        {
            double.TryParse(value, out double result);
            return result;
        }
        public static bool ConvertBool(string value)
        {
            bool.TryParse(value, out bool result);
            return result;
        }
        public static DateTime ConvertDateTime(string value)
        {
            DateTime.TryParse(value, out DateTime result);
            return result;
        }
    }
}
