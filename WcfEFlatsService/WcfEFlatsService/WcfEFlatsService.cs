using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Collections;
using System.Data;
using ServerModel;
using ServerController;

namespace WcfEFlatsService
{
    [ServiceBehavior (InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class WcfEFlatsService : IWcfEFlatsService, IWcfEFlatsServiceAdmin
    {
        private readonly object LockObject = new object();
        private static CtrLandlord ctrLandlordObj;
        private static CtrStudent ctrStudentObj;
        private static CtrLogin ctrLoginObj;
        private static CtrGetData ctrGetDataObj;
        private static CtrFlat ctrFlatObj;
        private static CtrConfirmed ctrConfirmedObj;
        private static CtrAdmin ctrAdminObj;

        public string MessageTest()
        {
            Console.WriteLine();
            Console.WriteLine("MessageTest() " + GetExecutionThreadTime());
            return "THIS IS MY MESSAGE";
        }

        public string MessageTestSecured()
        {
            Console.WriteLine();
            Console.WriteLine("MessageTestSecured() " + GetExecutionThreadTime());
            return "THIS IS MY SECURED MESSAGE";
        }

        public string AddStudent(MdlStudent mdlStudentObj)
        {
            ctrStudentObj = new CtrStudent();

            Console.WriteLine();
            Console.WriteLine("AddStudent() " + GetExecutionThreadTime());

            return ctrStudentObj.AddStudent(mdlStudentObj);

        }

        public string AddLandlord(MdlLandlord mdlLandlordObj)
        {
            ctrLandlordObj = new CtrLandlord();

            Console.WriteLine();
            Console.WriteLine("AddLandlord() " + GetExecutionThreadTime());

            return ctrLandlordObj.AddLandlord(mdlLandlordObj);
        }

        public bool Validate(string code)
        {
            CtrEmail ctrEmail = new CtrEmail();
            return ctrEmail.checkCodeExist(code);
        }

        public string Login(string email, string password)
        {
             ctrLoginObj = new CtrLogin();

             Console.WriteLine();
             Console.WriteLine("Login() " + GetExecutionThreadTime());

             return ctrLoginObj.Login(email, password);
        }

        public string AddFlat(string landLordEmail, string type, string address,
            string postCode, string city, double rent, double
            deposit, string availableFrom, string description)
        {
            ctrLandlordObj = new CtrLandlord();

            Console.WriteLine();
            Console.WriteLine("AddFlat() " + GetExecutionThreadTime());

            return ctrLandlordObj.AddFlat(landLordEmail, type, address, postCode, city, rent, deposit, availableFrom, description);
        }

        public string GetUserType(string email)
        {
            ctrGetDataObj = new CtrGetData();

            Console.WriteLine();
            Console.WriteLine("GetUserType() " + GetExecutionThreadTime());

            return ctrGetDataObj.GetUserType(email);
        }

        public MdlStudent GetStudentData(string email)
        {
            ctrStudentObj = new CtrStudent();

            Console.WriteLine();
            Console.WriteLine("GetStudentData() " + GetExecutionThreadTime());

            return ctrStudentObj.GetStudentData(email);
        }

        public MdlLandlord GetLandlordData(string email)
        {
            ctrLandlordObj = new CtrLandlord();

            Console.WriteLine();
            Console.WriteLine("GetLandlordData() " + GetExecutionThreadTime());

            return ctrLandlordObj.GetLandlordData(email);
        }

        public bool AddToWishlist(string studentEmail, int flatId, int score)
        {
            ctrStudentObj = new CtrStudent();

            Console.WriteLine();
            Console.WriteLine("AddToWishlist() " + GetExecutionThreadTime());

            return ctrStudentObj.AddToWishlist(studentEmail, flatId, score);
        }

        public bool RemoveFromWishlist(string studentEmail, int flatId)
        {
            ctrStudentObj = new ServerController.CtrStudent();
            Console.WriteLine();
            Console.WriteLine("RemoveFromWishlist() " + GetExecutionThreadTime());

            return ctrStudentObj.RemoveFromWishlist(studentEmail, flatId);
        }

        public DataSet GetAllFlats()
        {
            ctrGetDataObj = new CtrGetData();

            Console.WriteLine();
            Console.WriteLine("GetAllFlata() " + GetExecutionThreadTime());

            return ctrGetDataObj.GetAllFlats();
        }

        public DataSet GetWishlist(string studentEmail)
        {
            ctrStudentObj = new CtrStudent();

            Console.WriteLine();
            Console.WriteLine("GetWishlist() " + GetExecutionThreadTime());

            return ctrStudentObj.GetWishlist(studentEmail);
        }

        public bool EditStudentProfile(string email, int numberOfChildren, bool pet, int numberOfCohabitors, bool disabled,
            string name, string surname, string address, string postCode, string city, string country, string phone)
        {
            ctrStudentObj = new CtrStudent();

            Console.WriteLine();
            Console.WriteLine("EditStudentProfile() " + GetExecutionThreadTime());

            return ctrStudentObj.UpdateProfile(email, numberOfChildren, pet, numberOfCohabitors, disabled,
                name, surname, address, postCode, city, country, phone);
        }


        public bool EditLandlordProfile(MdlLandlord mdlLandlordObj)
        {
            ctrLandlordObj = new CtrLandlord();

            Console.WriteLine();
            Console.WriteLine("EditLandlordProfile() " + GetExecutionThreadTime());

            return ctrLandlordObj.UpdateProfile(mdlLandlordObj);
        }

        public bool UpdateFlatStatus(int fId, string status, string dateOfOffer, string availableFrom)
        {
            ctrFlatObj = new CtrFlat();

            Console.WriteLine();
            Console.WriteLine("EditLandlordProfile() " + GetExecutionThreadTime());

            return ctrFlatObj.UpdateFlatStatus(fId, status, dateOfOffer, availableFrom);
        }

        public DataSet SearchFlats(string city, int minPrice, int maxPrice, int minDeposit, int maxDeposit)
        {
            ctrFlatObj = new CtrFlat();

            Console.WriteLine();
            Console.WriteLine("SearchFlats() " + GetExecutionThreadTime());

            return ctrFlatObj.searchFlats(minPrice, maxPrice, city, minDeposit, maxDeposit);
        }

        public bool UpdateFlat(int flatId, double rent, double deposit, string description)
        {
            ctrFlatObj = new CtrFlat();

            Console.WriteLine();
            Console.WriteLine("UpdateFlat() " + GetExecutionThreadTime());

            return ctrFlatObj.UpdateFlat(flatId, rent, deposit, description);

        }

        public DataSet GetFlatsLandlord(string landlordEmail)
        {
            ctrLandlordObj = new CtrLandlord();

            Console.WriteLine();
            Console.WriteLine("GetFlatsLandlord() " + GetExecutionThreadTime());

            return ctrLandlordObj.GetFlatsLandlord(landlordEmail);
        }

        //ADMIN

        public int AdminLogin(string username, string password)
        {
            ctrAdminObj = new CtrAdmin();

            //lock (LockObject)
            //{
                Console.WriteLine();
                //Console.WriteLine("START THREAD ID: " + Thread.CurrentThread.ManagedThreadId.ToString());
                Console.WriteLine("AdminLogin() " + GetExecutionThreadTime());

                //Thread.Sleep(3000);

                return ctrAdminObj.Login(username, password);
            //}
        }

        public DataSet AdminGetTableData(string selectedTable)
        {
            ctrAdminObj = new CtrAdmin();

            Console.WriteLine();
            Console.WriteLine("AdminGetTableData() " + GetExecutionThreadTime());
            Console.WriteLine("Table: " + selectedTable);

            return ctrAdminObj.GetTableData(selectedTable);
        }

        public bool AdminUpdateApplications(DataSet ds)
        {
            ctrAdminObj = new CtrAdmin();

            Console.WriteLine();
            Console.WriteLine("AdminUpdateApplications() " + GetExecutionThreadTime());

            return ctrAdminObj.UpdateApplications(ds);
        }

        public bool AdminUpdateFlats(DataSet ds)
        {
            ctrAdminObj = new CtrAdmin();

            Console.WriteLine();
            Console.WriteLine("AdminUpdateFlats() " + GetExecutionThreadTime());

            return ctrAdminObj.UpdateFlats(ds);
        }

        public bool AdminUpdateStudents(DataSet ds)
        {
            ctrAdminObj = new CtrAdmin();

            Console.WriteLine();
            Console.WriteLine("AdminUpdateStudents() " + GetExecutionThreadTime());

            return ctrAdminObj.UpdateStudents(ds);
        }

        public bool AdminUpdateLandlords(DataSet ds)
        {
            ctrAdminObj = new CtrAdmin();

            Console.WriteLine();
            Console.WriteLine("AdminUpdateLandlords() " + GetExecutionThreadTime());

            return ctrAdminObj.UpdateLandlords(ds);
        }

        public bool AdminUpdateAdmins(DataSet ds)
        {
            ctrAdminObj = new CtrAdmin();

            Console.WriteLine();
            Console.WriteLine("AdminUpdateAdmins() " + GetExecutionThreadTime());

            return ctrAdminObj.UpdateAdmins(ds);
        }

        public bool ConfirmTenants(int flatId, string studentEmail)
        {
            ctrConfirmedObj = new CtrConfirmed();

            Console.WriteLine();
            Console.WriteLine("ConfirmTenants() " + GetExecutionThreadTime());

            return ctrConfirmedObj.ConfirmTenants(flatId, studentEmail);
        }

        public DataSet GetConfirmedFlats(string landlordEmail)
        {
            ctrConfirmedObj = new CtrConfirmed();

            Console.WriteLine();
            Console.WriteLine("GetConfirmedFlats() " + GetExecutionThreadTime());

            return ctrConfirmedObj.GetConfirmedFlats(landlordEmail);
        }

        private string GetExecutionThreadTime()
        {
            string message = " executed by Thread: " + Thread.CurrentThread.ManagedThreadId.ToString() +
                " at : " + DateTime.Now.ToString();
            return message;
        }
    }
}
