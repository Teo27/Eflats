using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using ServerController;
using ServerModel;

namespace UnitTests
{
    [TestClass]
    public class ConfirmedTests
    {
        [TestMethod]
        public void ConfirmTenants()
        {
            CtrConfirmed ctrConfirmedObj = new CtrConfirmed();
            FlatTestes flatTestsObj = new FlatTestes();
            CtrFlat ctrFlatObj = new CtrFlat();

            MdlFlat mdlFlatObj = flatTestsObj.GenerateFlatObj();
            mdlFlatObj.Id = flatTestsObj.GetFlatId(mdlFlatObj);
            mdlFlatObj.DateOfOffer = "None";

            CtrLandlord ctrLandlordObj = new CtrLandlord();
            string output = ctrLandlordObj.AddFlat(mdlFlatObj.LandlordEmail, mdlFlatObj.Type, mdlFlatObj.Address,
                mdlFlatObj.PostCode, mdlFlatObj.City, mdlFlatObj.Rent, mdlFlatObj.Deposit, mdlFlatObj.AvailableFrom, mdlFlatObj.Description).Trim();

            bool expected = true;
            bool actual = ctrConfirmedObj.ConfirmTenants(mdlFlatObj.Id, "defaultStudent@default.com");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetConfirmedFlats()
        {
            CtrConfirmed ctrConfirmedObj = new CtrConfirmed();
            DataSet ds = ctrConfirmedObj.GetConfirmedFlats("defaultLandlord@default.com");

            string expected = "defaultStudent@default.com";
            string actual = ds.Tables["Confirmed"].Rows[0]["StudentEmail"].ToString().Trim();

            Assert.AreEqual(expected, actual);
        }
    }
}
