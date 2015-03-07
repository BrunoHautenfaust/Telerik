using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Dates_from_text_in_Canada
{
    class DatesFromTextInCanada
    {
        /*Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
Display them in the standard date format for Canada.*/

        static void Main(string[] args) // dd.MM.yyyy
        {
            string text = @"
Lorem ipsum dolor sit amet, consectetur 25.04.1992 adipiscing elit. Nulla vehicula ac sem eu malesuada. Donec urna ipsum, iaculis ac mi sed, elementum vulputate turpis. Nam dignissim 18.12.2005 eros purus, non tristique velit facilisis non.";

            string[] arr = text.Split(' ');

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
