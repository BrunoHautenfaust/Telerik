using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Random_numbers
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            // Write a program that generates and prints to the console 10 random values in the range [100, 200].

            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}/ {1}", i + 1, r.Next(100, 201));   // 201 will generate up to 200 inclusive!
            }

        }
    }
}
