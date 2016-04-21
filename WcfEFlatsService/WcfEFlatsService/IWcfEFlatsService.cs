using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Data;
using System.ServiceModel;
using System.Collections;
using System.Text;
using System.Net.Security;
using ServerModel;

namespace WcfEFlatsService
{
    [ServiceContract]
    public interface IWcfEFlatsService
    {
        //security test
        [OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
        string MessageTestSecured();

        [OperationContract(ProtectionLevel = ProtectionLevel.None)]
        string MessageTest();

        //general
        [OperationContract(ProtectionLevel = ProtectionLevel.None)]
        string AddStudent(MdlStudent mdlStudentObj);

        [OperationContract(ProtectionLevel = ProtectionLevel.None)]
        string AddLandlord(MdlLandlord mdlLandtlordObj);

        [OperationContract(ProtectionLevel = ProtectionLevel.None)]
        string Login(string email, string password);

        [OperationContract]
        bool Validate(string code);

        [OperationContract(ProtectionLevel = ProtectionLevel.None)]
        string AddFlat(string landLordEmail, string type, string address,
            string postCode, string city, double rent, double
            deposit, string availableFrom, string description);

        [OperationContract(ProtectionLevel = ProtectionLevel.None)]
        bool AddToWishlist(string studentEmail, int flatId, int score);

        [OperationContract(ProtectionLevel = ProtectionLevel.None)]
        bool RemoveFromWishlist(string studentEmail, int FlatId);

        //[OperationContract]
        //int CalculateApplicationScore(int studentId, string studentEmail, int flatId);

        [OperationContract(ProtectionLevel = ProtectionLevel.None)]
        bool EditStudentProfile(string email, int numberOfChildren, bool pet, int numberOfCohabitors, bool disabled,
           string name, string surname, string address, string postCode, string city, string country, string phone);

        [OperationContract(ProtectionLevel = ProtectionLevel.None)]
        bool EditLandlordProfile(MdlLandlord mdlLandlordObj);

        [OperationContract(ProtectionLevel = ProtectionLevel.None)]
        string GetUserType(string email);

        [OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
        MdlStudent GetStudentData(string email);

        [OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
        MdlLandlord GetLandlordData(string email);

        [OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
        DataSet GetAllFlats();

        [OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
        DataSet GetWishlist(string studentEmail);

        [OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
        DataSet SearchFlats(string city, int minPrice, int maxPrice, int minDeposit, int maxDeposit);

        [OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
        DataSet GetFlatsLandlord(string landlordEmail);

        [OperationContract(ProtectionLevel = ProtectionLevel.None)]
        bool UpdateFlatStatus(int fId, string status, string dateOfOffer, string availableFrom);

        [OperationContract(ProtectionLevel = ProtectionLevel.None)]
        bool UpdateFlat(int flatId, double rent, double deposit, string description);

        [OperationContract(ProtectionLevel = ProtectionLevel.None)]
        bool ConfirmTenants(int flatId, string studentEmail);

        [OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
        DataSet GetConfirmedFlats(string landlordEmail);
    }

    [ServiceContract]
    public interface IWcfEFlatsServiceAdmin
    {

        [OperationContract]
        int AdminLogin(string username, string password);

        [OperationContract]
        DataSet AdminGetTableData(string selectedTable);

        [OperationContract]
        bool AdminUpdateApplications(DataSet ds);

        [OperationContract]
        bool AdminUpdateFlats(DataSet ds);

        [OperationContract]
        bool AdminUpdateStudents(DataSet ds);

        [OperationContract]
        bool AdminUpdateLandlords(DataSet ds);

        [OperationContract]
        bool AdminUpdateAdmins(DataSet ds);
    }

}
