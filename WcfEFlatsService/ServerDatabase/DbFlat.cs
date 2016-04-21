using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using System.Data;
using System.Data.SqlClient;
using ServerModel;

namespace ServerDatabase
{
    public class DbFlat
    {
        public string AddFlat(MdlFlat mdlFlatObj)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                conn.Open();
                return GetOutput(conn, mdlFlatObj);
            }
        }

        private string GetOutput(SqlConnection conn, MdlFlat mdlFlatObj)
        {
            var option = new TransactionOptions();
            option.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
            option.Timeout = TimeSpan.FromSeconds(3);
            using (var scope = new TransactionScope(TransactionScopeOption.Required, option))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("spInsertNewFlat", conn);
                    //set command type
                    cmd.CommandType = CommandType.StoredProcedure;
                    //input parameters
                    cmd.Parameters.AddWithValue("@LandlordEmail", mdlFlatObj.LandlordEmail.ToString());
                    cmd.Parameters.AddWithValue("@Type", mdlFlatObj.Type.ToString());
                    cmd.Parameters.AddWithValue("@Address", mdlFlatObj.Address.ToString());
                    cmd.Parameters.AddWithValue("@PostCode", mdlFlatObj.PostCode.ToString());
                    cmd.Parameters.AddWithValue("@City", mdlFlatObj.City.ToString());
                    cmd.Parameters.AddWithValue("@Rent", mdlFlatObj.Rent);
                    cmd.Parameters.AddWithValue("@Deposit", mdlFlatObj.Deposit);
                    cmd.Parameters.AddWithValue("@AvailableFrom", mdlFlatObj.AvailableFrom);
                    cmd.Parameters.AddWithValue("@Description", mdlFlatObj.Description.ToString());
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
                    Console.WriteLine("An Error has accured. Unable to Add new Flat. Err:" + e);
                    return "An Error has accured. Unable to Add new Flat.";
                }
                finally
                {
                    if (scope != null)
                        ((IDisposable)scope).Dispose();
                }
            }
        }

        public DataSet GetAllFlats()
        {
            var option = new TransactionOptions();
            option.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
            option.Timeout = TimeSpan.FromSeconds(3);
            using (var scope = new TransactionScope(TransactionScopeOption.Required, option))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                    {
                        SqlDataAdapter da = new SqlDataAdapter("spGetAllFlatsData", conn);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        DataSet ds = new DataSet();
                        da.Fill(ds); //opens connection to DB/ executes command/ reads data/ fills Data set/ closing connection

                        scope.Complete();
                        return ds;
                    }
                }
                catch(Exception e)
                {
                    Transaction.Current.Rollback();
                    Console.WriteLine("Error. Exception: " + e);
                    return null;
                }
                finally
                {
                    if (scope != null)
                        ((IDisposable)scope).Dispose();
                }
            }
        }

        public bool UpdateFlatsStatus(MdlFlat mdlFlatObj)
        {
            var option = new TransactionOptions();
            option.IsolationLevel = System.Transactions.IsolationLevel.Serializable;
            option.Timeout = TimeSpan.FromSeconds(3);
            using (var scope = new TransactionScope(TransactionScopeOption.Required, option))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("spUpdateFlat", conn);
                        //set command type
                        cmd.CommandType = CommandType.StoredProcedure;
                        //input parameters
                        cmd.Parameters.AddWithValue("@FlatId", mdlFlatObj.Id);
                        cmd.Parameters.AddWithValue("@Status", mdlFlatObj.Status.ToString());
                        cmd.Parameters.AddWithValue("@DateOfOffer", mdlFlatObj.DateOfOffer);
                        cmd.Parameters.AddWithValue("@AvailableFrom", mdlFlatObj.AvailableFrom.ToString());

                        //execute
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        scope.Complete();
                        return true;
                    }
                }
                catch (Exception e)
                {
                    Transaction.Current.Rollback();
                    Console.WriteLine("Error. Exception: " + e);
                    return false;
                }
                finally
                {
                    if (scope != null)
                        ((IDisposable)scope).Dispose();
                }
            }
        }

        public bool UpdateFlat(MdlFlat mdlFlatObj)
        {
            var option = new TransactionOptions();
            option.IsolationLevel = System.Transactions.IsolationLevel.Serializable;
            option.Timeout = TimeSpan.FromSeconds(3);
            using (var scope = new TransactionScope(TransactionScopeOption.Required, option))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("spUpdateFlatAttributes", conn);
                        //set command type
                        cmd.CommandType = CommandType.StoredProcedure;
                        //input parameters
                        cmd.Parameters.AddWithValue("@FlatId", mdlFlatObj.Id);
                        cmd.Parameters.AddWithValue("@Rent", mdlFlatObj.Rent);
                        cmd.Parameters.AddWithValue("@Deposit", mdlFlatObj.Deposit);
                        cmd.Parameters.AddWithValue("@Description", mdlFlatObj.Description);

                        //execute
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        scope.Complete();
                        return true;
                    }
                }
                catch (Exception e)
                {
                    Transaction.Current.Rollback();
                    Console.WriteLine("Error. Exception: " + e);
                    return false;
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
