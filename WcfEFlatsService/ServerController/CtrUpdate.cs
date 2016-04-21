using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Transactions;
using System.Data;
using ServerModel;
using ServerDatabase;

namespace ServerController
{
    public class CtrUpdate
    {
        public static void Update()
        {            
            DateTime MyDateTime = DateTime.ParseExact("00:22", "HH:mm", null);
            DbFlat dbFlatObj = new DbFlat();

            Thread.Sleep(5000);
            Console.WriteLine("Update has started @ time: " + DateTime.Now.ToString());

            while (true)
            {
                if (DateTime.Now >= MyDateTime && DateTime.Now <= MyDateTime.AddSeconds(10)) //from x to x + 10sec
                //if(true)
                {
                    DateTime startTime;
                    DateTime finishTime;

                    startTime = DateTime.Now;
                    Console.WriteLine("START Time: " + startTime.ToString("hh.mm.ss.ffffff"));
                    Thread updateScoresThread = new Thread(() => UpdateScores(DbApplications.GetAllApplications()));
                    Thread updateQueueThread = new Thread(() => UpdateQueue(dbFlatObj.GetAllFlats()));

                    updateScoresThread.Start();
                    //update score
                    while (updateScoresThread.IsAlive)
                    {
                    }
                    updateQueueThread.Start();
                    while (updateQueueThread.IsAlive)
                    {
                    }

                    finishTime = DateTime.Now;
                    Console.WriteLine("FINISH Time: " + finishTime.ToString("hh.mm.ss.ffffff"));
                    TimeSpan totalTime = finishTime - startTime;
                    Console.WriteLine("TOTAL Time: " + totalTime);
                    Thread.Sleep(20000); //20
                }
                Thread.Sleep(2000); //2
            }
        }

        private static void UpdateQueue(DataSet ds)
        {
            Console.WriteLine("Update Queue has started...");
            try
            {
                foreach(DataRow drow in ds.Tables[0].Rows)
                {
                    if (UpdateQueueSingleFlat(Convert.ToInt32(drow["Id"])))
                        Console.WriteLine("Flat ID: " + Convert.ToInt32(drow["Id"]) + " succeeded");
                    else
                        Console.WriteLine("Flat ID: " + Convert.ToInt32(drow["Id"]) + " failed");
                }

                Console.WriteLine("Update queue complete.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Update Failed");
                Console.WriteLine("Error: " + e);
                
            }

        }

        public static bool UpdateQueueSingleFlat(int flatId)
        {
            var option = new TransactionOptions();
            option.IsolationLevel = System.Transactions.IsolationLevel.Serializable;
            option.Timeout = TimeSpan.FromSeconds(30);
            using (var scope = new TransactionScope(TransactionScopeOption.Required, option))
            {
                try
                {
                    DbApplications dbApplicationsObj = new DbApplications();
                    DataSet ds = dbApplicationsObj.GetApplicationsByFlat(flatId);
                    if (ds.Tables[0].Rows.Count == 0)
                        return false;

                    DataTable dt = ds.Tables[0];
                    dt.DefaultView.Sort = "Score Desc";
                    dt = dt.DefaultView.ToTable();
                    int queue = 1;

                    foreach (DataRow dr in dt.Rows)
                    {
                        dr["QueueNumber"] = queue;
                        Console.WriteLine("FID: " + dr["FlatId"].ToString().Trim() + " Score: " + dr["Score"] + " QN: " + dr["QueueNumber"].ToString().Trim());
                        queue++;
                    }

                    ds.Tables.Remove("Applications");
                    ds.Tables.Add(dt);

                    foreach(DataRow row in ds.Tables[0].Rows)
                    {
                        Console.WriteLine("Iterating sorted DataSet...");
                        Console.WriteLine("Flat ID: " + Convert.ToInt32(row["FlatId"]));
                        Console.WriteLine("Score: " + Convert.ToInt32(row["Score"]));
                        Console.WriteLine("Queue: " + Convert.ToInt32(row["QueueNumber"]));

                        if (!dbApplicationsObj.UpdateApplicationsByFlat(row))
                        {
                            Console.WriteLine("ROLLBACK");
                            Transaction.Current.Rollback();
                        }
                    }

                    Console.WriteLine("Flat updated!");
                    scope.Complete();
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unable to update flat - ERROR!");
                    Console.WriteLine(e);
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

        private static void UpdateScores(DataSet ds)
        {
            var option = new TransactionOptions();
            option.IsolationLevel = System.Transactions.IsolationLevel.Serializable;
            option.Timeout = TimeSpan.FromSeconds(30);
            using (var scope = new TransactionScope(TransactionScopeOption.Required, option))
            {
                try
                {
                    Parallel.ForEach(ds.Tables[0].AsEnumerable(), drow =>
                    {
                        CtrStudent ctrStudentObj = new CtrStudent();
                        string studentEmail = drow["StudentEmail"].ToString().Trim();
                        int profileScore = ctrStudentObj.GetStudentData(studentEmail).Score;
                        int dateScore = CtrApplications.CalculateScoreDate(Convert.ToDateTime(drow["DateOfCreation"]));

                        drow["Score"] = CtrApplications.SumScores(profileScore, dateScore);
                    });

                    //update table
                    if (DbApplications.UpdateAllApplicationScores(ds))
                        Console.WriteLine("Update Successful");
                    else
                    {
                        Console.WriteLine("Update Failed");
                        Transaction.Current.Rollback();
                    }
                    Console.WriteLine("Update score transactions complete.");
                    scope.Complete();
                }
                catch(Exception e)
                {
                    Console.WriteLine("Update score transactions rolled back.");
                    Console.WriteLine("Error: " + e);
                    Transaction.Current.Rollback();
                }
                finally
                {
                    if (scope != null)
                        ((IDisposable)scope).Dispose();
                    Thread.CurrentThread.Abort();
                }
            }
        }


    }
}
