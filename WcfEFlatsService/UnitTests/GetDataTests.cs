using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using ServerModel;
using ServerController;
using ServerDatabase;

namespace UnitTests
{
    [TestClass]
    public class GetDataTests
    {
        [TestMethod]
        public void GetUserTypeStudent()
        {
            CtrGetData ctrGetDataObj = new CtrGetData();
            string expected = "Student";
            string actual = ctrGetDataObj.GetUserType("defaultStudent@default.com").Trim();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetUserTypeLandlord()
        {
            CtrGetData ctrGetDataObj = new CtrGetData();
            string expected = "Landlord";
            string actual = ctrGetDataObj.GetUserType("defaultLandlord@default.com").Trim();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetUserTypeNonExisting()
        {
            CtrGetData ctrGetDataObj = new CtrGetData();
            string expected = "User type not found";
            string actual = ctrGetDataObj.GetUserType("defaultLandlordNonExisting@default.com").Trim();

            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void GetAllApplications()
        //{
        //    DataSet ds = DbApplications.GetAllApplications();
        //    Console.WriteLine();
        //}
    }
}
