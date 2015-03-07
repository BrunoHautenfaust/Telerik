using System;
using System.Collections.Generic;
using System.Text;

class DecimalToBinary
{
    static void Main(string[] args)
    {
        // Write a program to convert decimal numbers to their binary representation.

        Console.WriteLine("Input a decimal number:");
        int number = int.Parse(Console.ReadLine());
        int result = number;
        List<int> list = new List<int>();
        
        while (result != 0)
        {
          int remainder = result % 2;
       //     Console.WriteLine(remainder);
          list.Add(remainder);
            result = result / 2;
            remainder = result;


        }
        list.TrimExcess();
        list.Reverse();
        Console.WriteLine("Binary representation: ");
        foreach (int item in list)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}

