using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book program");

            AddressBook addressBook = new AddressBook();


            string firstName = Console.ReadLine();
            Console.WriteLine( "Enter first name");

            string lastName = Console.ReadLine();
            Console.WriteLine("Enter last name");

            string address = Console.ReadLine();
            Console.WriteLine("Enter address");

            string phoneNo = Console.ReadLine();
            Console.WriteLine("Enter phone no");

            string email = Console.ReadLine();
            Console.WriteLine("Enter email");

            string state = Console.ReadLine();
            Console.WriteLine("Enter state");

            string zip = Console.ReadLine();
            Console.WriteLine("Enter zip");

            addressBook.addContact(firstName, lastName, address, email,phoneNo,state, zip);

            Console.WriteLine("\nIf you want to edit contact plz enter name");
            string name = Console.ReadLine();
            addressBook.Edit(name);

            addressBook.addContact(firstName, lastName, email, phoneNo , address, zip , state);

            Console.WriteLine("\nIf you want to delete contact plz enter name");
            string firstname = Console.ReadLine();
            addressBook.Remove(firstname);


        }
       
            
    }
}
