using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    interface IContacts
    {
        public void addContact(string firstName, string lastName, string address, string email, string no, String state, string zip);
        public void Edit(string Name);
        public void Remove(string name);
       
    }
}
