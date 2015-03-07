using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ExtractBit3
{
    class ExtractBit3
    {
        static void Main(string[] args)
        {
            
            /*
             Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
            The bits are counted from right to left, starting from bit #0.
            The result of the expression should be either 1 or 0.  
             */
            int p = 3;
            uint n = 200;                  // 11001000
            int mask = 1 << p;             // 00001000
            int nAndMask = (int)n & mask;  // 00001000
            int result = nAndMask >> p;    // 00000001
            Console.WriteLine(result);
        }
    }
}
