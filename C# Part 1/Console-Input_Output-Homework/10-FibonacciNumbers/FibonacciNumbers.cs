using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
    /*Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….*/

             int first = 0;
             int second = 1;
            Console.Write("Input a number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i<n; i++)
            {
                Console.Write(first + ", ");
                int sum = first + second;
                first = second;
                second = sum;
            }
         
            }
        }
    }

