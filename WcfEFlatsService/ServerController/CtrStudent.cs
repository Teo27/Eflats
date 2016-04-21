using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using System.Transactions;
using ServerModel;
using ServerDatabase;

namespace ServerController
{
    public class CtrStudent : CtrHash
    {
        public string AddStudent(MdlStudent mdlStudentObj)
        {
            DbStudent dbStudentObj = new DbStudent();
            CtrEmail ctrEmailObj = new CtrEmail();

            mdlStudentObj.Salt = CreateSalt(10);
            mdlStudentObj.Password = CreateHash(mdlStudentObj.Password, mdlStudentObj.Salt);

            //mdlStudentObj.ConfirmationCode = ctrEmailObj.getCode();
            mdlStudentObj.ConfirmationCode = "none";
            string Feedback = dbStudentObj.AddStudent(mdlStudentObj);
            if (Feedback == "Error")
                return Feedback;

            //ctrEmailObj.send();
            return Feedback;
        }

        public MdlStudent GetStudentData(string email)
        {
            DbStudent dbStudentObj = new DbStudent();
            return dbStudentObj.GetStudentData(email);
        }

        public bool UpdateProfile(string email, int numberOfChildren, bool pet, int numberOfCohabitors, bool disabled,
            string name, string surname, string address, string postCode, string city, string country, string phone)
        {
            DbStudent dbStudentObj = new DbStudent();
            MdlStudent mdlStudentObj = GetStudent(email, numberOfChildren, pet, numberOfCohabitors,
                disabled, name, surname, address, postCode, city, country, phone);

            mdlStudentObj = CalculateProfileScore(mdlStudentObj);
            return dbStudentObj.UpdateProfile(mdlStudentObj);
        }

        public static MdlStudent CalculateProfileScore(MdlStudent mdlStudentObj)
        {
            int numberOfChildren = Convert.ToInt32(mdlStudentObj.NumberOfChildren);
            bool disabled = Convert.ToBoolean(mdlStudentObj.Disabled);
            int numberOfCohabiters = Convert.ToInt32(mdlStudentObj.NumberOfCohabiters);

            mdlStudentObj.Score = (numberOfChildren * 40) + (numberOfCohabiters * 80);
            if (disabled)
                mdlStudentObj.Score += 60;

            return mdlStudentObj;
        }

        public bool AddToWishlist(string studentEmail, int flatId, int score)
        {
            MdlApplication mdlApplicationObj = GetApplicationObj(studentEmail, flatId, score);
            DbApplications dbApplicationsObj = new DbApplications();
            CtrApplications ctrApplicationObj = new CtrApplications();
            //Get current Application table for specific flat
            DataSet ds = dbApplicationsObj.GetApplicationsDataSet(mdlApplicationObj.StudentEmail, mdlApplicationObj.FlatId);
            if (ds.Tables.Count == 0)
                return false;
            //Update dataset - add current application and order queue
            ds = ctrApplicationObj.UpdateDataSet(ds, mdlApplicationObj);
            //update dataset
            return dbApplicationsObj.UpdateApplications(ds, mdlApplicationObj);
            //return false;
        }


        public bool RemoveFromWishlist(string studentEmail, int flatId)
        {
            MdlApplication mdlApplicationObj = GetApplicationObj(studentEmail, flatId, 0);
            DbApplications dbApplicationsObj = new DbApplications();
            CtrApplications ctrApplicationObj = new CtrApplications();

            var option = new TransactionOptions();
            option.IsolationLevel = System.Transactions.IsolationLevel.Serializable;
            option.Timeout = TimeSpan.FromSeconds(30);
            using (var scope = new TransactionScope(TransactionScopeOption.Required, option))
            {
                try
                {
                    //Get current Application table for specific flat
                    DataSet ds = dbApplicationsObj.GetApplicationsDataSetRomove(mdlApplicationObj.StudentEmail, mdlApplicationObj.FlatId);
                    if (ds.Tables.Count == 0)
                        return false;
                    //Update dataset - add current application and order queue
                    ds = ctrApplicationObj.UpdateDataSetToRemove(ds, mdlApplicationObj);
                    //update dataset
                    bool result = dbApplicationsObj.UpdateApplications(ds, mdlApplicationObj);
                    if (result)
                        scope.Complete();
                    else
                        scope.Dispose();

                    return result;
                    
                }
                catch
                {
                    Transaction.Current.Rollback();
                    return false;
                }
                finally
                {
                    if (scope != null)
                        ((IDisposable)scope).Dispose();
                }
            }

        }

        public DataSet GetWishlist(string studentEmail)
        {
            DbStudent dbStudentObj = new DbStudent();
            return dbStudentObj.GetWishlistData(studentEmail);
        }

        private MdlApplication GetApplicationObj(string studentEmail, int flatId, int score)
        {
            MdlApplication mdlApplicationObj = new MdlApplication();
            mdlApplicationObj.StudentEmail = studentEmail;
            mdlApplicationObj.FlatId = flatId;
            mdlApplicationObj.Score = score;
            return mdlApplicationObj;
        }

        private MdlStudent GetStudent(string email, int numberOfChildren, bool pet, int numberOfCohabitors, bool disabled,
            string name, string surname, string address, string postCode, string city, string country, string phone)
        {
            MdlStudent mdlStudentObj = new MdlStudent();

            mdlStudentObj.Email = email;
            mdlStudentObj.NumberOfChildren = numberOfChildren;
            mdlStudentObj.Pet = pet;
            mdlStudentObj.NumberOfCohabiters = numberOfCohabitors;
            mdlStudentObj.Disabled = disabled;
            mdlStudentObj.Name = name;
            mdlStudentObj.Surname = surname;
            mdlStudentObj.Address = address;
            mdlStudentObj.PostCode = postCode;
            mdlStudentObj.City = city;
            mdlStudentObj.Country = country;
            mdlStudentObj.Phone = phone;

            return mdlStudentObj;
        }
    }
}
