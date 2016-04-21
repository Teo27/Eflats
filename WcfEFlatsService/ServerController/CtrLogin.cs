using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerDatabase;

namespace ServerController
{
    public class CtrLogin : CtrHash
    {
        public string Login(string email, string password)
        {
            DbLogin dbLoginObj = new DbLogin();
            return dbLoginObj.Login(email, CreateHash(password.Trim(), dbLoginObj.GetSalt(email).Trim()));

        }
    }
}
