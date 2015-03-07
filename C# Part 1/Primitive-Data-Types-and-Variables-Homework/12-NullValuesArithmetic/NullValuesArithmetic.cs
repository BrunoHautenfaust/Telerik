using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? i = null;
            double? d = null;
            Console.WriteLine("Null value of int i = {0}\nNull value of double d = {1}", i, d);
            i = 4;
            d = 2.4;
            Console.WriteLine("Number value of int i = {0}\nNumber value of double d = {1}", i, d);

        }
    }
}
