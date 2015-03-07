using System;

class DayOfWeek
{
    static void Main(string[] args)
    {
        /*Write a program that prints to the console which day of the week is today.
        Use System.DateTime.*/

        DateTime now = DateTime.Now;
        string day = DateTime.Now.ToString("dddd");
        Console.WriteLine(day);
    }
}

