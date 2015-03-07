using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Number_as_array
{
    class NumberAsArray
    {
        static void Main(string[] args)
        {
            /*Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.*/

        int num1 = 0;
        int num2 = 0;

        do
        {
            Console.WriteLine("Input number 1:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input number 2:");
            num2 = int.Parse(Console.ReadLine());
        } while (num1 > 99999 || num2 > 99999);

       string num1str = num1.ToString();
       string num2str = num2.ToString();

       char[] num1Arr = num1str.ToCharArray();
       char[] num2Arr = num2str.ToCharArray();

       Console.WriteLine(num1Arr.ToString()
           );

        Array.Reverse(num1Arr);
        Array.Reverse(num2Arr);

        }
    }
}
