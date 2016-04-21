using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Data.SqlClient;
using ServerModel;
using ServerController;
using ServerDatabase;

namespace UnitTests
{
    [TestClass]
    public class FlatTestes
    {
        [TestMethod]
        public void AddFlat()
        {
            CtrLandlord ctrLandlordObj = new CtrLandlord();
            MdlFlat mdlFlatObj = GenerateFlatObj();
            string expected = "Successfully added.";
            string actual;

            actual = ctrLandlordObj.AddFlat(mdlFlatObj.LandlordEmail, mdlFlatObj.Type, mdlFlatObj.Address,
                mdlFlatObj.PostCode, mdlFlatObj.City, mdlFlatObj.Rent, mdlFlatObj.Deposit, mdlFlatObj.AvailableFrom, mdlFlatObj.Description).Trim();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddFlatNonExistingLandlord()
        {
            CtrLandlord ctrLandlordObj = new CtrLandlord();
            MdlFlat mdlFlatObj = GenerateFlatObj();
            mdlFlatObj.LandlordEmail = "defaultLandlordNonExisting@default.com";
            string expected = "Unable to add flat due to nonexisting landlord email.";
            string actual;

            actual = ctrLandlordObj.AddFlat(mdlFlatObj.LandlordEmail, mdlFlatObj.Type, mdlFlatObj.Address,
                mdlFlatObj.PostCode, mdlFlatObj.City, mdlFlatObj.Rent, mdlFlatObj.Deposit, mdlFlatObj.AvailableFrom, mdlFlatObj.Description).Trim();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddFlatStudentEmail()
        {
            CtrLandlord ctrLandlordObj = new CtrLandlord();
            MdlFlat mdlFlatObj = GenerateFlatObj();
            mdlFlatObj.LandlordEmail = "defaultStudent@default.com";
            string expected = "Unable to add flat due to nonexisting landlord email.";
            string actual;

            actual = ctrLandlordObj.AddFlat(mdlFlatObj.LandlordEmail, mdlFlatObj.Type, mdlFlatObj.Address,
                mdlFlatObj.PostCode, mdlFlatObj.City, mdlFlatObj.Rent, mdlFlatObj.Deposit, mdlFlatObj.AvailableFrom, mdlFlatObj.Description).Trim();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAllFlats()
        {
            CtrGetData ctrGetDataObj = new CtrGetData();
            DataSet ds = ctrGetDataObj.GetAllFlats();
            Assert.IsNotNull(ds);
        }

        [TestMethod]
        //simulate Landlord pressing send offer to applicant
        public void UpdateFlatsStatusSendOffer()
        {
            CtrFlat ctrFlatObj = new CtrFlat();
            MdlFlat mdlFlatObj = GenerateFlatObj();
            mdlFlatObj.Id = GetFlatId(mdlFlatObj);
            mdlFlatObj.Status = "Pending";
            mdlFlatObj.DateOfOffer = "None";
            mdlFlatObj.AvailableFrom = "";

            bool actual = ctrFlatObj.UpdateFlatStatus(mdlFlatObj.Id, 
                mdlFlatObj.Status, mdlFlatObj.DateOfOffer, mdlFlatObj.AvailableFrom);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //simulate Student pressing accept offer
        public void UpdateFlatsStatusAcceptOffer()
        {
            CtrFlat ctrFlatObj = new CtrFlat();
            MdlFlat mdlFlatObj = GenerateFlatObj();
            mdlFlatObj.Id = GetFlatId(mdlFlatObj);
            mdlFlatObj.Status = "Closed";
            mdlFlatObj.DateOfOffer = "None";
            mdlFlatObj.AvailableFrom = "Not available";

            bool actual = ctrFlatObj.UpdateFlatStatus(mdlFlatObj.Id,
                mdlFlatObj.Status, mdlFlatObj.DateOfOffer, mdlFlatObj.AvailableFrom);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        //simulate Student pressing deny offer
        public void UpdateFlatsStatusDenyOffer()
        {
            CtrFlat ctrFlatObj = new CtrFlat();
            MdlFlat mdlFlatObj = GenerateFlatObj();
            mdlFlatObj.Id = GetFlatId(mdlFlatObj);
            mdlFlatObj.Status = "Pending";
            mdlFlatObj.DateOfOffer = "None";
            mdlFlatObj.AvailableFrom = "";

            bool actual = ctrFlatObj.UpdateFlatStatus(mdlFlatObj.Id,
                mdlFlatObj.Status, mdlFlatObj.DateOfOffer, mdlFlatObj.AvailableFrom);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateFlatsAttributes()
        {
            CtrFlat ctrFlatObj = new CtrFlat();
            MdlFlat mdlFlatObj = GenerateFlatObj();
            mdlFlatObj.Id = GetFlatId(mdlFlatObj);
            mdlFlatObj.Rent = 2500;
            mdlFlatObj.Deposit = 6000;
            mdlFlatObj.Description = "Changed desription.";

            bool actual = ctrFlatObj.UpdateFlat(mdlFlatObj.Id, mdlFlatObj.Rent, mdlFlatObj.Deposit, mdlFlatObj.Description);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateFlatsAttributesWithNullValues()
        {
            CtrFlat ctrFlatObj = new CtrFlat();
            MdlFlat mdlFlatObj = GenerateFlatObj();
            mdlFlatObj.Id = GetFlatId(mdlFlatObj);
            mdlFlatObj.Rent = 0;
            mdlFlatObj.Deposit = 0;
            mdlFlatObj.Description = "";

            bool actual = ctrFlatObj.UpdateFlat(mdlFlatObj.Id, mdlFlatObj.Rent, mdlFlatObj.Deposit, mdlFlatObj.Description);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        public MdlFlat GenerateFlatObj()
        {
            MdlFlat mdlFlatObj = new MdlFlat();

            mdlFlatObj.LandlordEmail = "defaultLandlord@default.com";
            mdlFlatObj.Type = "type";
            mdlFlatObj.Address = "address";
            mdlFlatObj.PostCode = "postCode";
            mdlFlatObj.City = "city";
            mdlFlatObj.Rent = 100;
            mdlFlatObj.Deposit = 100;
            mdlFlatObj.AvailableFrom = DateTime.Now.AddDays(50).ToString();
            mdlFlatObj.Description = "description";
            mdlFlatObj.Status = "Closed";
            mdlFlatObj.DateOfOffer = "None";

            return mdlFlatObj;
        }

        public int GetFlatId(MdlFlat mdlFlatObj)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select Id from flats where LandlordEmail = '" + mdlFlatObj.LandlordEmail + "'" , conn);
                using (SqlDataReader sr = cmd.ExecuteReader())
                {
                    while (sr.Read())
                    {
                        return Convert.ToInt32(sr.GetValue(0));
                    }
                }
            }

            return 0;
        }
    }
}
