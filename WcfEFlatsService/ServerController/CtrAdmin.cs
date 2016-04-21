using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using ServerDatabase;
using ServerModel;

namespace ServerController
{
    public class CtrAdmin : CtrHash
    {
        public int Login(string username, string password)
        {
            DbAdmin dbAdminObj = new DbAdmin();
            return dbAdminObj.Login(username, CreateHash(password.Trim(), dbAdminObj.GetSalt(username).Trim()));
            //return dbAdminObj.Login(username, password);
        }

        public DataSet GetTableData(string selectedTable)
        {
            DbAdminSelect dbAdminSelectObj = new DbAdminSelect();
            return dbAdminSelectObj.GetTableData(selectedTable);
        }

        public bool UpdateApplications(DataSet ds)
        {
            DbAdminUpdate dbAdminUpdate = new DbAdminUpdate();
            if (CheckDuplicateRows(ds, "FlatId", "StudentEmail"))
                return dbAdminUpdate.UpdateApplications(ds);
            else
                return false;
        }

        public bool UpdateFlats(DataSet ds)
        {
            DbAdminUpdate dbAdminUpdate = new DbAdminUpdate();
            return dbAdminUpdate.UpdateFlats(ds);

        }

        public bool UpdateStudents(DataSet ds)
        {
            DbAdminUpdate dbAdminUpdate = new DbAdminUpdate();
            ds = HashPassword(ds);
            ds = CalculateProfileScore(ds);
            return dbAdminUpdate.UpdateStudents(ds);
        }

        public bool UpdateLandlords(DataSet ds)
        {
            DbAdminUpdate dbAdminUpdate = new DbAdminUpdate();
            ds = HashPassword(ds);
            return dbAdminUpdate.UpdateLandlords(ds);
        }

        public bool UpdateAdmins(DataSet ds)
        {
            DbAdminUpdate dbAdminUpdate = new DbAdminUpdate();
            ds = HashPassword(ds);
            return dbAdminUpdate.UpdateAdmins(ds);
        }

        private DataSet HashPassword(DataSet ds)
        {
            try
            {
                ds.Tables[0].Columns["Password"].ReadOnly = false;
                ds.Tables[0].Columns["Salt"].ReadOnly = false;

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    if (row.RowState != DataRowState.Deleted)
                    {
                        if (row["Salt"].ToString().Trim().Equals("None"))
                        {
                            string password = row["Password"].ToString().Trim();
                            string salt = CreateSalt(10);
                            row["Password"] = CreateHash(password, salt);
                            row["Salt"] = salt;
                        }
                    }
                }
                ds.Tables[0].Columns["Password"].ReadOnly = true;
                ds.Tables[0].Columns["Salt"].ReadOnly = true;
                return ds;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }

        }

        private DataSet CalculateProfileScore(DataSet ds)
        {
            try
            {
                ds.Tables[0].Columns["Score"].ReadOnly = false;

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    row["Score"] = CtrStudent.CalculateProfileScore(GetMdlStudent(row)).Score;
                }

                ds.Tables[0].Columns["Score"].ReadOnly = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            return ds;
        }

        private MdlStudent GetMdlStudent(DataRow row)
        {
            MdlStudent mdlStudentObj = new MdlStudent();
            mdlStudentObj.NumberOfChildren = Convert.ToInt32(row["NumberOfChildren"]);
            mdlStudentObj.Disabled = Convert.ToBoolean(row["Disabled"]);
            mdlStudentObj.NumberOfCohabiters = Convert.ToInt32(row["NumberOfCohabitors"]);
            return mdlStudentObj;
        }

        private bool CheckDuplicateRows(DataSet ds, string colName, string colName2)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("FlatId");
            dt.Columns.Add("StudentEmail");

            DataRow newRow = dt.NewRow();
            newRow["FlatId"] = 0;
            newRow["StudentEmail"] = "null";
            dt.Rows.Add(newRow);

            foreach (DataRow drow in ds.Tables[0].Rows)
            {
                if (drow.RowState != DataRowState.Deleted)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (Convert.ToInt32(row["FlatId"]) == Convert.ToInt32(drow["FlatId"])
                            && row["StudentEmail"].ToString().Trim() == drow["StudentEmail"].ToString().Trim())
                            return false;
                    }

                    DataRow newRow2 = dt.NewRow();
                    newRow2["FlatId"] = drow["FlatId"];
                    newRow2["StudentEmail"] = drow["StudentEmail"];
                    dt.Rows.Add(newRow2);
                }
            }

            return true;
        }
    }
}

//private DataSet CalculateEmptyApplications(DataSet ds)
//{
//    CtrApplications ctrApplicationsObj = new CtrApplications();

//    //scores
//    foreach(DataRow row in ds.Tables[0].Rows)
//    {
//        if(String.IsNullOrEmpty((row["Id"]).ToString()))
//        {
//            int score = CalculateScore(row["StudentEmail"].ToString().Trim());
//            row["Score"] = score;
//            row["DateOfCreation"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
//        }
//    }
//-----------------------------------
//    DataTable dt = ds.Tables[0];
//    dt.DefaultView.Sort = "FlatId";
//    dt = dt.DefaultView.ToTable();

//    int flatId = Convert.ToInt32(ds.Tables[0].Rows[0]["FlatId"]);
//    int queueNumber = 1;

//    foreach (DataRow row in ds.Tables[0].Rows)
//    {
//        Console.WriteLine(flatId);
//        Console.WriteLine(Convert.ToInt32(row["FlatId"]));
//        if (flatId == Convert.ToInt32(row["FlatId"]))
//        {
//            row["QueueNumber"] = queueNumber;
//            queueNumber++;
//            Console.WriteLine(row["QueueNumber"].ToString());
//        }
//        else
//        {
//            flatId = Convert.ToInt32(row["FlatId"]);
//            queueNumber = 1;
//        }

//        //if (Convert.ToInt32(row["QueueNumber"]) == 0)
//        //    row["QueueNumber"] = 1;
//    }

//    return ds;
//}

//private DataSet SetReadOnly(DataSet ds)
//{
//    ds.Tables[0].Columns["Id"].ReadOnly = false; 
//    ds.Tables[0].Columns["DateOfCreation"].ReadOnly = false;
//    ds.Tables[0].Columns["Score"].ReadOnly = false;
//    ds.Tables[0].Columns["QueueNumber"].ReadOnly = false;

//    return ds;
//}

//private int CalculateScore(string email)
//{
//    CtrStudent ctrStudentObj = new CtrStudent();
//    MdlStudent mdlStudentObj = new MdlStudent();

//    mdlStudentObj = ctrStudentObj.GetStudentData(email);

//    int scoreDate = CtrApplications.CalculateScoreDate(DateTime.Now);
//    mdlStudentObj = CtrStudent.CalculateProfileScore(mdlStudentObj);

//    return CtrApplications.SumScores(scoreDate, mdlStudentObj.Score);
//}
