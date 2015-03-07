using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Date_difference
{
    class DateDifference
    {
        /*Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
        Example:

        Enter the first date: 27.02.2006
        Enter the second date: 3.03.2006
        Distance: 4 days
         */
                    // dd.mm.YYYY  << THIS FORMAT DOESN'T WORK! mm.YYYY return 0s

        static void Main(string[] args)
        {
           
            Console.WriteLine("Input 2 dates (on separate lines) in format dd.MM.yyyy:");
            string input1 = Console.ReadLine(); // "27.02.2006"
            string input2 = Console.ReadLine();  //  "3.03.2006"

            // Conversions and calculations:
            DateTime date1 = DateTime.Parse(input1);
            DateTime date2 = DateTime.Parse(input2);

            string format = "dd.MM.yyyy";
            Console.WriteLine(date1.ToString(format));

            TimeSpan distance = date1 - date2;
            double result = Math.Abs(distance.TotalDays);

            Console.WriteLine("The number of days between {0} and {1} is {2}", input1, input2, result);
        }
    }
}
