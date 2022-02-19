using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBook
    {
        List<Contact> contacts = new List<Contact>();

        public void addContact(string firstName, string lastName, string address, string email, string no, String state, string zip)
        {
            contacts.Add(new Contact()
            {

                phoneNo = no,
                firstName = firstName,
                lastName = lastName,
                email = email,
                address = address,
                state = state,
                zip = zip,
            });
            Console.WriteLine("$Contact of {firstName} has been add.");
        }
            
            }
}
