using ConstructionManagementApplication.Model;
using ContructionDBLayer.IAdmim;
using ContructionManagementApplication.common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ContructionDBLayer.AdminRepository
{
    public class MasterRepository : IMasterRepository
    {
        public void UserLoginValidate()
        {
            try
            {
                SqlInfo sqlInfo = new SqlInfo()
                {
                    DBCS = Constants.DBCS,
                    Isprocedure = true,
                    Query = Constants.UspAccount
                };

                List<SqlParameter> paramList = new List<SqlParameter>
                {
                    new SqlParameter("@username",User.UserName),
                    new SqlParameter("@password",User.Password)
                };

                sqlInfo.SqlParametersList = paramList;

                DataSet ds = SqlOperations.ExecuteDataSet(sqlInfo);
                if (sqlInfo.IsSuccess)
                {
                    if (ds != null && ds.Tables.Count > 1)
                    {
                        User.IsSuccess = true;
                        User.Message = ds.Tables[0].Rows[0]["LoginSuccess"].ToString().Trim();
                        foreach (DataRow dr in ds.Tables[1].Rows)
                        {
                            User.UserId = Convert.ToInt32(dr["Userid"]);
                            User.FirstName = dr["FirstName"].ToString().Trim();
                            User.MiddleName = dr["MiddleName"].ToString().Trim();
                            User.LastName = dr["LastName"].ToString().Trim();
                            User.CreatedOn = Convert.ToDateTime(dr["Createdon"]);
                        }
                    }
                    else if (ds != null && ds.Tables.Count > 0)
                    {
                        User.IsSuccess = false;
                        User.Message = ds.Tables[0].Rows[0]["LoginSuccess"].ToString().Trim();
                    }
                    else
                    {
                        User.IsSuccess = false;
                        User.Message = "Login Failed";
                    }
                }
                else
                {
                    User.IsSuccess = false;
                    User.Message = sqlInfo.Message;
                }
            }
            catch (Exception ex)
            {
                User.IsSuccess = false;
                User.Message = ex.Message;
            }
        }
        public Customer CreateCustomer(Customer customer)
        {
            try
            {
                SqlInfo sqlInfo = new SqlInfo()
                {
                    DBCS = Constants.DBCS,
                    Isprocedure = true,
                    Query = Constants.UspCustomer
                };

                List<SqlParameter> paramList = new List<SqlParameter>
                {
                    new SqlParameter("@FirstName",customer.FirstName),
                    new SqlParameter("@MiddleName",customer.MiddleName),
                    new SqlParameter("@LastName",customer.LastName),
                    new SqlParameter("@Mobile",customer.Mobile),
                    new SqlParameter("@Email",customer.Email),
                    new SqlParameter("@Address",customer.Address),
                    new SqlParameter("@Isactive",customer.IsActive),
                    new SqlParameter("@Createdby",customer.Createdby),
                    new SqlParameter("@Updatedby",customer.Updatedby)
                };

                sqlInfo.SqlParametersList = paramList;
                if (customer.Customerid > 0)
                {
                    sqlInfo.SqlParametersList.Add(new SqlParameter("@flag", 2));
                    sqlInfo.SqlParametersList.Add(new SqlParameter("@Customerid", customer.Customerid));
                    SqlOperations.ExecuteSqlNoQuery(sqlInfo);
                }
                else
                {
                    sqlInfo.SqlParametersList.Add(new SqlParameter("@flag", 1));
                    customer.Customerid = SqlOperations.ExecuteSqlInsert_Scalar(sqlInfo);
                }

                if (sqlInfo.IsSuccess)
                {
                    customer.Message = "Data Saved Successfully.";
                    customer.IsSuccess = true;
                }
                else
                {
                    customer.IsSuccess = false;
                    customer.Message = sqlInfo.Message;
                }
            }
            catch (Exception ex)
            {
                customer.IsSuccess = false;
                customer.Message = ex.Message;
            }
            return customer;
        }
        public List<Customer> GetCustomer()
        {
            List<Customer> customerList = new List<Customer>();
            try
            {
                SqlInfo sqlInfo = new SqlInfo()
                {
                    DBCS = Constants.DBCS,
                    Isprocedure = true,
                    Query = Constants.UspCustomer
                };

                sqlInfo.SqlParametersList = new List<SqlParameter>
                {
                    new SqlParameter("@flag",3)
                };

                DataTable dt = SqlOperations.ExecuteDataTable(sqlInfo);
                if (sqlInfo.IsSuccess)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Customer customer = new Customer();

                        customer.Customerid = HelperMethod.ConvertIntiger(dr["Customerid"].ToString().Trim());
                        customer.FirstName = dr["FirstName"].ToString().Trim();
                        customer.MiddleName = dr["MiddleName"].ToString().Trim();
                        customer.LastName = dr["LastName"].ToString().Trim();
                        customer.Mobile = dr["Mobile"].ToString().Trim();
                        customer.Email = dr["Email"].ToString().Trim();
                        customer.Address = dr["Address"].ToString().Trim();
                        customer.IsActive = HelperMethod.ConvertBool(dr["IsActive"].ToString().Trim()) ? 1 : 0;
                        customer.Createdby = HelperMethod.ConvertIntiger(dr["CreatedBy"].ToString().Trim());
                        customer.Createdon = HelperMethod.ConvertDateTime(dr["Createdon"].ToString().Trim());
                        customer.Updatedby = HelperMethod.ConvertIntiger(dr["Updatedby"].ToString().Trim());
                        customer.Updatedon = HelperMethod.ConvertDateTime(dr["Updatedon"].ToString().Trim());

                        customerList.Add(customer);
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
            return customerList;
        }
        public Product CreateProduct(Product product)
        {
            try
            {
                SqlInfo sqlInfo = new SqlInfo()
                {
                    DBCS = Constants.DBCS,
                    Isprocedure = true,
                    Query = Constants.UspProduct
                };

                List<SqlParameter> paramList = new List<SqlParameter>
                {
                    new SqlParameter("@ProductName",product.ProductName),
                    new SqlParameter("@Unitid",product.Unitid),
                    new SqlParameter("@UnitCode",product.UnitCode),
                    new SqlParameter("@OpenQnty",product.OpenQnty),
                    new SqlParameter("@BalQnty",product.BalQnty),
                    new SqlParameter("@ProductRate",product.ProductRate),
                    new SqlParameter("@ProductDescription",product.ProductDescription),
                    new SqlParameter("@IsActive",product.IsActive),
                    new SqlParameter("@Createdby",product.Createdby)
                };

                sqlInfo.SqlParametersList = paramList;
                if (product.Productid > 0)
                {
                    sqlInfo.SqlParametersList.Add(new SqlParameter("@flag", 2));
                    sqlInfo.SqlParametersList.Add(new SqlParameter("@Productid", product.Productid));
                    sqlInfo.SqlParametersList.Add(new SqlParameter("@Updatedby", product.Updatedby));
                    sqlInfo.SqlParametersList.Add(new SqlParameter("@Updatedon", product.Updatedon));
                    SqlOperations.ExecuteSqlNoQuery(sqlInfo);
                }
                else
                {
                    sqlInfo.SqlParametersList.Add(new SqlParameter("@flag", 1));
                    product.Productid = SqlOperations.ExecuteSqlInsert_Scalar(sqlInfo);
                }

                if (sqlInfo.IsSuccess)
                {
                    product.Message = "Data Saved Successfully.";
                    product.IsSuccess = true;
                }
                else
                {
                    product.IsSuccess = false;
                    product.Message = sqlInfo.Message;
                }
            }
            catch (Exception ex)
            {
                product.IsSuccess = false;
                product.Message = ex.Message;
            }
            return product;
        }
        public List<Product> GetProduct()
        {
            List<Product> productList = new List<Product>();
            try
            {
                SqlInfo sqlInfo = new SqlInfo()
                {
                    DBCS = Constants.DBCS,
                    Isprocedure = true,
                    Query = Constants.UspProduct
                };

                sqlInfo.SqlParametersList = new List<SqlParameter>
                {
                    new SqlParameter("@flag",3)
                };

                DataTable dt = SqlOperations.ExecuteDataTable(sqlInfo);
                if (sqlInfo.IsSuccess) 
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Product product = new Product();

                        product.Productid = HelperMethod.ConvertIntiger(dr["Productid"].ToString().Trim());
                        product.ProductName = dr["ProductName"].ToString().Trim();
                        product.Unitid = HelperMethod.ConvertIntiger(dr["Unitid"].ToString().Trim());
                        product.UnitCode = dr["UnitCode"].ToString().Trim();
                        product.OpenQnty = HelperMethod.ConvertIntiger(dr["OpenQnty"].ToString().Trim());
                        product.BalQnty = HelperMethod.ConvertIntiger(dr["BalQnty"].ToString().Trim());
                        product.ProductRate = HelperMethod.ConvertDouble(dr["ProductRate"].ToString().Trim());
                        product.ProductDescription = dr["ProductDescription"].ToString().Trim();
                        product.IsActive = HelperMethod.ConvertBool(dr["IsActive"].ToString().Trim()) ? 1 : 0;
                        product.Createdby = HelperMethod.ConvertIntiger(dr["CreatedBy"].ToString().Trim());
                        product.Createdon = HelperMethod.ConvertDateTime(dr["Createdon"].ToString().Trim());
                        product.Updatedby = HelperMethod.ConvertIntiger(dr["Updatedby"].ToString().Trim());
                        product.Updatedon = HelperMethod.ConvertDateTime(dr["Updatedon"].ToString().Trim());

                        productList.Add(product);
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
            return productList;
        }
        public List<Units> GetUnit()
        {
            List<Units> unitList = new List<Units>();
            try
            {
                SqlInfo sqlInfo = new SqlInfo()
                {
                    DBCS = Constants.DBCS,
                    Isprocedure = true,
                    Query = Constants.UspProduct
                };

                sqlInfo.SqlParametersList = new List<SqlParameter>
                {
                    new SqlParameter("@flag",4)
                };

                DataTable dt = SqlOperations.ExecuteDataTable(sqlInfo);
                if (sqlInfo.IsSuccess)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Units unit = new Units();

                        unit.Unitid = HelperMethod.ConvertIntiger(dr["unitid"].ToString().Trim());
                        unit.UnitName = dr["unitname"].ToString().Trim();
                        unit.UnitCode = dr["unitcode"].ToString().Trim();
                         
                        unitList.Add(unit);
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
            return unitList;
        }
    }
}
