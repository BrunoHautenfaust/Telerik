using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            /*
             Write a Boolean expression that checks for given integer if it can be divided (without remainder)
             by 7 and 5 at the same time.
             */

            bool noRemainder = true;
            Console.WriteLine("Input an integer:");
            int n = int.Parse(Console.ReadLine());
            if ((n % 7 == 0) && (n % 5 == 0))
            {
                Console.WriteLine(noRemainder);
            }
            else
            {
                Console.WriteLine(!noRemainder);
            }

        }
    }
}
