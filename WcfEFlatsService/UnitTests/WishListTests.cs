using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using ServerController;
using ServerModel;

namespace UnitTests
{
    [TestClass]
    public class WishListTests
    {
        [TestMethod]
        public void AddToWishList()
        {
            CtrStudent ctrStudentObj = new CtrStudent();
            MdlStudent mdlStudentObj = StudentTests.GenerateStudentObj();
            mdlStudentObj.Email = "defaultStudent2@default.com";
            ctrStudentObj.AddStudent(mdlStudentObj);
            CtrGetData ctrGetDataObj = new CtrGetData();
            DataSet ds = ctrGetDataObj.GetAllFlats();

            MdlApplication mdlApplicationObj = new MdlApplication();
            string studentEmail = "defaultStudent2@default.com";
            int flatId = (int)ds.Tables[0].Rows[0]["Id"];
            int score = 100;

            bool actual = ctrStudentObj.AddToWishlist(studentEmail, flatId, score);
            bool expected = true;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void AddToWishListExistingApplicaation()
        {
            CtrStudent ctrStudentObj = new CtrStudent();
            MdlStudent mdlStudentObj = StudentTests.GenerateStudentObj();

            CtrGetData ctrGetDataObj = new CtrGetData();
            DataSet ds = ctrGetDataObj.GetAllFlats();

            MdlApplication mdlApplicationObj = new MdlApplication();
            string studentEmail = "defaultStudent@default.com";
            int flatId = (int)ds.Tables[0].Rows[0]["Id"];
            int score = 100;

            bool actual = ctrStudentObj.AddToWishlist(studentEmail, flatId, score);
            bool expected = false;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void RemoveFromWishList()
        {
            CtrStudent ctrStudentObj = new CtrStudent();
            CtrGetData ctrGetDataObj = new CtrGetData();
            DataSet ds = ctrGetDataObj.GetAllFlats();

            string studentEmail = "defaultStudent3@default.com";
            int flatId = (int)ds.Tables[0].Rows[0]["Id"];

            bool actual = ctrStudentObj.RemoveFromWishlist(studentEmail, flatId);
            bool expected = true;

            Assert.AreEqual(expected, actual);

        }
    }
}
