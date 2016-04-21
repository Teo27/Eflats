using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ServerDatabase;

namespace ServerController
{
    public class CtrConfirmed
    {
        public bool ConfirmTenants(int flatId, string studentEmail)
        {
            DbConfirmed dbConfirmedObj = new DbConfirmed();
            return dbConfirmedObj.ConfirmTenants(flatId, studentEmail);
        }

        public DataSet GetConfirmedFlats(string landlordEmail)
        {
            DbConfirmed dbConfirmedObj = new DbConfirmed();
            return dbConfirmedObj.GetConfirmedFlats(landlordEmail);
        }
    }
}
