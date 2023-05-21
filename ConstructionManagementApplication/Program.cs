using ContructionManagementApplication.common.NepaliCalendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructionManagementApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Test();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }


        public static void Test()
        {
            int i = 0;
            int sum = 0;
            while (i < 100)
            {
                sum = sum + 1;
                sum = i + sum;
                i += 1;
            }
            Console.Write(sum);
        }

    }
}
