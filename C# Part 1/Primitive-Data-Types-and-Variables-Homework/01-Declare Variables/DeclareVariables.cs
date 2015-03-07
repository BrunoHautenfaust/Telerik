using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Declare_Variables
{
    class DeclareVariables
    {
        static void Main(string[] args)
        {
            /*
             * Declare five variables choosing for each of them the most appropriate of the types
             * byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values:
             * 52130, -115, 4825932, 97, -10000.
            Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
             */
            ushort num1 = 52130;
            sbyte num2 = -115;
            uint num3 = 4825932;
            byte num4 = 97;
            short num5 = -10000;
        
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);
        }
    }
}
