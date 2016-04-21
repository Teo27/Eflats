using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace ServerDatabase
{
    public class DbConfirmed
    {
        public bool ConfirmTenants(int flatId, string studentEmail)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                conn.Open();
                return GetOutput(conn, flatId, studentEmail);
            }
        }

        private bool GetOutput(SqlConnection conn, int flatId, string studentEmail)
        {
            var option = new TransactionOptions();
            option.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
            option.Timeout = TimeSpan.FromSeconds(3);
            using (var scope = new TransactionScope(TransactionScopeOption.Required, option))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("spConfirmTenants", conn);
                    //set command type
                    cmd.CommandType = CommandType.StoredProcedure;
                    //input parameters
                    cmd.Parameters.AddWithValue("@FlatId", flatId);
                    cmd.Parameters.AddWithValue("@StudentEmail", studentEmail);
                    //output parameters
                    SqlParameter outputParameter = new SqlParameter();
                    outputParameter.ParameterName = "@Output";
                    outputParameter.SqlDbType = SqlDbType.Bit;
                    outputParameter.Direction = ParameterDirection.Output;
                    outputParameter.Size = 0;
                    cmd.Parameters.Add(outputParameter);
                    //execute
                    cmd.ExecuteNonQuery();
                    scope.Complete();
                    return true;
                }
                catch (Exception e)
                {
                    Transaction.Current.Rollback();
                    Console.WriteLine("An Error has accured. Unable to Confirm tenant. Err:" + e);
                    return false;
                }
                finally
                {
                    if (scope != null)
                        ((IDisposable)scope).Dispose();
                }
            }
        }

        public DataSet GetConfirmedFlats(string landlordEmail)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("spGetConfirmedFlats", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@landlordEmail" , landlordEmail);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Confirmed"); //opens connection to DB/ executes command/ reads data/ fills Data set/ closing connection

                    return ds;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
