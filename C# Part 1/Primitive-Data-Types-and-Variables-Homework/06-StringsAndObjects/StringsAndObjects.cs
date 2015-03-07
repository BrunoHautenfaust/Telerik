using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string word1 = "Hello";
            string word2 = "World";
            object concat = word1+" "+word2;
            string words = (string)concat;
            Console.WriteLine(words);
        }
    }
}
