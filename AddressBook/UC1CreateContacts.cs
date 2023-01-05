using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class UC1CreateContacts
    {
        public void CreateContact()
        {
            Console.WriteLine("1.FirstName");
            string FirstName = Console.ReadLine();

            Console.WriteLine("2.LastName");
            string LastName = Console.ReadLine();

            Console.WriteLine("3.Address");
            string Address = Console.ReadLine();

            Console.WriteLine("4.City");
            string City = Console.ReadLine();

            Console.WriteLine("5.State");
            string State = Console.ReadLine();

            Console.WriteLine("6.ZipCode");
            string ZipCode = Console.ReadLine();

            Console.WriteLine("1.Enter phonenumber");
            string phonenumber = Console.ReadLine();


            Console.WriteLine("1.Enter Email-Id");
            string Emailid = Console.ReadLine();
        }
    }
}
