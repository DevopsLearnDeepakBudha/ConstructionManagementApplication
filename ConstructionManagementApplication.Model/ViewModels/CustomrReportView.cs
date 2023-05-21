using ConstructionManagementApplication.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagementApplication.Model.ViewModels
{
    public class CustomrReportView
    {
        public List<CustomrReport> CustomrReportList { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}
