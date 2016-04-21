using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data;
using ServerModel;
using ServerDatabase;

namespace ServerController
{
    public class CtrLandlord : CtrHash
    {

        public string AddLandlord(MdlLandlord mdlLandlordObj)
        {
            DbLandlord dbLandlordObj = new DbLandlord();
            mdlLandlordObj.Salt = CreateSalt(10);
            mdlLandlordObj.Password = CreateHash(mdlLandlordObj.Password, mdlLandlordObj.Salt);
            return dbLandlordObj.AddLandlord(mdlLandlordObj);
        }

        public MdlLandlord GetLandlordData(string email)
        {
            DbLandlord dbLandlordObj = new DbLandlord();
            return dbLandlordObj.GetLandlordData(email);
        }

        public string AddFlat(string landLordEmail, string type, string address,
            string postCode, string city, double rent, double
            deposit, string availableFrom, string description)
        {
            DbFlat dbFlatObj = new DbFlat();
            MdlFlat mdlFlatObj = CreateFlatObj(landLordEmail, type, address, postCode, city, rent, deposit, availableFrom, description);
            return dbFlatObj.AddFlat(mdlFlatObj);
        }

        public bool UpdateProfile(MdlLandlord mdlLandlordObj)
        {
            DbLandlord dbLandlordObj = new DbLandlord();
            return dbLandlordObj.UpdateProfile(mdlLandlordObj);
        }

        public DataSet GetFlatsLandlord(string landlordEmail)
        {
            DbLandlord dbLandlordObj = new DbLandlord();
            DataSet ds = dbLandlordObj.GetFlatsLandlord(landlordEmail);

            return ds;
        }

        private MdlFlat CreateFlatObj(string landLordEmail, string type, string address,
            string postCode, string city, double rent, double
            deposit, string availableFrom, string description)
        {
            MdlFlat mdlFlatObj = new MdlFlat();
            mdlFlatObj.LandlordEmail = landLordEmail;
            mdlFlatObj.Type = type;
            mdlFlatObj.Address = address;
            mdlFlatObj.PostCode = postCode;
            mdlFlatObj.City = city;
            mdlFlatObj.Rent = rent;
            mdlFlatObj.Deposit = deposit;
            mdlFlatObj.AvailableFrom = availableFrom;
            mdlFlatObj.Description = description;
            return mdlFlatObj;
        }
    }
}
