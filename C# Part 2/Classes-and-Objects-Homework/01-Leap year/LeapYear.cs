using System;

class LeapYear
{
    static void Main(string[] args)
    {

        /*Write a program that reads a year from the console and checks whether it is a leap one.
        Use System.DateTime.*/

        Console.WriteLine("Input a year:");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} {1} leap year.", year,
            DateTime.IsLeapYear(year) ? "is a" : "is not a"
        );

    }
}

