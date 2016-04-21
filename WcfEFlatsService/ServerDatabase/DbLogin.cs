using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using System.Threading;
using ServerModel;

namespace ServerDatabase
{
    public class DbLogin
    {
        public string Login(string email, string password)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                conn.Open();
                return GetOutput(conn, email, password);
            }
        }

        private string GetOutput(SqlConnection conn, string email, string password)
        {
            var option = new TransactionOptions();
            option.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
            option.Timeout = TimeSpan.FromSeconds(3);
            using (var scope = new TransactionScope(TransactionScopeOption.Required, option))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("spCheckLoginInput", conn);
                    //set command type
                    cmd.CommandType = CommandType.StoredProcedure;
                    //input parameters
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    //output parameters
                    SqlParameter outputParameter = new SqlParameter();
                    outputParameter.ParameterName = "@MessageOutput";
                    outputParameter.SqlDbType = SqlDbType.Char;
                    outputParameter.Direction = ParameterDirection.Output;
                    outputParameter.Size = 100;
                    cmd.Parameters.Add(outputParameter);
                    //execute
                    cmd.ExecuteNonQuery();
                    scope.Complete();
                    return outputParameter.Value.ToString();
                }
                catch (Exception e)
                {
                    Transaction.Current.Rollback();
                    Console.WriteLine("An Error has accured. Login Terminated. Err:" + e);
                    return "An Error has accured. Login Terminated.";
                }
                finally
                {
                    if (scope != null)
                        ((IDisposable)scope).Dispose();
                }
            }
        }

        public string GetSalt(string email)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                //return output
                return GetOutputSalt(conn, email);
            }
        }

        private string GetOutputSalt(SqlConnection conn, string email)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("psGetUsersSalt", conn);
                //set command type
                cmd.CommandType = CommandType.StoredProcedure;
                //input parameters
                cmd.Parameters.AddWithValue("@Email", email.Trim());
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


    }


}
