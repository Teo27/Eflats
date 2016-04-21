using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using ServerDatabase;
using ServerModel;

namespace ServerController
{
    public class CtrGetData
    {
        public string GetUserType(string email)
        {
            DbGetData dbGetDataObj = new DbGetData();
            return dbGetDataObj.GetUserType(email);
        }


        public DataSet GetAllFlats()
        {
            DbFlat dbFlatObj = new DbFlat();
            return dbFlatObj.GetAllFlats();
        }
    }
}
