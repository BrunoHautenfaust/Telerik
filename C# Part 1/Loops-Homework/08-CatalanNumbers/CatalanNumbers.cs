using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _08_CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            // Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
            int n = 0;

            do
            {
                Console.WriteLine("Input n:");
                n = int.Parse(Console.ReadLine());
            } while (n < 0 || n > 100);

            BigInteger factorial = 1;
            BigInteger fact2n = 1;
            BigInteger fact1 = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            for (int i = 1; i <= 2 * n; i++)
            {
                fact2n *= i;
            }
            for (int i = 1; i <= n + 1; i++)
            {
                fact1 *= i;
            }

              BigInteger result = fact2n / (fact1 * factorial);
              Console.WriteLine(result);
        }
    }
}
