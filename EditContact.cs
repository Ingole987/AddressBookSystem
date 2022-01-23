using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class EditContact
    {
        public void EditContact()
        {
            Console.WriteLine("Available Addressbooks are:: ");
            foreach (var key in DictName)
            {
                Console.WriteLine(key.Key + "\n----------------");
            }
            Console.WriteLine("------------------\nEnter Name of the AddressBook you want to edit:: ");
            string dictName = Console.ReadLine();

            foreach (var element in DictName)
            {
                if (element.Key == dictName)
                {
                    Console.WriteLine("Enter new First Name");
                    string newFirstName = Console.ReadLine();
                    element.Value.FirstName = newFirstName;
                    Console.WriteLine("Enter new Last Name:");
                    string newLastName = Console.ReadLine();
                    element.Value.LastName = newLastName;
                    Console.WriteLine("Enter new Address:");
                    string newAddress = Console.ReadLine();
                    element.Value.Address = newAddress;
                    Console.WriteLine("Enter new City:");
                    string newCity = Console.ReadLine();
                    element.Value.City = newCity;
                    Console.WriteLine("Enter new State:");
                    string newState = Console.ReadLine();
                    element.Value.State = newState;
                    Console.WriteLine("Enter new Zip Code:");
                    string newZipcode = Console.ReadLine();
                    element.Value.ZipCode = newZipcode;
                    Console.WriteLine("Enter new Phone Number:");
                    string newPhonenumber = Console.ReadLine();
                    element.Value.PhoneNumber = newPhonenumber;
                    Console.WriteLine("Enter new Email:");
                    string newEmail = Console.ReadLine();
                    element.Value.Email = newEmail;
                    Console.WriteLine("---------------------------------\n!!Contact Edited!!");
                }
            }

        }
    }
}
