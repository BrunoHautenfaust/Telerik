using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            // Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

            Console.WriteLine(3%1);
            Console.WriteLine("Input a positive integer:");
            int n = int.Parse(Console.ReadLine());

            bool prime = true;
            if (n >= 1 && n <= 100)
            {
                for(int i=2; i<=100; i++)
                {
                    if (n % i == 0)
                    { 
                        Console.WriteLine(prime);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(!prime);
                        break;
                    }
                  
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
