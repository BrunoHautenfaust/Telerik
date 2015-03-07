using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            // Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

            Console.WriteLine("Input n:");
            int n = int.Parse(Console.ReadLine());

            // Find the bit at position p in n
            int p3 = 3;
            int p4 = 4;
            int p5 = 5;
            int mask = 1 << p;      
            int nAndMask = n & mask;  
            int bit = nAndMask >> p; 
        }
    }
}
