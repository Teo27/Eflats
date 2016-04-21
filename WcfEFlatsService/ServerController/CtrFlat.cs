using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using ServerDatabase;
using ServerModel;

namespace ServerController
{
    public class CtrFlat
    {
        public DataSet searchFlats(int minPrice, int maxPrice, string city, int minDeposit, int maxDeposit)
        {
            List<string[]> flatsList = new List<string[]>();
            DbFlat dbFlat = new DbFlat();
            DataSet fds = dbFlat.GetAllFlats();
            DataTable flatsDT = fds.Tables[0];

            //rewrite for each to while loop
            foreach (DataRow row in flatsDT.Rows)
            {
                if (minPrice <= int.Parse(row["Rent"].ToString()) &&
                   maxPrice >= int.Parse(row["Rent"].ToString()) &&
                   minDeposit <= int.Parse(row["Deposit"].ToString()) &&
                   maxDeposit >= int.Parse(row["Deposit"].ToString()))
                {
                    if (city.Equals(row["City"].ToString().Trim()) || city.Equals(""))
                        flatsList.Add(createArray(row));
                }
            }
            DataTable flatsTable = createDataTable(flatsList);
            DataSet ds = new DataSet();
            ds.Tables.Add(flatsTable);
            return ds;
        }

        private DataTable createDataTable(List<string[]> flatsList)
        {
            DataTable flatsTable = new DataTable();

            //create columns
            for (int i = 0; i < flatsList[0].Length; i++)
            {
                flatsTable.Columns.Add();
            }
            flatsTable.Columns["Column1"].ColumnName = "Id";
            flatsTable.Columns["Column2"].ColumnName = "LandlordEmail";
            flatsTable.Columns["Column3"].ColumnName = "Type";
            flatsTable.Columns["Column4"].ColumnName = "Address";
            flatsTable.Columns["Column5"].ColumnName = "PostCode";
            flatsTable.Columns["Column6"].ColumnName = "City";
            flatsTable.Columns["Column7"].ColumnName = "Rent";
            flatsTable.Columns["Column8"].ColumnName = "Deposit";
            flatsTable.Columns["Column9"].ColumnName = "AvailableFrom";
            flatsTable.Columns["Column10"].ColumnName = "Description";
            flatsTable.Columns["Column11"].ColumnName = "Status";
            //store data
            foreach (string[] array in flatsList)
            {
                flatsTable.Rows.Add(array);
            }
            return flatsTable;
        }

        private string[] createArray(DataRow row)
        {
            string[] flat = new string[13];

            flat[0] = row["Id"].ToString().Trim();
            flat[1] = row["LandlordEmail"].ToString().Trim();
            flat[2] = row["Type"].ToString().Trim();
            flat[3] = row["Address"].ToString().Trim();
            flat[4] = row["PostCode"].ToString().Trim();
            flat[5] = row["City"].ToString().Trim();
            flat[6] = row["Rent"].ToString().Trim();
            flat[7] = row["Deposit"].ToString().Trim();
            flat[8] = row["AvailableFrom"].ToString().Trim();
            flat[9] = row["Description"].ToString().Trim();
            flat[10] = row["Status"].ToString().Trim();
            //flat[0] = Convert.DateTime(row["DateofCreation"].ToString());
            //flat[0] = row["Date_of_offer"];

            return flat;
        }

        public bool UpdateFlatStatus(int fId, string status, string dateOfOffer, string availableFrom)
        {
            DbFlat dbFlatObj = new DbFlat();
            MdlFlat mdlFlatObj = new MdlFlat();

            mdlFlatObj.Id = fId;
            mdlFlatObj.Status = status;
            mdlFlatObj.DateOfOffer = dateOfOffer;
            mdlFlatObj.AvailableFrom = availableFrom;

            return dbFlatObj.UpdateFlatsStatus(mdlFlatObj);
        }

        public bool UpdateFlat(int flatId, double rent, double deposit, string description)
        {
            DbFlat dbFlatObj = new DbFlat();
            MdlFlat mdlFlatObj = new MdlFlat();

            mdlFlatObj.Id = flatId;
            mdlFlatObj.Rent = rent;
            mdlFlatObj.Deposit = deposit;
            mdlFlatObj.Description = description;

            return dbFlatObj.UpdateFlat(mdlFlatObj);
        }
    }
}
