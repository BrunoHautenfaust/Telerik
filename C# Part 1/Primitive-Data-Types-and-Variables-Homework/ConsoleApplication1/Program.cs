using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.123234354545356456456456456440;
            float v = 0.3353453453454354354545345435345434545345454f;
            Console.WriteLine(a);
            Console.WriteLine(v);
            Console.WriteLine(a + v);
            Console.Write((a + v) == 1.33f);

        }
    }
}
