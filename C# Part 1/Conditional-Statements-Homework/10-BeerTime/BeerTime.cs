using System;
using System.Globalization;

namespace _10_BeerTime
{
    class BeerTime
    {
        static void Main()
        {
            /*A beer time is after 1:00 PM and before 3:00 AM.
      Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.*/


            Console.WriteLine("Enter time in format \"hh:mm tt\":");
            string text = Console.ReadLine();

          //  string format = "hh:mm tt";
            DateTime time = DateTime.Parse(text);
           // DateTime time = DateTime.ParseExact(text, format, CultureInfo.InvariantCulture);   sashtoto kato gornoto
           // Console.WriteLine(time);

            DateTime before = Convert.ToDateTime("03:00 am");
            DateTime after = Convert.ToDateTime("01:00 pm");

            if (time < before || time >=after)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }


           

        }
    }
}
