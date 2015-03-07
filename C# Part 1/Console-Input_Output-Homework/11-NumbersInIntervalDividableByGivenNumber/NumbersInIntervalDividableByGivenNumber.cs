using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_NumbersInIntervalDividableByGivenNumber
{
    class NumbersInIntervalDividableByGivenNumber
    {
        static void Main(string[] args)
        {
      // Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the remainder of the division by 5 is 0.
            int start, end = 0;
            int p = 0;
            int result = 0;

            do
            {
                Console.WriteLine("Input positive number a:");
                start = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Input positive number b:");
                end = Int32.Parse(Console.ReadLine());
            } while (start < 0 || end < 0);
            /*
            int c = Math.Abs(start - end);
            Console.WriteLine(c);
            */

            Console.Write("Numbers = ");
            for (int i= Math.Min(start, end); i<=Math.Max(start, end); i++)
            {
                if (i%5==0)
                {
                    result = i;
                    p++;
                    Console.Write(result + ", ");
                }
            }
          
            Console.WriteLine("\np= " + p);
        }
    }
}
