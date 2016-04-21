using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GoogleMap.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGoogleMapsGeolocation" in both code and config file together.
    [ServiceContract]
    public interface IGoogleMapsGeolocation
    {
        [OperationContract]
        string GetLattitudeAndLogitudeByAdress(string adress);
    }
}
