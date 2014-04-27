using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Input_and_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string companyName, address, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, managerPhoneNumber;

            Console.Write("Enter the name of the company:");
            companyName = Console.ReadLine();
            Console.Write("Enter the address of the company:");
            address = Console.ReadLine();
            Console.Write("Enter the phone number of the company:");
            phoneNumber = Console.ReadLine();
            Console.Write("Enter the fax number of the company:");
            faxNumber = Console.ReadLine();
            Console.Write("Enter the web site of the company:");
            webSite = Console.ReadLine();
            Console.Write("Enter the first name of the manager:");
            managerFirstName = Console.ReadLine();
            Console.Write("Enter the last name of the manager:");
            managerLastName = Console.ReadLine();
            Console.Write("Enter the age of the manager:");
            int managerAge = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the phone number of the manager:");
            managerPhoneNumber = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Company name: " + companyName);
                Console.WriteLine("Address: " + address);
                Console.WriteLine("Phone number: " + phoneNumber);
                Console.WriteLine("Fax number: " +  faxNumber);
                Console.WriteLine("Web site: " + webSite);
                Console.WriteLine("Manager: " + managerFirstName + " " + managerLastName);
                Console.WriteLine("Manager's age: " + managerAge);
                Console.WriteLine("Manager's phone number: " + managerPhoneNumber);
            
        }
    }
}
