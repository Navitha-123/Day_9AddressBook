using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class UC4DeleteContact
    {
        List<Contact> people = new List<Contact>();
        public  void DeletePerson()
        {
            Contact contacts = new Contact();
            int choice1 = 0;
            Console.WriteLine("Input any one operation you want to perform: ");
            Console.WriteLine("1.Add Person\n2.Edit Person \n 3.deleteperson");
            choice1 = Convert.ToInt32(Console.ReadLine());

            switch (choice1)
            {
                case 1:
                    Console.WriteLine("Enter First Name:");
                    contacts.FirstName = Console.ReadLine();
                    Console.WriteLine("Enter Last Name:");
                    contacts.LastName = Console.ReadLine();
                    Console.WriteLine("Enter Address:");
                    contacts.Address = Console.ReadLine();
                    Console.WriteLine("Enter State:");
                    contacts.State = Console.ReadLine();
                    Console.WriteLine("Enter City:");
                    contacts.City = Console.ReadLine();
                    Console.WriteLine("Enter Zip:");
                    contacts.ZipCode = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Phone Number:");
                    contacts.Phonenumber = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter Email:");
                    contacts.Emailid = Console.ReadLine();

                    people.Add(contacts);
                    Console.WriteLine("Contact Added Successfully:");
                    break;
                case 2:
                    string name;
                    int choice = 0;
                    Console.WriteLine("Enter First Name of Contact to edit: ");
                    name = Console.ReadLine();
                    for (int i = 0; i < people.Count; i++)
                    {
                        Contact contact = people[i];
                        Console.WriteLine("Info of selected Person");
                        //showing person's info to user for clarification
                        PrintPerson(contact);
                        //Console.WriteLine("Press Enter");
                        //Console.ReadLine();
                        if (contact.FirstName == name)
                        {
                            Console.WriteLine("Now choose what you want to edit");
                            Console.WriteLine("-------------------------------------------");
                            Console.WriteLine("1.First Name\n2.Last Name\n3.Address\n4.State\n5.City\n6.Zip\n7.Phone Number\n8.Email");
                            Console.WriteLine("-------------------------------------------");
                            Console.WriteLine("Input Here: ");
                            choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine("Enter First Name:");
                                    contact.FirstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter Last Name:");
                                    contact.LastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter Address:");
                                    contact.Address = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter State:");
                                    contact.State = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter City:");
                                    contact.City = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter Zip:");
                                    contact.ZipCode = Convert.ToInt32(Console.ReadLine());
                                    break;
                                case 7:
                                    Console.WriteLine("Enter Phone Number:");
                                    contact.Phonenumber = Convert.ToInt64(Console.ReadLine());
                                    break;
                                case 8:
                                    Console.WriteLine("Enter Email:");
                                    contact.Emailid = Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("Enter Valid Number");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No match found");
                        }
                    }
                    break;

                // Case 3 for delete ( additional feature UC-4 )
                case 3:
                    string name1;
                    Console.WriteLine("Enter Name you want to remove: ");
                    name1 = Console.ReadLine();
                    for (int i = 0; i < people.Count; i++)
                    {
                        Contact contact = people[i];
                        //PrintPerson(contact);

                        if (contact.FirstName == name1)
                        {
                            people.RemoveAt(i);
                            Console.WriteLine(contact.FirstName + " is Removed!..");
                        }
                    }
                    break;
            }
            people.Add(contacts);
        }
        // method to preview or display information
        private static  void PrintPerson(Contact person)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Address: " + person.Address);
            Console.WriteLine("State: " + person.State);
            Console.WriteLine("City: " + person.City);
            Console.WriteLine("Zip: " + person.ZipCode);
            Console.WriteLine("Phone Number: " + person.Phonenumber);
            Console.WriteLine("Email: " + person.Emailid);
            Console.WriteLine("-------------------------------------------");
        }
        public  void ListPeople()
        {
            // here using foreach to execute set of statements multiple times depending on the result of a condition to be evaluated.
            foreach (var contacts in people)
            {
                PrintPerson(contacts);
            }
        }
    }
}
