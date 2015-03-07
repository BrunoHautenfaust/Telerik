using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Parse_URL
{
    class ParseURL
    {
        /*Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
Example:

URL	
http://telerikacademy.com/Courses/Courses/Details/212
         *Information
         *[protocol] = http 
          [server] = telerikacademy.com 
          [resource] = /Courses/Courses/Details/212
         */

        static void Main(string[] args)
        {
            string url = "http://telerikacademy.com/Courses/Courses/Details/212";

            // protocol:
            int protocolEnd = url.IndexOf(":");
            string protocol = url.Substring(0, protocolEnd);

            // server:
            int serverEnd = url.IndexOf("com");
            string server = url.Substring(protocolEnd + 3, serverEnd - 4);

            // resource:
            int resourceStart = url.IndexOf(".") + 4;
            string resource = url.Substring(resourceStart);

            Console.WriteLine("[protocol]: {0}", protocol);
            Console.WriteLine("[server]: {0}", server);
            Console.WriteLine("[resource]: {0}", resource);

        }
    }
}
