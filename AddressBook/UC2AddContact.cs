using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class UC2AddContact
    {
        List<Contact> add = new List<Contact>();
        public void AddContact()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter FirstName");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter LastName");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();

            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine();

            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine();

            Console.WriteLine("Enter ZipCode");
            contact.ZipCode = long.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter phoneNumber");
            contact.Phonenumber = long.Parse(Console.ReadLine());
            
            add.Add(contact);

        }

        public void Display()
        {
            foreach(Contact data in add)
            {
                Console.WriteLine("FirstNmae :" +data.FirstName);
                Console.WriteLine("LastName:" +data.LastName);
                Console.WriteLine("Address:"+data.Address);
                Console.WriteLine("City:"+data.City);
                Console.WriteLine("State:"+data.State);
                Console.WriteLine("ZipCode:"+data.ZipCode);
                Console.WriteLine("PhoneNumber"+data.Phonenumber);

            }
        }
    }
}
