using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Words_count
{
    class WordsCount
    {
        /*Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.*/
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string[] words = Console.ReadLine().Split(' ');

            Dictionary<string, int> dict = new Dictionary<string, int>();

            // Fill and Count:
            foreach (string w in words)
            {
                if (!dict.ContainsKey(w))
                {
                    dict.Add(w, 1);
                }
                else
                {
                    dict[w]++;
                }
            }

            // Print:
            Console.WriteLine("Words occurence count:\n{0}\n",
                 string.Join("\n", dict.Select(x => string.Format(@"'{0}' -> {1} time(s)", x.Key, x.Value)).ToArray()));
        }
    }
}
