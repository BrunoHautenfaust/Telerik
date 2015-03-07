using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Isosceles_Triangle
{
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            char c = '\u00A9';
            Console.WriteLine("{0,4}", c);
            Console.WriteLine("{0,3}{0,2}", c);
            Console.WriteLine("{0,2}{0,4}", c);
            Console.WriteLine("{0}{0,2}{0,2}{0,2}", c);
        }
    }
}
