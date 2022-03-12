﻿using System;
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

        public string firstName { get; set; }
        public  string lastName { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }

        public string city { get; set; }

        public string email { get; set; }
        public string state { get; set; }
        public string zip { get; set; }

     

    }

}

    
