using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using ServerModel;
using ServerController;

namespace UnitTests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AddNewStudent()
        {
            CtrStudent ctrStudentObj = new CtrStudent();
            MdlStudent mdlStudentObj = GenerateStudentObj();
            string expected = "Registration successful.";
            string actual = ctrStudentObj.AddStudent(mdlStudentObj).Trim();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddExistingStudent()
        {
            CtrStudent ctrStudentObj = new CtrStudent();
            MdlStudent mdlStudentObj = GenerateStudentObj();
            mdlStudentObj.Email = "defaultStudent@default.com";
            string expected = "Registration has failed due to the existing Email.";
            string actual = ctrStudentObj.AddStudent(mdlStudentObj).Trim();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoginExistingStudent()
        {
            CtrLogin ctrLoginObj = new CtrLogin();
            CtrStudent ctrStudentObj = new CtrStudent();

            MdlStudent mdlStudentObj = GenerateStudentObj();
            mdlStudentObj.Email = "miroslavpakanec2@gmail.com";
            ctrStudentObj.AddStudent(mdlStudentObj).Trim();

            string expected = "You have successfully logged in.";
            string actual = ctrLoginObj.Login(mdlStudentObj.Email, "myPassword");
            Assert.AreEqual(expected, actual.Trim());
        }

        [TestMethod]
        public void LoginNonExistingStudent()
        {
            CtrLogin ctrLoginObj = new CtrLogin();

            string expected = "Incorrect Email.";
            string actual = ctrLoginObj.Login("defaultStudentNonExisting@default.com", "password").Trim();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoginExistingStudentIncorrectPassword()
        {
            CtrLogin ctrLoginObj = new CtrLogin();

            string expected = "Incorrect Password.";
            string actual = ctrLoginObj.Login("defaultStudent@default.com", "incorrectPassword").Trim();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetStudentData()
        {
            string expected = "surname";
            string actual; 
            CtrStudent ctrStudentObj = new CtrStudent();

            MdlStudent mdlStudentObj = ctrStudentObj.GetStudentData("defaultStudent@default.com");
            actual = mdlStudentObj.Surname.Trim();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetNonExistingStudentData()
        {
            CtrStudent ctrStudentObj = new CtrStudent();
            MdlStudent mdlStudentObj = ctrStudentObj.GetStudentData("defaultStudentNonExisting@default.com");
            Assert.IsNull(mdlStudentObj.Surname);
        }

        [TestMethod]
        public void UpdateStudentProfile()
        {
            CtrStudent ctrStudentObj = new CtrStudent();

            bool expected = true;
            bool actual = ctrStudentObj.UpdateProfile("defaultStudent@default.com", 
                2, false, 0, true, "name", "surname", "address", "postCode", "city", "country", "phone" );

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateStudentProfileNonExistingEmail()
        {
            CtrStudent ctrStudentObj = new CtrStudent();

            bool expected = false;
            bool actual = ctrStudentObj.UpdateProfile("defaultStudentNonExisting@default.com",
                2, false, 0, true, "name", "surname", "address", "postCode", "city", "country", "phone");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetStudentWishlist()
        {
            CtrStudent ctrStudentObj = new CtrStudent();
            DataSet ds = ctrStudentObj.GetWishlist("defaultStudent@default.com");

            string actual = ds.Tables[0].Rows[0]["Address"].ToString().Trim();
            string expected = "Porthusgade";

            Assert.AreEqual(expected, actual);
        }

        public static MdlStudent GenerateStudentObj()
        {
            MdlStudent mdlStudentObj = new MdlStudent();

            mdlStudentObj.Email = "miroslavpakanec@gmail.com";
            mdlStudentObj.Password = "myPassword";
            mdlStudentObj.Name = "Miroslav";
            mdlStudentObj.Surname = "Pakanec";
            mdlStudentObj.Address = "Jernbanegade 12A";
            mdlStudentObj.PostCode = "9000";
            mdlStudentObj.City = "Aalborg";
            mdlStudentObj.Country = "Denmark";
            mdlStudentObj.Phone = "+421910245649";

            return mdlStudentObj;
        }
    }
}
