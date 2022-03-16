using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Contact
    {

        public Contact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public string firstName;
        public string lastName;
        public string address;
        public string phoneNumber;

        public string city;

        public string email;
        public string zip;
        public string state;


        public override string ToString()
        {
            return firstName + "\n" + lastName + "\n" + address + "\n" + city + "\n" + state + "\n" + zip + "\n" + phoneNumber + "\n" + email;
        }
    }
}

    
   







