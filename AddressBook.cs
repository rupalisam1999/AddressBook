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
                    editContact = contact;
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

       
        public void sort()
        {
            List<string> sortList = new List<string>();
            foreach (Contact contacts in contactList)
            {
                string sort = contacts.ToString();
                sortList.Add(sort);
            }
            sortList.Sort();
            foreach (string sort in sortList)
            {
                Console.WriteLine(sort);
            }
        }

        public void sortByCity()
        {
            contactList.Sort(new Comparison<Contact>((a, b) => string.Compare(a.city, b.city)));
            Console.WriteLine("Contacts after sorting By City = ");
            foreach (Contact contact in contactList)
            {
                Console.WriteLine("\n FirstName = " + contact.firstName + "\n Last Name = " + contact.lastName + "\n Address = " + contact.address + "\n City = " + contact.city + "\n State = " + contact.state + "\n Zip = " + contact.zip + "\n Phone Number = " + contact.phoneNumber + "\n Email = " + contact.email);
            }
        }

       
        public void sortByState()
        {
            contactList.Sort(new Comparison<Contact>((a, b) => string.Compare(a.state, b.state)));
            Console.WriteLine("Contacts after sorting By State = ");
            foreach (Contact contact in contactList)
            {
                Console.WriteLine("\n FirstName = " + contact.firstName + "\n Last Name = " + contact.lastName + "\n Address = " + contact.address + "\n City = " + contact.city + "\n State = " + contact.state + "\n Zip = " + contact.zip + "\n Phone Number = " + contact.phoneNumber + "\n Email = " + contact.email);
            }
        }

       
        public void sortByZip()
        {
            contactList.Sort(new Comparison<Contact>((a, b) => string.Compare(a.zip, b.zip)));
            Console.WriteLine("Contacts after sorting By Zip = ");
            foreach (Contact contact in contactList)
            {
                Console.WriteLine("\n FirstName = " + contact.firstName + "\n Last Name = " + contact.lastName + "\n Address = " + contact.address + "\n City = " + contact.city + "\n State = " + contact.state + "\n Zip = " + contact.zip + "\n Phone Number = " + contact.phoneNumber + "\n Email = " + contact.email);
            }
        }
    }
}











