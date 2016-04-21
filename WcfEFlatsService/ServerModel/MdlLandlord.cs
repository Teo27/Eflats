using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ServerModel
{
    [DataContract]
    public class MdlLandlord
    {
        //main attributes
        private string _email;
        private string _password;
        private string _salt;
        private bool _confirmed;

        //queue based attributes
        private DateTime _dateOfCreation;

        //personal attributes
        private string _name;
        private string _address;
        private string _postCode;
        private string _city;
        private string _country;
        private string _contactPerson;
        private string _phone;

        //full constructor
        public MdlLandlord (string email, string password, bool confirmed, DateTime dateOfCreation,
                string name, string address, string postCode, string city, string country, string contactPerson, string phone)
        {
            //initialize main
            _email = email;
            _password = password;
            _confirmed = confirmed;

            //initialize queue based
            _dateOfCreation = dateOfCreation;

            //initialize personal
            _name = name;
            _address = address;
            _postCode = postCode;
            _city = city;
            _country = country;
            _contactPerson = contactPerson;
            _phone = phone;
        }


        public MdlLandlord(string email, string password)
        {
            _email = email;
            _password = password;
        }

        public MdlLandlord()
        {

        }

        [DataMember(Name = "Email", Order = 1)]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        [DataMember(Order = 2)]
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Salt
        {
            get { return _salt; }
            set { _salt = value; }
        }

        [DataMember(Order = 3)]
        public bool Confirmed
        {
            get { return _confirmed; }
            set { _confirmed = value; }
        }
        
        [DataMember(Name = "Date_of_creation", Order = 3)]
        public DateTime DateOfCreation
        {
            get { return _dateOfCreation; }
            set { _dateOfCreation = value; }
        }

        [DataMember(Order = 3)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
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
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        [DataMember(Name = "Contact_person", Order = 8)]
        public string ContactPerson
        {
            get { return _contactPerson; }
            set { _contactPerson = value; }
        }

        [DataMember(Order = 9)]
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
    }
}
