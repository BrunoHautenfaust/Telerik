using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroSubset
{
    class ZeroSubset
    {
        static void Main(string[] args)         
        {
            /*We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
    Assume that repeating the same subset several times is not a problem.*/
            /*
            Console.WriteLine("Input number 1:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number 2:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number 3:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number 3:");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number 3:");
            int e = int.Parse(Console.ReadLine());
            */
            int a = 1;
            int b = 3;
            int c = -4;
            int d = -2;
            int e = -1;

            int[] arr = { a, b, c, d, e };

            //  Console.WriteLine(arr.Length);


            // a + ...      
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[0] + arr[i] == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", arr[0], arr[i]);
                }
            }

            // a + b + ...
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[0] + arr[1] + arr[i] == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", arr[0], arr[1], arr[i]);
                }
            }
            // a + b + c + ...
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[0] + arr[1] + arr[2] + arr[i] == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", arr[0], arr[1], arr[2], arr[i]);
                }
            }
            // a + b + c + d + e
            if (a + b + c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
            }


            // Experiment:
            // b + i     
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[1] + arr[i] == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", arr[1], arr[i]);
                }
            }

            // c + i
            for (int i = 3; i < arr.Length; i++)
            {
                if (arr[2] + arr[i] == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", arr[2], arr[i]);
                }
            }
            // d + e
            if (d + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", d, e);
            }
            // Experiment 2:
            // b + c + i   
            for (int i = 3; i < arr.Length; i++)
            {
                if (arr[1] + arr[2] + arr[i] == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", arr[1], arr[2], arr[i]);
                }
            }
            // c + d + i   
            if (c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
            }
        }

    }
}