using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Transactions;
using System.Data.SqlClient;

namespace ServerDatabase
{
    public class DbAdminSelect
    {
        public DataSet GetTableData(string selectedTable)
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
                        SqlDataAdapter da = new SqlDataAdapter("spGetTableData", conn);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@SelectedTable", selectedTable);
                        DataSet ds = new DataSet();
                        da.Fill(ds); //opens connection to DB/ executes command/ reads data/ fills Data set/ closing connection

                        scope.Complete();
                        return ds;
                    }
                }
                catch (Exception e)
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
    
}
