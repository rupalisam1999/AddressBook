using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    interface IContacts
    {
        public void addContact(String firstName, String lastName, String address, String city, String state, String zip, String phoneNumber, String email);
        public void Edit(string firstName);
        public void delet(string name);

        public void displayContact();

    }
}
