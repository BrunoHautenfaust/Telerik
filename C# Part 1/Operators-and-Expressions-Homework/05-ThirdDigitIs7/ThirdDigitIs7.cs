using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            // Write an expression that checks for given integer if its third digit from right-to-left is 7.

            bool digitIs7 = true;
            Console.WriteLine("Input an integer:");
            int n = int.Parse(Console.ReadLine());
            int divide = n / 100;
            int check = divide % 10;
            
            if (check == 7)
            {
                Console.WriteLine(digitIs7);
            }
            else
            {
                Console.WriteLine(!digitIs7);
            }
            

        }
    }
}
