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
        public void Edit(string Name)
        {
            Contact editContact =null;
            foreach (var Contact in contacts) 
            {

                if (Contact.firstName.Contains(Name))
                {
                    editContact = Contact;
                }
            }
            Console.WriteLine("Plz provide new no");
            editContact.phoneNo = Console.ReadLine();

            Console.WriteLine("Plz provide new email");
            editContact.email = Console.ReadLine();

            Console.WriteLine("Plz provide new address");
            editContact.address = Console.ReadLine();

            Console.WriteLine("Plz provide new state");
            editContact.state = Console.ReadLine();

            Console.WriteLine("Plz provide new zip");
            editContact.zip = Console.ReadLine();

            contacts.Add(editContact);
            Console.WriteLine($"Contact of {Name} has been edited");

        }
    }
}
