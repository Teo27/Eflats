using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
using System.Transactions;
using System.Data;
using System.Data.SqlClient;
using ServerModel;

namespace ServerDatabase
{
    public class DbStudent
    {
        public string AddStudent(MdlStudent mdlStudentObj)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                conn.Open();
                return GetOutput(conn, mdlStudentObj);
            }
        }

        private string GetOutput(SqlConnection conn, MdlStudent mdlStudentObj)
        {
            var option = new TransactionOptions();
            option.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
            option.Timeout = TimeSpan.FromSeconds(3);
            using (var scope = new TransactionScope(TransactionScopeOption.Required, option))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("spExecuteInsertStudent", conn);
                    //set command type
                    cmd.CommandType = CommandType.StoredProcedure;
                    //input parameters
                    cmd.Parameters.AddWithValue("@EmailInput", mdlStudentObj.Email);
                    cmd.Parameters.AddWithValue("@PasswordInput", mdlStudentObj.Password);
                    cmd.Parameters.AddWithValue("@SaltInput", mdlStudentObj.Salt);
                    cmd.Parameters.AddWithValue("@NameInput", mdlStudentObj.Name);
                    cmd.Parameters.AddWithValue("@SurnameInput", mdlStudentObj.Surname);
                    cmd.Parameters.AddWithValue("@AddressInput", mdlStudentObj.Address);
                    cmd.Parameters.AddWithValue("@PostCodeInput", mdlStudentObj.PostCode);
                    cmd.Parameters.AddWithValue("@CityInput", mdlStudentObj.City);
                    cmd.Parameters.AddWithValue("@CountryInput", mdlStudentObj.Country);
                    cmd.Parameters.AddWithValue("@PhoneInput", mdlStudentObj.Phone);
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

        public MdlStudent GetStudentData(string value, string type = "email")
        {
            if (type == "code")
                type = "@ConfirmationCode";
            else
                type = "@Email";

            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("spGetStudentData", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue(type, value);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Students"); //opens connection to DB/ executes command/ reads data/ fills Data set/ closing connection

                    DataRow dr = ds.Tables["Students"].Rows[0];
                    return GetFilledStudentObj(dr);
                }
            }
            catch (Exception e)
            {
                MdlStudent emptyObject = new MdlStudent();
                return emptyObject;
            }
        }

        private static MdlStudent GetFilledStudentObj(DataRow dr)
        {
            MdlStudent mdlStudentObj = new MdlStudent();

            mdlStudentObj.Email = dr["Email"].ToString();
            mdlStudentObj.Confirmed = (bool)dr["Confirmed"];
            mdlStudentObj.Student = (bool)dr["Student"];
            mdlStudentObj.Score = (int)dr["Score"];
            mdlStudentObj.NumberOfChildren = (int)dr["NumberOfChildren"];
            mdlStudentObj.Pet = (bool)dr["Pet"];
            mdlStudentObj.NumberOfCohabiters = (int)dr["NumberOfCohabitors"];
            mdlStudentObj.Disabled = (bool)dr["Disabled"];
            mdlStudentObj.DateOfCreation = Convert.ToDateTime(dr["DateOfCreation"]);
            mdlStudentObj.Name = dr["Name"].ToString();
            mdlStudentObj.Surname = dr["Surname"].ToString();
            mdlStudentObj.Address = dr["Address"].ToString();
            mdlStudentObj.PostCode = dr["PostCode"].ToString();
            mdlStudentObj.City = dr["City"].ToString();
            mdlStudentObj.Country = dr["Country"].ToString();
            mdlStudentObj.Phone = dr["Phone"].ToString();

            return mdlStudentObj;
        }

        public bool UpdateProfile(MdlStudent mdlStudentObj)
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
                        DataSet ds = GetStudentDataSet(conn, mdlStudentObj.Email);
                        DataRow dr = ds.Tables["Students"].Rows[0];
                        SqlDataAdapter da = new SqlDataAdapter("spGetStudentData", conn);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@Email", mdlStudentObj.Email);
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);

                        if (ds.Tables["Students"].Rows.Count == 0)
                            return false;

                        dr = UpdateDataRow(dr, mdlStudentObj);
                        // Update returns number of updated rows
                        int update = da.Update(ds, "Students");
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

        public DataSet GetWishlistData(string studentEmail)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                var option = new TransactionOptions();
                option.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
                option.Timeout = TimeSpan.FromSeconds(3);
                using (var scope = new TransactionScope(TransactionScopeOption.Required, option))
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter("psGetWishListTableStudent", conn);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@StudentEmail", studentEmail);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Wishlist"); //opens connection to DB/ executes command/ reads data/ fills Data set/ closing connection

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
        }

        private DataSet GetStudentDataSet(SqlConnection conn, string email)
        {

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("spGetStudentData", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Email", email);

            da.Fill(ds, "Students");
            return ds;
        }

        private DataRow UpdateDataRow(DataRow dr, MdlStudent mdlStudentObj)
        {
            dr["Confirmed"] = mdlStudentObj.Confirmed;
            dr["Student"] = mdlStudentObj.Student;
            dr["Score"] = mdlStudentObj.Score;
            dr["NumberOfChildren"] = mdlStudentObj.NumberOfChildren;
            dr["Pet"] = mdlStudentObj.Pet;
            dr["NumberOfCohabitors"] = mdlStudentObj.NumberOfCohabiters;
            dr["Disabled"] = mdlStudentObj.Disabled;
            dr["Name"] = mdlStudentObj.Name;
            dr["Surname"] = mdlStudentObj.Surname;
            dr["Address"] = mdlStudentObj.Address;
            dr["PostCode"] = mdlStudentObj.PostCode;
            dr["City"] = mdlStudentObj.City;
            dr["Country"] = mdlStudentObj.Country;
            dr["Phone"] = mdlStudentObj.Phone;

            return dr;
        }


    }
}
