using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBook : IContacts
    {
        public List<Contact> contactList;

        public AddressBook()
        {
            this.contactList = new List<Contact>();
        }

        public void addContact(String firstName, String lastName, String address, String city, String state, String zip, String phoneNumber, String email)
        {
            bool duplicate = equals(firstName);
            if (!duplicate)
            {
                Contact contact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
                contactList.Add(contact);
            }
            else
            {
                Console.WriteLine("Cannot add duplicate contacts first name");
            }
        }

        private bool equals(string firstName)
        {
            if (this.contactList.Any(e => e.firstName == firstName))
                return true;
            else
                return false;
        }
        public void Edit(string firstName)
        {
            Contact editContact = null;

            foreach (Contact contact in contactList)
            {


                if (firstName.Equals(contact.firstName))
                {
                    editContact = null;
                }
            }
            Console.WriteLine("Plz provide new no");
            editContact.phoneNumber = Console.ReadLine();

            Console.WriteLine("Plz provide new email");
            editContact.email = Console.ReadLine();

            Console.WriteLine("Plz provide new address");
            editContact.address = Console.ReadLine();

            Console.WriteLine("Plz provide new state");
            editContact.state = Console.ReadLine();

            Console.WriteLine("Plz provide new zip");
            editContact.zip = Console.ReadLine();

            contactList.Add(editContact);
            Console.WriteLine($"Contact of {firstName} has been edited");
        }

        public void delet(string name)
        {
            Contact RemoveContact = null;
            foreach (Contact contact in contactList)
            {
                if (contact.firstName.Contains(name))
                {
                    RemoveContact = contact;
                }
            }
            contactList.Remove(RemoveContact);
            Console.WriteLine($"Contact of {name} has been deleted");
        }

        public void displayContact()
        {
            foreach (Contact contact in contactList)
            {
                Console.WriteLine("\nFirst name = " + contact.firstName);
                Console.WriteLine("Last name = " + contact.lastName);
                Console.WriteLine("Address = " + contact.address);
                Console.WriteLine("city = " + contact.city);
                Console.WriteLine("state = " + contact.state);
                Console.WriteLine("zip = " + contact.zip);
                Console.WriteLine("phoneNumber = " + contact.phoneNumber);
                Console.WriteLine("email = " + contact.email);
            }
        }

        public List<string> findPersons(string place)
        {
            List<string> personFounded = new List<string>();
            foreach (Contact contacts in contactList.FindAll(e => (e.city.Equals(place))).ToList())
            {
                string name = contacts.firstName + " " + contacts.lastName;
                personFounded.Add(name);
            }
            if (personFounded.Count == 0)
            {
                foreach (Contact contacts in contactList.FindAll(e => (e.state.Equals(place))).ToList())
                {
                    string name = contacts.firstName + " " + contacts.lastName;
                    personFounded.Add(name);
                }
            }
            return personFounded;
        }


    }






}


    

