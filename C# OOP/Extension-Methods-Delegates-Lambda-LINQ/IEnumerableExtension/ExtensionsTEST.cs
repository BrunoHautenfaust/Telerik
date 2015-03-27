using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Implement a set of extension methods for IEnumerable<T> that implement the following group functions:
 sum, product, min, max, average.*/

namespace IEnumerableExtension
{
    class ExtensionsTEST
    {
        static void Main(string[] args)
        {
            int[] arrInt = new int[] { 1, 2, 3, 4, 5 };
            double[] arrDouble = new double[] { 1.5, 2.3, 3.2, 4.4, 5 };
            string[] arrString = new string[] { "abc", "defg", "hi"};

            // Sum
            Console.WriteLine("Sum Int: {0}", arrInt.Sum());
            Console.WriteLine("Sum Double: {0}", arrDouble.Sum());
            Console.WriteLine("Sum String: {0}\n", arrString.Sum());

            // Product
            Console.WriteLine("Product Int: {0}", arrInt.Product());
            Console.WriteLine("Product Double: {0}\n", arrDouble.Product());

            // Average
            Console.WriteLine("Average Int: {0}", arrInt.Average());
            Console.WriteLine("Average Double: {0}\n", arrDouble.Average());

            // Min
            Console.WriteLine("Min Int: {0}", arrInt.Min());
            Console.WriteLine("Min Double: {0}", arrDouble.Min());
            Console.WriteLine("Min String: {0}\n", arrString.Min()); // << Doesn't return the smallest string, for some reason

            // Max
            Console.WriteLine("Max Int: {0}", arrInt.Max());
            Console.WriteLine("Max Double: {0}", arrDouble.Max());
            Console.WriteLine("Max String: {0}\n", arrString.Max());        
        }
    }
}
