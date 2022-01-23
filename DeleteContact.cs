using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class DeleteContact
    {
        public void DeleteContact()
        {
            Console.WriteLine("Enter First Name of the Contact you want to Delete:");
            string name = Console.ReadLine();
            foreach (var contact in List)
            {
                if (contact.FirstName == name)
                {
                    List.Remove(contact);
                    Console.WriteLine("---------------------------------\n!!Contact Removed!!");
                    break;
                }
            }
        }

    }
}
