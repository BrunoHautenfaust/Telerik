using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Date_in_Bulgarian
{
    class DateInBulgarian
    {
        /*Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.*/

        static void Main(string[] args)
        {

            Console.WriteLine("Input date in format\"dd.MM.yyyy H:mm:ss\"");

            string input1 = Console.ReadLine(); // 27.02.2006 12:56:34
            //  Console.WriteLine(date1.ToString(format));

            DateTime date1 = DateTime.Parse(input1);
            DateTime date2 = date1.AddHours(6.5);

            // Cyrillic and BG day of week:
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo bulgarian = new CultureInfo("bg-BG");
            string day = bulgarian.DateTimeFormat.GetDayName(date2.DayOfWeek);

            string format = "dd.MM.yyyy H:mm:ss";
        
            Console.WriteLine(date2.ToString(format)+" "+day);
        }
    }
}
