using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SumOf5Numbers     
{
    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
        // Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
            Console.WriteLine("Input 5 numbers in a single line, separated by a space:");
            string text = Console.ReadLine();
            string [] textArr = text.Split(' ');
            double [] arr = new double[textArr.Length];
            for (int i=0; i<arr.Length; i++)
            {
               arr[i] = Convert.ToDouble(textArr[i]);
            }
            /*   COUNT:
            int count = arr.Length;
            Console.WriteLine("Number count: "+count);
            */
            double sum = 0;
            for (int i=0; i<arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
          

        }
    }
}
