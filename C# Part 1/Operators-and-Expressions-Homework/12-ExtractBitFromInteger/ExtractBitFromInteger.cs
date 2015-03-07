using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        {
            // Write an expression that extracts from given integer 'n' the value of given bit at index p.

            Console.WriteLine("Input n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input p:");
            int p = int.Parse(Console.ReadLine());
            
            int mask = 1 << p;         
            int nAndMask = (int)n & mask; 
            int bit = nAndMask >> p;     
            Console.WriteLine(bit);
        }
    }
}
