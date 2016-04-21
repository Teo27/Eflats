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
    public class DbApplications
    {
        public DataSet GetApplicationsDataSet(string studentEmail, int flatId)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("spGetApplications", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //input parameters
                    da.SelectCommand.Parameters.AddWithValue("@StudentEmail", studentEmail);
                    da.SelectCommand.Parameters.AddWithValue("@FlatId", flatId);
                    da.Fill(ds, "Applications"); //opens connection to DB/ executes command/ reads data/ fills Data set/ closing connection
                }
                return ds;
            }
            catch(Exception e)
            {
                return null;
            }

        }

        private MdlApplication UpdateModelObj(DataSet ds, MdlApplication mdlApplicationObj)
        {
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row["StudentEmail"].Equals(mdlApplicationObj.StudentEmail))
                {
                    mdlApplicationObj.Score = (int)row["Score"];
                    mdlApplicationObj.QueueNumber = (int)row["QueueNumber"];
                }
            }
            return mdlApplicationObj;
        }

        public DataSet GetApplicationsDataSetRomove(string studentEmail, int flatId)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("spGetApplicationsToRemove", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //input parameters
                    da.SelectCommand.Parameters.AddWithValue("@StudentEmail", studentEmail);
                    da.SelectCommand.Parameters.AddWithValue("@FlatId", flatId);
                    da.Fill(ds, "Applications"); //opens connection to DB/ executes command/ reads data/ fills Data set/ closing connection
                }
                return ds;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public bool UpdateApplications(DataSet ds, MdlApplication mdlApplicationObj)
        {
            var option = new TransactionOptions();
            option.IsolationLevel = System.Transactions.IsolationLevel.Serializable;
            option.Timeout = TimeSpan.FromSeconds(30);
            using (var scope = new TransactionScope(TransactionScopeOption.Required, option))
            {
                try
                {
                    if (!RemoveApplications(mdlApplicationObj))
                        return false;

                    using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                    {
                        ds.Tables[0].TableName = "Applications";
                        SqlDataAdapter da = new SqlDataAdapter("spGetApplications", conn);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@StudentEmail", mdlApplicationObj.StudentEmail);
                        da.SelectCommand.Parameters.AddWithValue("@FlatId", mdlApplicationObj.FlatId);

                        SqlCommandBuilder builder = new SqlCommandBuilder(da);
                        int updates = da.Update(ds, "Applications");

                        scope.Complete();
                        return true;
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

        private bool RemoveApplications(MdlApplication mdlApplicationObj)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spRemoveBufferedApplications", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FlatId", mdlApplicationObj.FlatId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An Error has accured. remove from Wishlist Terminated. Err:" + e);
                return false;
            }
        }

        public static DataSet GetAllApplications()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter("spGetAllApplications", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(ds);
                    return ds;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An Error has accured. remove from Wishlist Terminated. Err:" + e);
                return null;
            }
        }

        public static bool UpdateAllApplicationScores(DataSet ds)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    ds.Tables[0].TableName = "Applications";
                    SqlDataAdapter da = new SqlDataAdapter("spGetAllApplications", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    SqlCommandBuilder builder = new SqlCommandBuilder(da);

                    if (da.Update(ds, "Applications") > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public DataSet GetApplicationsByFlat(int flatId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter("select * from Applications where FlatId = @FlatId", conn);
                    da.SelectCommand.Parameters.AddWithValue("@FlatId", flatId);
                    da.Fill(ds, "Applications");
                    return ds;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool UpdateApplicationsByFlat(DataRow row)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("spUpdateApplication", conn);
                    //set command type
                    cmd.CommandType = CommandType.StoredProcedure;
                    //input parameters
                    cmd.Parameters.AddWithValue("@QueueNumber", Convert.ToInt32(row["QueueNumber"]));
                    cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(row["Id"]));

                    //execute
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                Transaction.Current.Rollback();
                Console.WriteLine("An Error has accured. Registration Terminated. Err:" + e);
                return false;
            }
        }
    }
}
