using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using System.Collections;

namespace ServerDatabase
{
    public class DbGetData
    {
        public string GetUserType(string email)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                //return output
                return GetOutput(conn, email);
            }
        }

        private string GetOutput(SqlConnection conn, string email)
        {
            var option = new TransactionOptions();
            option.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
            option.Timeout = TimeSpan.FromSeconds(3);
            using (var scope = new TransactionScope(TransactionScopeOption.Required, option))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("spGetUserType", conn);
                    //set command type
                    cmd.CommandType = CommandType.StoredProcedure;
                    //input parameters
                    cmd.Parameters.AddWithValue("@Email", email);
                    //output parameters
                    SqlParameter outputParameter = new SqlParameter();
                    outputParameter.ParameterName = "@MessageOutput";
                    outputParameter.SqlDbType = SqlDbType.Char;
                    outputParameter.Direction = ParameterDirection.Output;
                    outputParameter.Size = 100;
                    cmd.Parameters.Add(outputParameter);
                    //execute
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    scope.Complete();
                    return outputParameter.Value.ToString();
                }
                catch (Exception e)
                {
                    Transaction.Current.Rollback();
                    Console.WriteLine("An Error has accured. Get type Terminated. Err:" + e);
                    return "Error";
                }
                finally
                {
                    if (scope != null)
                        ((IDisposable)scope).Dispose();
                }
            }
        }
    }
}
