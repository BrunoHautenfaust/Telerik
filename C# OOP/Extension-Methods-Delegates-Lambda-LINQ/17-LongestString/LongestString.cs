using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program to return the string with maximum length from an array of strings. Use LINQ.

namespace _17_LongestString
{
    class LongestString
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "Lombardia", "Toscana", "Calabria", "Trentino-Alto Adige/Südtirol" };

            var longestString = (from word in arr             
                                 orderby word.Length
                                 select word).LastOrDefault();

            Console.WriteLine(longestString);
        
        }
    }
}
