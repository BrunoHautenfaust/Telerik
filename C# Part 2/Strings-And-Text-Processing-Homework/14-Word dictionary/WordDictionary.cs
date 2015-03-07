using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Word_dictionary
{
    class WordDictionary
    {
        /*A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
Sample dictionary:

input:	        output:
.NET	        platform for applications from Microsoft
CLR	managed     execution environment for .NET
namespace	    hierarchical organization of classes
         */

        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string,string>();
            dict.Add(".Net", "platform for applications from Microsoft");
            dict.Add("CLR managed", "execution environment for .NET");
            dict.Add("namespace", "hierarchical organization of classes");

            Console.WriteLine("Enter a word to see translation:");
            string word = Console.ReadLine();

            if (dict.ContainsKey(word))
            {
                Console.Write(dict[word]+'\n');
            }
            else
            {
                Console.WriteLine("Word not present in dictionary.");
            }
        }
    }
}
