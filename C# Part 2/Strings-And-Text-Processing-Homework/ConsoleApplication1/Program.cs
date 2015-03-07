using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _19_Dates_from_text_in_Canada
{
    class DatesFromTextInCanada
    {

        static void Main(string[] args) 
        {
            string a = "word";
            string b = a.Reverse().ToArray().ToString(); // << Doesn't work!
            string rev = new string(a.Reverse().ToArray()); // Works!
            Console.WriteLine(rev);
            Console.WriteLine(b.ToString());
       //     string some = new string()
        }
    }
}
