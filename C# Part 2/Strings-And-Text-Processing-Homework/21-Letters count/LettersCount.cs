using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Letters_count
{
    class LettersCount
    {
        // Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            char[] letters = Console.ReadLine().ToCharArray();

            Dictionary<char, int> dict = new Dictionary<char, int>();

            // Fill and Count:
            foreach (char l in letters)
            {
                if (!dict.ContainsKey(l))
                {
                    dict.Add(l, 1);
                }
                else
                {
                    dict[l]++;
                }
            }

            // Print:
            Console.WriteLine("\nLetter occurence count:\n{0}\n",
                 string.Join("\n", dict.Select(x => string.Format(@"'{0}' -> {1} time(s)", x.Key, x.Value)).ToArray()));
        }
    }
}