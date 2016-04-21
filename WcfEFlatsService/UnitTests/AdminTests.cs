using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerController;
using System.Data;

namespace UnitTests
{
    [TestClass]
    public class AdminTests
    {
        [TestMethod]
        public void AdminLogin()
        {
            CtrAdmin ctrAdminObj = new CtrAdmin();
            DataSet ds = GetAdminDataSet("admin3", "admin3");
            ctrAdminObj.UpdateAdmins(ds);

            int expected = 1;
            int actual = ctrAdminObj.Login("admin3", "admin3");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdminUpdateAdmins()
        {
            CtrAdmin ctrAdminObj = new CtrAdmin();

            DataSet ds = GetAdminDataSet("admin2", "admin2");

            bool actual = ctrAdminObj.UpdateAdmins(ds);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdminUpdateStudents()
        {
            CtrAdmin ctrAdminObj = new CtrAdmin();

            DataSet ds = ctrAdminObj.GetTableData("Students");
            DataRow dr = ds.Tables[0].NewRow();
            dr = AddStudentRow(dr);
            ds.Tables[0].Rows.Add(dr);

            bool actual = ctrAdminObj.UpdateStudents(ds);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdminUpdateLandlords()
        {
            CtrAdmin ctrAdminObj = new CtrAdmin();

            DataSet ds = ctrAdminObj.GetTableData("Landlords");
            DataRow dr = ds.Tables[0].NewRow();
            dr = AddLandlordRow(dr);
            ds.Tables[0].Rows.Add(dr);

            bool actual = ctrAdminObj.UpdateLandlords(ds);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdminUpdateFlats()
        {
            CtrAdmin ctrAdminObj = new CtrAdmin();

            DataSet ds = ctrAdminObj.GetTableData("Flats");
            ds.Tables[0].Rows[0]["Description"] = "This is changed descrition...";

            bool actual = ctrAdminObj.UpdateFlats(ds);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdminAddApplication()
        {
            CtrAdmin ctrAdminObj = new CtrAdmin();
            DataSet ds = ctrAdminObj.GetTableData("Applications");

            DataRow dr = ds.Tables[0].NewRow();
            dr["StudentEmail"] = "a@a.com";
            dr["FlatId"] = 75;
            ds.Tables[0].Rows.Add(dr);

            ctrAdminObj.UpdateApplications(ds);
        }

        [TestMethod]
        public void AdminUpdateDublicate()
        {
            CtrAdmin ctrAdminObj = new CtrAdmin();
            DataSet ds = ctrAdminObj.GetTableData("Applications");

            DataRow dr = ds.Tables[0].NewRow();
            dr["StudentEmail"] = "a@a.com";
            dr["FlatId"] = 76;

            ds.Tables[0].Rows.Add(dr);

            ctrAdminObj.UpdateApplications(ds);
        }

        private DataSet GetAdminDataSet(string username, string password)
        {
            CtrAdmin ctrAdminObj = new CtrAdmin();

            DataSet ds = ctrAdminObj.GetTableData("Admins");
            DataRow dr = ds.Tables[0].NewRow();
            dr["Username"] = username;
            dr["Password"] = password;
            dr["Salt"] = "None";
            ds.Tables[0].Rows.Add(dr);

            return ds;
        }

        private DataRow AddStudentRow(DataRow dr)
        {
            dr["Email"] = "student";
            dr["Password"] = "student";
            dr["Salt"] = "None";
            dr["ConfirmationCode"] = "None";
            dr["Confirmed"] = true;
            dr["Student"] = true;
            dr["Score"] = 0;
            dr["NumberOfChildren"] = 0;
            dr["Pet"] = true;
            dr["NumberOfCohabitors"] = 0;
            dr["Disabled"] = false;
            dr["DateOfCreation"] = DateTime.Now;
            dr["Name"] = "name";
            dr["Surname"] = "surname";
            dr["Address"] = "address";
            dr["PostCode"] = "postcode";
            dr["City"] = "city";
            dr["Country"] = "country";
            dr["Phone"] = "phone";

            return dr;
        }

        private DataRow AddLandlordRow(DataRow dr)
        {
            dr["Email"] = "landlord";
            dr["Password"] = "landlords";
            dr["Salt"] = "None";
            dr["Confirmed"] = true;
            dr["DateOfCreation"] = DateTime.Now;
            dr["Name"] = "name";
            dr["ContactPerson"] = "contact_person";
            dr["Address"] = "address";
            dr["PostCode"] = "postcode";
            dr["City"] = "city";
            dr["Country"] = "country";
            dr["Phone"] = "phone";

            return dr;
        }
    }
}
