using ConstructionManagementApplication.Model;
using ConstructionManagementApplication.Model.Enums;
using ConstructionManagementApplication.Model.Models;
using ConstructionManagementApplication.Model.ViewModels;
using ContructionDBLayer.IRepository;
using ContructionManagementApplication.common;
using ContructionManagementApplication.common.CustomDatatable;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContructionDBLayer.Repository
{
    public class VoucherRepository : IVoucherRepository
    {
        public SalesVoucher NewSalesVoucher()
        {
            SalesVoucher salesVoucher = new SalesVoucher();
            SalesVoucherView.IsSuccess = true;
            try
            {
                SqlInfo sqlInfo = new SqlInfo()
                {
                    DBCS = Constants.DBCS,
                    Isprocedure = true,
                    Query = Constants.UspSalesVoucher
                };

                sqlInfo.SqlParametersList = new List<SqlParameter>
                {
                    new SqlParameter("@flag",1),
                    new SqlParameter("@CreatedBy",User.UserId)
                };

                DataTable dt = SqlOperations.ExecuteDataTable(sqlInfo);
                if (sqlInfo.IsSuccess)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        salesVoucher.Salesid = HelperMethod.ConvertIntiger(dr["Salesid"].ToString().Trim());
                        salesVoucher.InvoiceNumber = dr["InvoiceNumber"].ToString().Trim();
                    }
                }
                else
                {
                    SalesVoucherView.IsSuccess = false;
                    SalesVoucherView.Message = sqlInfo.Message;
                }
            }
            catch (Exception ex)
            {
                SalesVoucherView.IsSuccess = false;
                SalesVoucherView.Message = ex.Message;
            }
            return salesVoucher;
        }

        public List<SearchCustomer> ChooseCustomer()
        {
            List<SearchCustomer> searchCustomer = new List<SearchCustomer>();

            try
            {
                SqlInfo sqlInfo = new SqlInfo()
                {
                    DBCS = Constants.DBCS,
                    Isprocedure = true,
                    Query = Constants.UspSalesVoucher
                };

                sqlInfo.SqlParametersList = new List<SqlParameter>
                {
                    new SqlParameter("@flag",2),
                    new SqlParameter("@CreatedBy",User.UserId)
                };

                DataTable dt = SqlOperations.ExecuteDataTable(sqlInfo);
                if (sqlInfo.IsSuccess)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        SearchCustomer customer = new SearchCustomer()
                        {
                            Customerid = HelperMethod.ConvertIntiger(dr["Customerid"].ToString().Trim()),
                            Fullname = dr["Fullname"].ToString().Trim().Trim(),
                            Mobile = dr["Mobile"].ToString().Trim().Trim(),
                            Email = dr["Email"].ToString().Trim().Trim(),
                            Address = dr["Address"].ToString().Trim().Trim()
                        };
                        searchCustomer.Add(customer);
                    }
                }
                else
                {
                    throw new Exception(sqlInfo.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return searchCustomer;
        }

        public DataSet LoadSalesVoucherData(int Customerid)
        {
            DataSet ds;
            try
            {
                SqlInfo sqlInfo = new SqlInfo()
                {
                    DBCS = Constants.DBCS,
                    Isprocedure = true,
                    Query = Constants.UspSalesVoucher
                };

                sqlInfo.SqlParametersList = new List<SqlParameter>
                {
                    new SqlParameter("@flag",5),
                    new SqlParameter("@Customerid",Customerid)
                };

                ds = SqlOperations.ExecuteDataSet(sqlInfo);
                if (!sqlInfo.IsSuccess)
                {
                    throw new Exception(sqlInfo.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ds;
        }

        public List<SearchProduct> ChooseProduct()
        {
            List<SearchProduct> searchProduct = new List<SearchProduct>();

            try
            {
                SqlInfo sqlInfo = new SqlInfo()
                {
                    DBCS = Constants.DBCS,
                    Isprocedure = true,
                    Query = Constants.UspSalesVoucher
                };

                sqlInfo.SqlParametersList = new List<SqlParameter>
                {
                    new SqlParameter("@flag",3),
                    new SqlParameter("@CreatedBy",User.UserId)
                };

                DataTable dt = SqlOperations.ExecuteDataTable(sqlInfo);
                if (sqlInfo.IsSuccess)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        SearchProduct product = new SearchProduct()
                        {

                            Productid = HelperMethod.ConvertIntiger(dr["Productid"].ToString().Trim()),
                            ProductName = dr["ProductName"].ToString().Trim(),
                            ProductRate = HelperMethod.ConvertDouble(dr["ProductRate"].ToString().Trim())

                        };
                        searchProduct.Add(product);
                    }
                }
                else
                {
                    throw new Exception(sqlInfo.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return searchProduct;
        }

        public void SaveReceiptVoucher()
        {
            try
            {
                SqlInfo sqlInfo = new SqlInfo()
                {
                    DBCS = Constants.DBCS,
                    Isprocedure = true,
                    Query = Constants.UspSalesVoucher
                };

                sqlInfo.SqlParametersList = new List<SqlParameter>
                {
                    new SqlParameter("@flag",7),
                    new SqlParameter("@Receiptid",ReceiptVoucherView.ReceiptVoucher.Receiptid),
                    new SqlParameter("@CustomerId",ReceiptVoucherView.ReceiptVoucher.CustomerId),
                    new SqlParameter("@InvoiceDate",ReceiptVoucherView.ReceiptVoucher.CollectionDate.ToString("yyyyMMdd")),
                    new SqlParameter("@ReceiptAmount",ReceiptVoucherView.ReceiptVoucher.ReceiptAmount),
                    new SqlParameter("@CreatedBy",User.UserId)
                };

                DataTable dataTable = SqlOperations.ExecuteDataTable(sqlInfo);
                if (sqlInfo.IsSuccess)
                {
                    ReceiptVoucherView.IsSuccess = true;
                    ReceiptVoucherView.Message = "SUCCESS";
                }
                else
                {
                    ReceiptVoucherView.IsSuccess = false;
                    ReceiptVoucherView.Message = sqlInfo.Message;
                }
            }
            catch (Exception ex)
            {
                ReceiptVoucherView.IsSuccess = false;
                ReceiptVoucherView.Message = ex.Message;
            }
        }

        public void SaveSalesVoucher(SalesVoucher salesVoucher)
        {
            try
            {
                SalesVoucherView.IsSuccess = true;
                DataTable tbl_salesdetail_type = GenerateCustomDatatable.GetSalesVoucherDetailDatatable();
                foreach (SalesVoucherDetail item in SalesVoucherView.SalesVoucher.ProductDetails)
                {
                    DataRow row = tbl_salesdetail_type.NewRow();
                    row["SalesDetailid"] = item.SalesDetailid;
                    row["Salesid"] = item.Salesid;
                    row["Productid"] = item.Productid;
                    row["Rate"] = item.Rate;
                    row["Qnty"] = item.Qnty;
                    row["TotalPrice"] = item.TotalPrice;
                    row["IsRemoved"] = 0;
                    row["IsAlter"] = 0;
                    tbl_salesdetail_type.Rows.Add(row);
                }

                SqlInfo sqlInfo = new SqlInfo()
                {
                    DBCS = Constants.DBCS,
                    Isprocedure = true,
                    Query = Constants.UspSalesVoucher
                };

                sqlInfo.SqlParametersList = new List<SqlParameter>
                {
                    new SqlParameter("@flag",4),
                    new SqlParameter("@InvoiceDate",salesVoucher.InvoiceDate.ToString("yyyyMMdd")),
                    new SqlParameter("@Customerid",salesVoucher.Customerid),
                    new SqlParameter("@CustomerName",salesVoucher.CustomerName),
                    new SqlParameter("@ProductCount",salesVoucher.ProductCount),
                    new SqlParameter("@TotalAmount",salesVoucher.TotalAmount),
                    new SqlParameter("@ReceiptAmount",salesVoucher.ReceiptAmount),
                    new SqlParameter("@StatusId",(int)salesVoucher.StatusEnum),
                    new SqlParameter("@Status",salesVoucher.StatusEnum.ToString()),
                    new SqlParameter("@Salesid",salesVoucher.Salesid),
                    new SqlParameter("@tbl_salesdetail_type",tbl_salesdetail_type)
                };

                DataTable dataTable = SqlOperations.ExecuteDataTable(sqlInfo);
                if (sqlInfo.IsSuccess)
                {
                    //SalesVoucherDetail item in 
                    SalesVoucherView.SalesVoucher.ProductDetails.Clear();
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        SalesVoucherDetail item = new SalesVoucherDetail()
                        {
                            SalesDetailid = HelperMethod.ConvertIntiger(dr["SalesDetailid"].ToString().Trim()),
                            Salesid = HelperMethod.ConvertIntiger(dr["Salesid"].ToString().Trim()),
                            Productid = HelperMethod.ConvertIntiger(dr["Productid"].ToString().Trim()),
                            Productname = dr["Productname"].ToString().Trim(),
                            Rate = HelperMethod.ConvertDouble(dr["Rate"].ToString().Trim()),
                            Qnty = HelperMethod.ConvertIntiger(dr["Qnty"].ToString().Trim()),
                            TotalPrice = HelperMethod.ConvertDouble(dr["TotalPrice"].ToString().Trim())
                        };
                        SalesVoucherView.SalesVoucher.ProductDetails.Add(item);
                    }
                    SalesVoucherView.Message = "SUCCESS";
                }
                else
                {
                    SalesVoucherView.IsSuccess = false;
                    SalesVoucherView.Message = sqlInfo.Message;
                }
            }
            catch (Exception ex)
            {
                SalesVoucherView.IsSuccess = false;
                SalesVoucherView.Message = ex.Message;
            }
        }

        public SalesVoucher GetSalesVoucher(int salesId)
        {
            SalesVoucher salesVoucher = new SalesVoucher();
            SalesVoucherView.IsSuccess = true;
            try
            {
                SqlInfo sqlInfo = new SqlInfo()
                {
                    DBCS = Constants.DBCS,
                    Isprocedure = true,
                    Query = Constants.UspSalesVoucher
                };

                sqlInfo.SqlParametersList = new List<SqlParameter>
                {
                    new SqlParameter("@flag",6),
                    new SqlParameter("@Salesid",salesId)
                };

                DataSet ds = SqlOperations.ExecuteDataSet(sqlInfo);
                if (sqlInfo.IsSuccess)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        salesVoucher.Salesid = salesId;
                        salesVoucher.InvoiceNumber = dr["InvoiceNumber"].ToString().Trim().Trim();
                        salesVoucher.InvoiceDate = HelperMethod.ConvertDateTime(dr["InvoiceDate"].ToString().Trim().Trim());
                        salesVoucher.Customerid = HelperMethod.ConvertIntiger(dr["Customerid"].ToString().Trim());
                        salesVoucher.CustomerName = dr["CustomerName"].ToString().Trim().Trim();
                        salesVoucher.ProductCount = HelperMethod.ConvertIntiger(dr["ProductCount"].ToString().Trim());
                        salesVoucher.TotalAmount = HelperMethod.ConvertDouble(dr["TotalAmount"].ToString().Trim());
                        salesVoucher.StatusEnum = (Status)HelperMethod.ConvertIntiger(dr["StatusId"].ToString().Trim());
                        salesVoucher.CreatedOn = HelperMethod.ConvertDateTime(dr["CreatedOn"].ToString().Trim());
                    }
                    List<SalesVoucherDetail> list = new List<SalesVoucherDetail>();
                    foreach (DataRow dr in ds.Tables[1].Rows)
                    {
                        SalesVoucherDetail salesVoucherDetail = new SalesVoucherDetail
                        {
                            SalesDetailid = HelperMethod.ConvertIntiger(dr["SalesDetailid"].ToString().Trim()),
                            Salesid = salesId,
                            Productid = HelperMethod.ConvertIntiger(dr["Productid"].ToString().Trim()),
                            Productname = dr["Productname"].ToString().Trim(),
                            Rate = HelperMethod.ConvertDouble(dr["Rate"].ToString().Trim()),
                            Qnty = HelperMethod.ConvertIntiger(dr["Qnty"].ToString().Trim()),
                            TotalPrice = HelperMethod.ConvertDouble(dr["TotalPrice"].ToString().Trim())
                        };
                        list.Add(salesVoucherDetail);
                    }
                    salesVoucher.ProductDetails = list;
                }
                else
                {
                    SalesVoucherView.IsSuccess = sqlInfo.IsSuccess;
                    SalesVoucherView.Message = sqlInfo.Message;
                }
            }
            catch (Exception ex)
            {
                SalesVoucherView.IsSuccess = false;
                SalesVoucherView.Message = ex.Message;
            }
            return salesVoucher;
        }

        public ReceiptVoucher GetReceiptVoucher()
        {
            ReceiptVoucher receipt = new ReceiptVoucher();

            try
            {
                SqlInfo sqlInfo = new SqlInfo()
                {
                    DBCS = Constants.DBCS,
                    Isprocedure = true,
                    Query = Constants.UspSalesVoucher
                };

                sqlInfo.SqlParametersList = new List<SqlParameter>
                {
                    new SqlParameter("@flag",8),
                    new SqlParameter("@Receiptid",ReceiptVoucherView.Receiptid)
                };

                DataTable DT = SqlOperations.ExecuteDataTable(sqlInfo);
                if (sqlInfo.IsSuccess)
                {
                    foreach (DataRow dr in DT.Rows)
                    {
                        receipt.Receiptid = ReceiptVoucherView.Receiptid;
                        receipt.CustomerId = HelperMethod.ConvertIntiger(dr["CustomerId"].ToString().Trim().Trim());
                        receipt.CollectionDate = HelperMethod.ConvertDateTime(dr["CollectionDate"].ToString().Trim());
                        receipt.ReceiptAmount = HelperMethod.ConvertDouble(dr["ReceiptAmount"].ToString().Trim().Trim());
                        receipt.Createdby = HelperMethod.ConvertIntiger(dr["Createdby"].ToString().Trim());
                        receipt.Createdon = HelperMethod.ConvertDateTime(dr["Createdon"].ToString().Trim());
                    }
                    ReceiptVoucherView.IsSuccess = sqlInfo.IsSuccess;
                    ReceiptVoucherView.Message = sqlInfo.Message;
                }
                else
                {
                    ReceiptVoucherView.IsSuccess = sqlInfo.IsSuccess;
                    ReceiptVoucherView.Message = sqlInfo.Message;
                }
            }
            catch (Exception ex)
            {
                ReceiptVoucherView.IsSuccess = false;
                ReceiptVoucherView.Message = ex.Message;
            }
            return receipt;
        }
    }
}
