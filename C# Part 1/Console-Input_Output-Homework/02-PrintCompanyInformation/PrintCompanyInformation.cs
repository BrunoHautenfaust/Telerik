using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            /*A company has name, address, phone number, fax number, web site and manager.
             * The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.*/
         
            // Company Info:
            Console.WriteLine("Input Company name:");
            string cName = Console.ReadLine();
            
            Console.WriteLine("Input Company address:");
            string cAddress = Console.ReadLine();
            Console.WriteLine("Input Company phone number:");
            int cPhoneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Company fax number:");
            byte cFaxNumber = byte.Parse(Console.ReadLine());
            Console.WriteLine("Input Company website:");
            string cSite = Console.ReadLine();

            // Manager Info:
            Console.WriteLine("Input Manager's first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Input Manager's last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Input Manager's age:");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Input Manager's phone number:");
            int mPhoneNumber = int.Parse(Console.ReadLine());
            
            // Output
            Console.WriteLine("================");
            Console.WriteLine("Company name: {0}\n"+
            "Company address: {1}\n"+
            "Phone number: {2}\n" +
            "Fax: {3}\n" +
            "Web site: {4}\n"+
            "Manager: {5} {6}(age: {7}, tel.{8})",
            cName, cAddress, cPhoneNumber, cFaxNumber, cSite, firstName, lastName, age, mPhoneNumber);

        }
    }
}
