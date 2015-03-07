using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_CheckBitAtGivenPosition
{
    class CheckBitAtGivenPosition
    {
        static void Main(string[] args)
        {
            // Write a Boolean expression that returns 'true' if the bit at position p
            // (counting from 0, starting from the right) in a given integer number n, has value of 1.

            Console.WriteLine("Input n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input p:");
            int p = int.Parse(Console.ReadLine());
            
            int mask = 1 << p;        
            int nAndMask = n & mask;  
            int bit = nAndMask >> p;
            bool bitIs1 = true;
            Console.WriteLine(Convert.ToString(bit, 2).PadLeft(32, '0'));

            if (bit == 1)
            { 
                Console.WriteLine(bitIs1);
            }
            else
            {
                Console.WriteLine(!bitIs1);
            }
        }
    }
}
