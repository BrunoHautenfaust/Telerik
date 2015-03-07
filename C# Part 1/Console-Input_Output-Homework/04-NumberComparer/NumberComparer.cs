using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            /*Write a program that gets two numbers from the console and prints the greater of them.
            Try to implement this without if statements.*/

            Console.WriteLine("Input number 1:");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input number 2:");
            double n2 = double.Parse(Console.ReadLine());
            double greater = Math.Max(n1, n2);
            Console.WriteLine(greater);


        }
    }
}
