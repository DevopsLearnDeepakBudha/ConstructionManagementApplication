using ConstructionManagementApplication.Model.Models;
using ConstructionManagementApplication.Model.ViewModels;
using ContructionDBLayer.IRepository;
using ContructionManagementApplication.common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ContructionDBLayer.Repository
{
    public class ReportRepository : IReportRepository
    {
        public CustomrReportView LoadCustomerReport()
        {
            CustomrReportView ViewCustomrReport = new CustomrReportView()
            {
                IsSuccess = true,
            };
            try
            {
                SqlInfo sqlInfo = new SqlInfo()
                {
                    DBCS = Constants.DBCS,
                    Isprocedure = true,
                    Query = Constants.UspReport
                };

                sqlInfo.SqlParametersList = new List<SqlParameter>
                {
                    new SqlParameter("@flag",1)
                };


                DataTable dt = SqlOperations.ExecuteDataTable(sqlInfo);
                if (sqlInfo.IsSuccess)
                {
                    List<CustomrReport> customrReportList = new List<CustomrReport>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        CustomrReport customrReport = new CustomrReport
                        {
                            Customerid = HelperMethod.ConvertIntiger(dr["Customerid"].ToString()),
                            CustomerName = dr["CustomerName"].ToString(),
                            TotalAmount = HelperMethod.ConvertDouble(dr["TotalAmount"].ToString()),
                            CollectionAmount = HelperMethod.ConvertDouble(dr["CollectionAmount"].ToString()),
                            OutStanding = HelperMethod.ConvertDouble(dr["OutStanding"].ToString())
                        };
                        customrReportList.Add(customrReport);
                    }
                    ViewCustomrReport.CustomrReportList = customrReportList;
                }
                else
                {
                    ViewCustomrReport.IsSuccess = false;
                    ViewCustomrReport.Message = sqlInfo.Message;
                }
            }
            catch (Exception ex)
            {
                ViewCustomrReport.IsSuccess = false;
                ViewCustomrReport.Message = ex.Message;
            }
            return ViewCustomrReport;
        }
    }
}
