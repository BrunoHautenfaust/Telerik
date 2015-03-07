using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            // Write an expression that checks if given integer is odd or even.

            bool odd = true;
            Console.WriteLine("Input an integer:");
            string text = Console.ReadLine();
            int n = int.Parse(text);
            if (n % 2 == 0)
            {
                Console.WriteLine(!odd);
            }
            else
            {
                Console.WriteLine(odd);
            }

        }
    }
}
