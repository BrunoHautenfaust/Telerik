using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool digitIs7 = true;
            Console.Write("Enter number : ");
            int number = Int32.Parse(Console.ReadLine());

            number = number / 100;
            int thirdDigit = number % 10;

            if (thirdDigit == 7)
            {
                Console.WriteLine("Third digit 7?");
                Console.WriteLine("- True");
            }
            else
            {
                Console.WriteLine("Third digit 7?");
                Console.WriteLine("- False");

            }
        }
    }
}