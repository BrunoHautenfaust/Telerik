using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age?");
            string ageWord = Console.ReadLine();
            byte age = byte.Parse(ageWord);
            Console.WriteLine("You're {0}-years old. After 10 years you'll be {1}-years old.", age, age+10);
        }
    }
}
