using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using ServerDatabase;
using ServerController;
using ServerModel;
using System.Linq;
using System.Data;

namespace UnitTests
{
    [TestClass()]
    public class CtrFlatTests
    {
        //[TestMethod()]
        //public void searchFlatsTest()
        //{
        //    // config
        //    int minPrice = 0;
        //    int maxPrice = 90000;
        //    int minDeposit = 0;
        //    int maxDeposit = 999999;
        //    ArrayList postCodes = new ArrayList();
        //    postCodes.Add("9000");
        //    postCodes.Add("9200");
        //    postCodes.Add("9400");
        //    // setup
        //    CtrFlat ctrFlat = new CtrFlat();
        //    DataSet flatList = ctrFlat.searchFlats(minPrice, maxPrice, postCodes, minDeposit, maxDeposit);

            //check if all data has been given
            /*
            foreach (MdlFlat flat in flatList)
            {
                Assert.IsNotNull(flat.Id);
                Assert.IsNotNull(flat.LandlordEmail);
                Assert.IsNotNull(flat.Type);
                Assert.IsNotNull(flat.Address);
                Assert.IsNotNull(flat.PostCode);
                Assert.IsNotNull(flat.City);
                Assert.IsNotNull(flat.Rent);
                Assert.IsNotNull(flat.Deposit);
                Assert.IsNotNull(flat.AvailableFrom);
                Assert.IsNotNull(flat.Description);
                Assert.IsNotNull(flat.Status);
                Assert.IsNotNull(flat.DateOfOffer);
            }
            //check if flats mach criterias that was given
            foreach (MdlFlat flat in flatList)
            {
                Assert.IsTrue(minPrice < flat.Rent);
                Assert.IsTrue(maxPrice > flat.Rent);
                Assert.IsTrue(minDeposit < flat.Deposit);
                Assert.IsTrue(maxDeposit > flat.Deposit);
                Assert.IsTrue(postCodes.Contains(flat.PostCode));
            }
            */
        //}
    }
}
