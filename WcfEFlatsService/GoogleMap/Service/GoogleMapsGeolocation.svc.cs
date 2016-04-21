using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GoogleMap.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GoogleMapsGeolocation" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GoogleMapsGeolocation.svc or GoogleMapsGeolocation.svc.cs at the Solution Explorer and start debugging.
    public class GoogleMapsGeolocation : IGoogleMapsGeolocation
    {

        public string GetLattitudeAndLogitudeByAdress(string adress)
        {

            var client = new WebClient();
            //loading XML in xml doc
            string location =
            client.DownloadString("http://maps.googleapis.com/maps/api/geocode/json?address="
            + adress.Trim());

            var o = JObject.Parse(location);

            return o["results"][0]["geometry"]["location"]["lat"]
            + "#" +
            o["results"][0]["geometry"]["location"]["lng"];
        }
    }
}

