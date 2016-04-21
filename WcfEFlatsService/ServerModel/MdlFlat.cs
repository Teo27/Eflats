using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ServerModel
{
    [DataContract(Namespace = "http://schema.myservice.com/TestService/customtypes")]
    public class MdlFlat
    {
        //main attributes
        private int _id;
        private string _landlordEmail;
        private string _type;
        private string _address;
        private string _postCode;
        private string _city;
        private double _rent;
        private double _deposit;
        private string _availableFrom;
        private string _description;
        private string _status;
        private string _dateOfOffer;

        //full constructor
        public MdlFlat(string landlordEmail, string type, string address, string postCode, string city, double rent, double deposit, string availableFrom, string description,
            string status, string dateOfOffer)
        {
            //_email = email;
            _landlordEmail = landlordEmail;
            _type = type;
            _address = address;
            _postCode = postCode;
            _city = city;
            _rent = rent;
            _deposit = deposit;
            _availableFrom = availableFrom;
            _description = description;
            _status = status;
            _dateOfOffer = dateOfOffer;
        }

        public MdlFlat()
        {

        }

        [DataMember(Name = "ID", Order = 1)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [DataMember(Name = "Landlord_Email", Order = 2)]
        public string LandlordEmail
        {
            get { return _landlordEmail; }
            set { _landlordEmail = value; }
        }

        [DataMember(Order = 3)]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        [DataMember(Order = 4)]
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        [DataMember(Order = 5)]
        public string PostCode
        {
            get { return _postCode; }
            set { _postCode = value; }
        }

        [DataMember(Order = 6)]
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        [DataMember(Order = 7)]
        public double Rent
        {
            get { return _rent; }
            set { _rent = value; }
        }

        [DataMember(Order = 8)]
        public double Deposit
        {
            get { return _deposit; }
            set { _deposit = value; }
        }


        [DataMember(Name = "Available_from", Order = 9)]
        public string AvailableFrom
        {
            get { return _availableFrom; }
            set { _availableFrom = value; }
        }

        [DataMember(Order = 10)]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        [DataMember(Order = 11)]
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        [DataMember(Order = 12)]
        public string DateOfOffer
        {
            get { return _dateOfOffer; }
            set { _dateOfOffer = value; }
        }
    }
}
