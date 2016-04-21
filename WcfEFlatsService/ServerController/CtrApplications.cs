using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ServerModel;

namespace ServerController
{
    public class CtrApplications
    {
        public static int CalculateScoreDate(DateTime date)
        {
            if (date == DateTime.Now)
                return 0;
            return Convert.ToInt32(((DateTime.Now - date).TotalDays)-1)*24;
        }

        public static int SumScores(int scoreDate, int profileScore)
        {
            return scoreDate + profileScore;
        }

        public DataSet UpdateDataSet(DataSet ds, MdlApplication mdlApplicationObj)
        {
            mdlApplicationObj = InitializeScoreQueue(mdlApplicationObj);
            ds.Tables[0].TableName = "Applications";

            //add new application (row) to the dataset         
            ds.Tables[0].Rows.Add(CreateNewDataRow(ds, mdlApplicationObj));
            DataTable dt = ds.Tables[0];


            //udate dataset            //sort from highest score
            dt.DefaultView.Sort = "Score desc";
            dt = dt.DefaultView.ToTable();

            //update queue in all rows
            int queue = 1;
            foreach (DataRow row in dt.Rows)
            {
                row["QueueNumber"] = queue;
                queue++;
            }
            if (ds.Tables.Count > 0)          
                ds.Tables.Remove("Applications");

            ds.Tables.Add(dt);
            return ds;
        }

        public DataSet UpdateDataSetToRemove(DataSet ds, MdlApplication mdlApplicationObj)
        {
            DataTable dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                string columnValue = row["StudentEmail"].ToString().Trim();
                if (columnValue.Equals(mdlApplicationObj.StudentEmail))
                {
                    row.Delete();
                }
            }

            //sort from highest score
            dt.DefaultView.Sort = "Score desc";
            dt = dt.DefaultView.ToTable();

            //update queue in all rows
            int queue = 1;
            foreach (DataRow row in dt.Rows)
            {
                row["QueueNumber"] = queue;
                queue++;
            }

            if (ds.Tables.Count > 0)
                ds.Tables.Remove("Applications");

            ds.Tables.Add(dt);
            return ds;
        }

        private DataRow CreateNewDataRow(DataSet ds, MdlApplication mdlApplicationObj)
        {
            DataRow currentApplication = ds.Tables[0].NewRow();
            currentApplication["StudentEmail"] = mdlApplicationObj.StudentEmail;
            currentApplication["FlatId"] = mdlApplicationObj.FlatId;
            currentApplication["DateOfCreation"] = mdlApplicationObj.DateOfCreation;
            currentApplication["Score"] = mdlApplicationObj.Score;
            currentApplication["QueueNumber"] = -1;
            return currentApplication;
        }

        private MdlApplication InitializeScoreQueue(MdlApplication mdlApplicationObj)
        {
            //update score score = profileScore + dateScpre (appObj.score holds profile score at this point) 
            mdlApplicationObj.DateOfCreation = DateTime.Now;
            mdlApplicationObj.Score = SumScores(CalculateScoreDate(mdlApplicationObj.DateOfCreation), mdlApplicationObj.Score);
            return mdlApplicationObj;
        }
    }
}
