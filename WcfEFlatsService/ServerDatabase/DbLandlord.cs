using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Transactions;
using System.Data;
using System.Data.SqlClient;
using ServerModel;

namespace ServerDatabase
{
    public class DbLandlord
    {
        public string AddLandlord(MdlLandlord mdlLandlordObj)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                conn.Open();
                return GetOutput(conn, mdlLandlordObj);
            }
        }


        public MdlLandlord GetLandlordData(string email)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("spGetLandlordData", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@Email", email);
                    DataSet ds = new DataSet();

                    da.Fill(ds, "Landlords"); //opens connection to DB/ executes command/ reads data/ fills Data set/ closing connection
                    DataRow dr = ds.Tables["Landlords"].Rows[0];
                    return GetFilledLandlordObj(dr);
                }
            }
            catch(Exception e)
            {
                MdlLandlord emptyObj = new MdlLandlord();
                Console.WriteLine("HERE");
                return emptyObj;
            }
        }

        public bool UpdateProfile(MdlLandlord mdlLandlordObj)
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
                        DataSet ds = GetLandlordDataSet(conn, mdlLandlordObj.Email);
                        DataRow dr = ds.Tables["Landlords"].Rows[0];
                        SqlDataAdapter da = new SqlDataAdapter("spGetLandlordData", conn);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@Email", mdlLandlordObj.Email);
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);

                        if (ds.Tables["Landlords"].Rows.Count == 0)
                            return false;

                        dr = UpdateDataRow(dr, mdlLandlordObj);
                        // Update returns number of updated rows
                        int update = da.Update(ds, "Landlords");

                        scope.Complete();
                        if (update > 0)
                            return true;
                        else
                            return false;
                    }
                }
                catch (Exception e)
                {
                    Transaction.Current.Rollback();
                    return false;
                }
                finally
                {
                    if (scope != null)
                        ((IDisposable)scope).Dispose();
                }
            }
        }

        private string GetOutput(SqlConnection conn, MdlLandlord mdlLandlordObj)
        {
            var option = new TransactionOptions();
            option.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
            option.Timeout = TimeSpan.FromSeconds(3);
            using (var scope = new TransactionScope(TransactionScopeOption.Required, option))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("spExecuteInsertLandlord", conn);

                    //set command type
                    cmd.CommandType = CommandType.StoredProcedure;
                    //input parameters
                    cmd.Parameters.AddWithValue("@EmailInput", mdlLandlordObj.Email);
                    cmd.Parameters.AddWithValue("@PasswordInput", mdlLandlordObj.Password);
                    cmd.Parameters.AddWithValue("@SaltInput", mdlLandlordObj.Salt);
                    cmd.Parameters.AddWithValue("@NameInput", mdlLandlordObj.Name);
                    cmd.Parameters.AddWithValue("@AddressInput", mdlLandlordObj.Address);
                    cmd.Parameters.AddWithValue("@PostCodeInput", mdlLandlordObj.PostCode);
                    cmd.Parameters.AddWithValue("@CityInput", mdlLandlordObj.City);
                    cmd.Parameters.AddWithValue("@CountryInput", mdlLandlordObj.Country);
                    cmd.Parameters.AddWithValue("@ContactPersonInput", mdlLandlordObj.ContactPerson);
                    cmd.Parameters.AddWithValue("@PhoneInput", mdlLandlordObj.Phone);
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
                    Console.WriteLine("An Error has accured. Registration Terminated. Err:" + e);
                    return "Error";
                }
                finally
                {
                    if (scope != null)
                        ((IDisposable)scope).Dispose();
                }
            }
        }

        public DataSet GetFlatsLandlord(string landlordEmail)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("spGetFlatsLandlord", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@LandlordEmail", landlordEmail);
                    DataSet ds = new DataSet();

                    da.Fill(ds, "Landlords"); //opens connection to DB/ executes command/ reads data/ fills Data set/ closing connection
                    return ds;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private static MdlLandlord GetFilledLandlordObj(DataRow dr)
        {
            MdlLandlord mdlLandlordObj = new MdlLandlord();

            mdlLandlordObj.Email = dr["Email"].ToString();
            mdlLandlordObj.Confirmed = (bool)dr["Confirmed"];
            mdlLandlordObj.DateOfCreation = Convert.ToDateTime(dr["DateOfCreation"]);
            mdlLandlordObj.Name = dr["Name"].ToString();
            mdlLandlordObj.Address = dr["Address"].ToString();
            mdlLandlordObj.PostCode = dr["PostCode"].ToString();
            mdlLandlordObj.City = dr["City"].ToString();
            mdlLandlordObj.Country = dr["Country"].ToString();
            mdlLandlordObj.ContactPerson = dr["ContactPerson"].ToString();
            mdlLandlordObj.Phone = dr["Phone"].ToString();

            return mdlLandlordObj;
        }

        private DataSet GetLandlordDataSet(SqlConnection conn, string email)
        {
            var option = new TransactionOptions();
            option.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
            option.Timeout = TimeSpan.FromSeconds(3);
            using (var scope = new TransactionScope(TransactionScopeOption.Required, option))
            {
                try
                {
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter("spGetLandlordData", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@Email", email);
                    da.Fill(ds, "Landlords");

                    scope.Complete();
                    return ds;
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

        private DataRow UpdateDataRow(DataRow dr, MdlLandlord mdlLandlordObj)
        {
            dr["Confirmed"] = mdlLandlordObj.Confirmed;
            dr["Name"] = mdlLandlordObj.Name;
            dr["Address"] = mdlLandlordObj.Address;
            dr["PostCode"] = mdlLandlordObj.PostCode;
            dr["City"] = mdlLandlordObj.City;
            dr["Country"] = mdlLandlordObj.Country;
            dr["ContactPerson"] = mdlLandlordObj.ContactPerson;
            dr["Phone"] = mdlLandlordObj.Phone;

            return dr;
        }
    }
}
