using System;
using System.Linq;

class Workdays
{
    static void Main(string[] args)
        {
    /*Write a method that calculates the number of workdays between currentDate and given date, passed as parameter.
    Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified
    preliminary as array.*/

            Console.WriteLine("Input date in format dd/MM/YYYY:");
        
        int[] date = Console.ReadLine().Split('/').Select(x => Convert.ToInt32(x)).ToArray();
        /*   
            foreach (var item in date)
            {
                Console.WriteLine(item);
            }
        */

            DateTime currentDate = DateTime.Today;
            DateTime endDate = new DateTime(date[2], date[1], date[0]);
        //    Console.WriteLine(currentDate);
        //    Console.WriteLine(endDate);

            int timeLength = Math.Abs((endDate - currentDate).Days);
            if (currentDate > endDate)
            {
                currentDate = endDate;
                endDate = DateTime.Today;
            }

            DateTime[] holidays = {
            new DateTime(2015, 01, 01), new DateTime(2015, 03, 03), new DateTime(2015, 05, 24),
            new DateTime(2015, 09, 06),new DateTime(2015, 09, 22), new DateTime(2015, 11, 01)};

            int workingDays = 0;
            bool isHoliday = false;
            for (int i = 0; i < timeLength; i++)
            {
                currentDate = currentDate.AddDays(1);

                if (currentDate.DayOfWeek != DayOfWeek.Saturday || currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    for (int j = 0; j < holidays.Length; j++)
                    {
                        if (currentDate == holidays[j])
                        {
                            isHoliday = true;
                            break;
                        }
                    }
                    if (!isHoliday)
                    {
                        workingDays++;
                    }
                    isHoliday = false;
                }
            }
            Console.WriteLine("There are {0} working days until the date you entered.", workingDays);
    
    }
}
