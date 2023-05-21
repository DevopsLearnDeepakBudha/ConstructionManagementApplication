using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContructionDBLayer
{
    public class SqlOperations
    {
        public static DataSet ExecuteDataSet(SqlInfo SqlInfos)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlInfos.IsSuccess = true;
                using (SqlConnection con = new SqlConnection(SqlInfos.DBCS))
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = SqlInfos.Isprocedure ? CommandType.StoredProcedure : CommandType.Text;
                    if (SqlInfos.SqlParametersList != null && SqlInfos.SqlParametersList.Count > 0)
                    {
                        foreach (SqlParameter param in SqlInfos.SqlParametersList)
                            cmd.Parameters.Add(param);
                    }
                    cmd.CommandText = SqlInfos.Query;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(ds);
                    }
                }
            }
            catch (Exception ex)
            {
                SqlInfos.IsSuccess = false;
                SqlInfos.Message = ex.Message;
            }
            return ds;
        }
        public static DataTable ExecuteDataTable(SqlInfo SqlInfos)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlInfos.IsSuccess = true;
                using (SqlConnection con = new SqlConnection(SqlInfos.DBCS))
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = SqlInfos.Isprocedure ? CommandType.StoredProcedure : CommandType.Text;
                    if (SqlInfos.SqlParametersList != null && SqlInfos.SqlParametersList.Count > 0)
                    {
                        foreach (SqlParameter param in SqlInfos.SqlParametersList)
                            cmd.Parameters.Add(param);
                    }
                    cmd.CommandText = SqlInfos.Query;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                SqlInfos.IsSuccess = false;
                SqlInfos.Message = ex.Message;
            }
            return dt;
        }
        public static int ExecuteSqlInsert_Scalar(SqlInfo SqlInfos)
        {
            int result = 0;
            try
            {
                SqlInfos.IsSuccess = true;
                using (SqlConnection con = new SqlConnection(SqlInfos.DBCS))
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = SqlInfos.Isprocedure ? CommandType.StoredProcedure : CommandType.Text;
                    cmd.CommandText = SqlInfos.Query;

                    if (SqlInfos.SqlParametersList != null && SqlInfos.SqlParametersList.Count > 0)
                    {
                        foreach (SqlParameter param in SqlInfos.SqlParametersList)
                            cmd.Parameters.Add(param);
                    }

                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    var varResult = cmd.ExecuteScalar();
                    int.TryParse(varResult.ToString(), out result);
                }
            }
            catch (Exception ex)
            {
                SqlInfos.IsSuccess = false;
                SqlInfos.Message = ex.Message;
            }
            return result;
        }
        public static int ExecuteSqlNoQuery(SqlInfo SqlInfos)
        {
            int result = 0;
            try
            {
                SqlInfos.IsSuccess = true;
                using (SqlConnection con = new SqlConnection(SqlInfos.DBCS))
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = SqlInfos.Isprocedure ? CommandType.StoredProcedure : CommandType.Text;
                    cmd.CommandText = SqlInfos.Query;

                    if (SqlInfos.SqlParametersList != null && SqlInfos.SqlParametersList.Count > 0)
                    {
                        foreach (SqlParameter param in SqlInfos.SqlParametersList)
                            cmd.Parameters.Add(param);
                    }

                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                SqlInfos.IsSuccess = false;
                SqlInfos.Message = ex.Message;
            }
            return result;
        }
        public static void ExecuteReader_Upsert(SqlInfo SqlInfos, ref DataTable dt)
        {
            try
            {
                SqlInfos.IsSuccess = true;
                SqlInfos.Message = string.Empty;
                using (SqlConnection con = new SqlConnection(SqlInfos.DBCS))
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = SqlInfos.Isprocedure ? CommandType.StoredProcedure : CommandType.Text;
                    cmd.CommandText = SqlInfos.Query;

                    if (SqlInfos.SqlParametersList != null && SqlInfos.SqlParametersList.Count > 0)
                    {
                        foreach (SqlParameter param in SqlInfos.SqlParametersList)
                            cmd.Parameters.Add(param);
                    }

                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    dt.Load(cmd.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                SqlInfos.IsSuccess = false;
                SqlInfos.Message = ex.Message;
            }
        }
        public static void SqlBulkCopy_WriteToServer(SqlInfo SqlInfos, DataTable dt)
        {
            try
            {
                SqlInfos.IsSuccess = true;
                SqlInfos.Message = string.Empty;
                using (SqlConnection con = new SqlConnection(SqlInfos.DBCS))
                using (SqlBulkCopy copy = new SqlBulkCopy(con))
                {
                    copy.BulkCopyTimeout = SqlInfos.BulkCopyTimeout;
                    copy.DestinationTableName = SqlInfos.DestinationTableName;
                    copy.BatchSize = SqlInfos.BatchSize;

                    foreach (SqlInfo.BulkCopyColumn copyColumn in SqlInfos.BulkCopyColumnList)
                    {
                        copy.ColumnMappings.Add(copyColumn.SourceColumn, copyColumn.DestinationColumn);
                    }

                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    copy.WriteToServer(dt);
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                SqlInfos.IsSuccess = false;
                SqlInfos.Message = ex.Message;
            }
        }
    }

    public class SqlInfo
    {
        public string Query { get; set; }
        public string DBCS { get; set; }
        public bool Isprocedure { get; set; }
        public List<SqlParameter> SqlParametersList { get; set; }
        public int BulkCopyTimeout { get; set; }
        public string DestinationTableName { get; set; }
        public int BatchSize { get; set; }

        public class BulkCopyColumn
        {
            public string DestinationColumn { get; set; }
            public string SourceColumn { get; set; }
        }
        public IEnumerable<BulkCopyColumn> BulkCopyColumnList { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}
