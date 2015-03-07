using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Extract_e_mails
{
    class Program
    {
        /*Write a program for extracting all email addresses from given text.
All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.*/

        static void Main(string[] args)
        {
            Console.WriteLine("Input an e-mail:");
            string mail = Console.ReadLine(); //"banica@abv.bg";

            // identifier:
            int identifierEnd = mail.IndexOf('@');
            string identifier = mail.Substring(0, identifierEnd);

            // host:
            int hostStart = identifierEnd + 1;
            int hostEnd = mail.IndexOf('.');
            int difference = hostEnd - hostStart;
            string host = mail.Substring(hostStart, difference);

            // domain
            int domainStart = hostEnd + 1;
            string domain = mail.Substring(domainStart);
          
            Console.WriteLine("<identifier>: {0}", identifier);
            Console.WriteLine("<host>: {0}", host);
            Console.WriteLine("<domain>: {0}", domain);
        }
    }
}
