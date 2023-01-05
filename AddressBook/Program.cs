using System.Net;
using System.Reflection.Emit;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welome to address book program");

            //UC1CreateContacts addressbook = new UC1CreateContacts();
            //addressbook.CreateContact();

            UC2AddContact add = new UC2AddContact();
            add.AddContact();


        }
    }
}