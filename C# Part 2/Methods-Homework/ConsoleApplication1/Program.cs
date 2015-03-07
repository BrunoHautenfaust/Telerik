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
            int[] arr = {0,1,2,3,4};

            for (int i = arr.Length; i >= 0; i--)
            {
                Console.Write("x^{0} = ", i);
                arr[i] = int.Parse(Console.ReadLine());
                break;
            }
        }
    }
}
