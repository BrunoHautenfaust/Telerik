using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ModifyBitAtGivenPosition
{
    class ModifyBitAtGivenPosition
    {
        static void Main(string[] args)
        {
            /*We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.*/

            int mask = 0;
            Console.WriteLine("Input n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input p:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Input v(0 or 1):");
            int v = int.Parse(Console.ReadLine());
            if (v == 0)
            {   
                // Set the bit at position p to 0 in a number n
                                 
                mask = ~(1 << p);          
                int result = n & mask;     
                Console.WriteLine(result); 
                Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
            }
            else
            {
                // Set the bit at position p to 1 in a number n

                mask = 1 << p;
                int result = n | mask;
                Console.WriteLine(result);
                Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
            }


        }
    }
}
