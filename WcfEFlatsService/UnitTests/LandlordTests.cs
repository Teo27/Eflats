using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerModel;
using ServerController;

namespace UnitTests
{
    [TestClass]
    public class LandlordTests
    {
        [TestMethod]
        public void AddNewLandlord()
        {
            CtrLandlord ctrLandlordObj = new CtrLandlord();
            MdlLandlord mdlLandlordObj = GenerateLandlordObj();
            string expected = "Registration successful.";
            string actual;

            actual = ctrLandlordObj.AddLandlord(mdlLandlordObj).Trim();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddExistingLandlord()
        {
            CtrLandlord ctrLandlordObj = new CtrLandlord();
            MdlLandlord mdlLandlordObj = GenerateLandlordObj();
            mdlLandlordObj.Email = "defaultLandlord@default.com";
            string expected = "Registration has failed due to the existing Email.";
            string actual;

            actual = ctrLandlordObj.AddLandlord(mdlLandlordObj).Trim();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetLandlordData()
        {
            string expected = "contactPerson";
            string actual;
            CtrLandlord ctrLandlordObj = new CtrLandlord();

            MdlLandlord mdlLandlordObj = ctrLandlordObj.GetLandlordData("defaultLandlord@default.com");
            actual = mdlLandlordObj.ContactPerson.Trim();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetNonExistingLandlordData()
        {

            CtrLandlord ctrLandlordObj = new CtrLandlord();
            MdlLandlord mdlLandlordObj = ctrLandlordObj.GetLandlordData("defaultLandlordNonExisting@default.com");
            Assert.IsNull(mdlLandlordObj.ContactPerson);
        }

        [TestMethod]
        public void UpdateLandlordProfile()
        {
            CtrLandlord ctrLandlordObj = new CtrLandlord();
            MdlLandlord mdlLandlordObj = GenerateLandlordObj();

            mdlLandlordObj.Email = "defaultLandlord@default.com";
            mdlLandlordObj.Name = "CompanyName";
            mdlLandlordObj.Country = "Slovakia";
            mdlLandlordObj.City = "Neslusa";
            mdlLandlordObj.PostCode = "02341";
            mdlLandlordObj.Address = "Neslusa 523";
            mdlLandlordObj.ContactPerson = "Miroslav Pakanec";

            bool expected = true;
            bool actual = ctrLandlordObj.UpdateProfile(mdlLandlordObj);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateLandlordProfileNonExistingEmail()
        {
            CtrLandlord ctrLandlordObj = new CtrLandlord();
            MdlLandlord mdlLandlordObj = GenerateLandlordObj();

            mdlLandlordObj.Email = "defaultLandlordNonExisting@default.com";
            mdlLandlordObj.Name = "CompanyName";
            mdlLandlordObj.Country = "Slovakia";
            mdlLandlordObj.City = "Neslusa";
            mdlLandlordObj.PostCode = "02341";
            mdlLandlordObj.Address = "Neslusa 523";
            mdlLandlordObj.ContactPerson = "Miroslav Pakanec";

            bool expected = false;
            bool actual = ctrLandlordObj.UpdateProfile(mdlLandlordObj);

            Assert.AreEqual(expected, actual);
        }

        private MdlLandlord GenerateLandlordObj()
        {
            MdlLandlord mdlLandlordObj = new MdlLandlord();

            mdlLandlordObj.Email = "company@gmail.com";
            mdlLandlordObj.Password = "myPassword";
            mdlLandlordObj.Name = "CompanyName";
            mdlLandlordObj.Address = "Jernbanegade 12A";
            mdlLandlordObj.PostCode = "9000";
            mdlLandlordObj.City = "Aalborg";
            mdlLandlordObj.Country = "Denmark";
            mdlLandlordObj.ContactPerson = "Miroslav Pakanec";
            mdlLandlordObj.Phone = "+421910245649";

            return mdlLandlordObj;
        }
    }
}
