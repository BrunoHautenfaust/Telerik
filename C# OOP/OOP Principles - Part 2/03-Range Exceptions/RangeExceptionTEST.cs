using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Range_Exceptions
{
    class RangeExceptionTEST
    {
        static void Main(string[] args)
        {

            // InvalidRangeException<int> 
            try
            {
                int number = 450;

                if (number < 1 || number > 100)
                {
                    throw new InvalidRangeException<int>(1, 100);
                }
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(new string('=', 40));

            // InvalidRangeException<DateTime>
            try
            {
                DateTime dateTime = new DateTime(2014, 5, 5);  
                DateTime firstDate = new DateTime(1980, 1, 1);
                DateTime lastDate = new DateTime(2013, 12, 31);

                if (dateTime < firstDate || dateTime > lastDate)
                {
                    throw new InvalidRangeException<DateTime>(firstDate, lastDate);
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}