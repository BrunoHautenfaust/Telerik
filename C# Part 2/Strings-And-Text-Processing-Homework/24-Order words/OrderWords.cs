using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Order_words
{
    class OrderWords
    {
        // Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

        static void Main(string[] args)
        {
            Console.WriteLine("Input some text:");
            string[] text = Console.ReadLine().Split(' '); // aaaa ddddd eeee fffff hhhhh

            Array.Sort(text);
            
            foreach (string s in text)
            {
                Console.WriteLine(s);
            }
        }
    }
}
