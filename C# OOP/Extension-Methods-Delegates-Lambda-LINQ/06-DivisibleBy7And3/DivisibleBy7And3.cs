using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
 Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.*/

namespace _06_DivisibleBy7And3
{
    class DivisibleBy7And3                            
    {
        static void Main(string[] args)
        {
              var numbers2 = new List<int>() {1, 3, 21, 7, 14, 56, 9, 42 };

            // Lambda:
              var query1 = numbers2.FindAll(x => (x % 3 == 0) && (x % 7 == 0));

              Console.WriteLine("Numbers divisible by 7 and 3 (lambda):");
              Console.WriteLine(string.Join(Environment.NewLine, query1));
              Console.WriteLine(new string('=', 30));

            // LINQ:
              var query2 = from number in numbers2
                               where number % 3 == 0 && number % 7 == 0
                               select number;
                               
              Console.WriteLine("Numbers divisible by 7 and 3 (LINQ):");
              Console.WriteLine(string.Join(Environment.NewLine, query2));
              Console.WriteLine(new string('=', 30));

        }
    }
}
