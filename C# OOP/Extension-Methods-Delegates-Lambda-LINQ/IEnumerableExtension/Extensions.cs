/*Implement a set of extension methods for IEnumerable<T> that implement the following group functions:
 sum, product, min, max, average.*/

using System;
using System.Linq;
using System.Collections.Generic;
namespace IEnumerableExtension
{
    public static class Extensions
    {
        // Sum
        public static T Sum<T>(this IEnumerable<T> elements)
        {
            dynamic sum = default(T);
            foreach (var item in elements)
            {
                sum += item;
            }
            return sum;
        }

        // Product
        public static T Product<T>(this IEnumerable<T> elements)
        {
            dynamic product = 1;
            foreach (var item in elements)
            {
                product *= item;
            }
            return product;
        }

        // Average
        public static T Average<T>(this IEnumerable<T> elements)
        {
            dynamic average = default(T);

            dynamic sum = default(T);
            int count = 0;
            foreach (var item in elements)
            {
                sum += item;
                count++;
            }
            return average = sum / count;
        }

        // Min
        public static T Min<T>(this IEnumerable<T> elements) where T : IComparable
        {
            T min = elements.First<T>();    // T min = elements.Min(); => StackOverFlow. Debugger doesn't go beyond this line. WHY?
            if (typeof(T) == typeof(String))
            {
                min = elements.OrderBy(s => s.ToString().Length).First();
            }
            foreach (var item in elements)
            {
                if (item.CompareTo(min) < 0)   // Read as 'if item < min' /// I suppose '< 0' converts bool to int and makes eval possible
                {
                    min = item;
                }
            }
            return min;
        }

        // Max
        public static T Max<T>(this IEnumerable<T> elements) where T : IComparable
        {
            T max = elements.First<T>();            
            if (typeof(T) == typeof(String))
            {
                max = elements.OrderByDescending(s => s.ToString().Length).First();
            }
            else
            {
                foreach (var item in elements)
                {
                    if (item.CompareTo(max) > 0)        // Strings are compared according to their numeral values and the first letter is taken. Every next one is a number greater than the previous.
                    {
                        max = item;
                    }
                }
            }
            return max;
        }
    }
}
