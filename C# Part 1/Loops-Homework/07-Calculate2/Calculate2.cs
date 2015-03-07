using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _07_Calculate2
{
    class Calculate2
    {
        static void Main(string[] args)
        {
    /* combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.*/

            BigInteger n = 0;
            BigInteger k = 0;
            BigInteger factN = 1;
            BigInteger factK = 1;
            BigInteger fact2 = 1;

            do
            {
                Console.WriteLine("Input n:");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Input k:");
                k = int.Parse(Console.ReadLine());
            } while (1 > k || k > n || n > 100);

            for (int i = 1; i <= n; i++)
            {
                factN *= i;
            }

            for (int i = 1; i <= k; i++)
            {
                factK *= i;
            }

            BigInteger nMinusK = n - k;
            for (int i = 1; i <= nMinusK; i++)
            {
                fact2 *= i;
            }
            /*
            Console.WriteLine(factN);
            Console.WriteLine(factK);
            Console.WriteLine(fact2);
            */
            Console.WriteLine(factN / (factK * fact2));
        }
    }
}
