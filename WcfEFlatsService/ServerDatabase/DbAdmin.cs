using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using System.Threading;

namespace ServerDatabase
{
    public class DbAdmin
    {
        public string GetSalt(string email)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                return GetOutputSalt(conn, email);
            }
        }

        private string GetOutputSalt(SqlConnection conn, string email)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("psGetAdminsSalt", conn);
                //set command type
                cmd.CommandType = CommandType.StoredProcedure;
                //input parameters
                cmd.Parameters.AddWithValue("@Username", email.Trim());
                //output parameters
                SqlParameter outputParameter = new SqlParameter();
                outputParameter.ParameterName = "@Salt";
                outputParameter.SqlDbType = SqlDbType.Char;
                outputParameter.Direction = ParameterDirection.Output;
                outputParameter.Size = 50;
                cmd.Parameters.Add(outputParameter);
                //execute
                conn.Open();
                cmd.ExecuteNonQuery();
                return outputParameter.Value.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("An Error has accured. Login Terminated. Err:" + e);
                return "An Error has accured. Login Terminated.";
            }
        }


        public int Login(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                conn.Open();
                return GetOutputLogin(conn, username, password);
            }
        }

        private int GetOutputLogin(SqlConnection conn, string username, string password)
        {
            var option = new TransactionOptions();
            option.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
            option.Timeout = TimeSpan.FromSeconds(3);
            using (var scope = new TransactionScope(TransactionScopeOption.Required, option))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("spCheckAdminLoginInput", conn);
                    //set command type
                    cmd.CommandType = CommandType.StoredProcedure;
                    //input parameters
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    //output parameters
                    SqlParameter outputParameter = new SqlParameter();
                    outputParameter.ParameterName = "@MessageOutput";
                    outputParameter.SqlDbType = SqlDbType.Int;
                    outputParameter.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputParameter);
                    //execute
                    cmd.ExecuteNonQuery();
                    //Console.WriteLine("FINISH THREAD ID: " + Thread.CurrentThread.ManagedThreadId.ToString());
                    scope.Complete();
                    return Convert.ToInt32(outputParameter.Value);
                }
                catch (Exception e)
                {
                    Transaction.Current.Rollback();
                    Console.WriteLine("An Error has accured. Login Terminated. Err:" + e);
                    return 3;
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
