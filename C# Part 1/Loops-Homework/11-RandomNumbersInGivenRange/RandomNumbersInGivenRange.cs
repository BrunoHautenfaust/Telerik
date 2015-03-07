    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main(string[] args)
        {
     // Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

            int n = 0;
            int min = 0;
            int max = 0;
            do
            {
                Console.WriteLine("Input n:");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Input min:");
                min = int.Parse(Console.ReadLine());
                Console.WriteLine("Input max:");
                max = int.Parse(Console.ReadLine());
            } while (min == max);

            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
              Console.Write(r.Next(min, max+1)+", ");
            }

        }
    }
}
