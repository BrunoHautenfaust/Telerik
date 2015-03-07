using System;
using System.Linq;

class SumIntegers
{
    static void Main(string[] args)
    {
        /*You are given a sequence of positive integer values written into a string, separated by spaces.
    Write a function that reads these values from given string and calculates their sum.
        Example:
        input	            output
        "43 68 9 23 318"	461*/

        Console.WriteLine("Input numbers separated by space:");
        string text = Console.ReadLine();
        int[] numbers = text.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

        /*  OBSOLETE:
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine(sum);
        */

        Console.WriteLine("The sum is: " + numbers.Sum());
    }
}

