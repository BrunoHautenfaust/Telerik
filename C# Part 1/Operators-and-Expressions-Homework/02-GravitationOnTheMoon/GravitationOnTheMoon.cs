using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            /*
              The gravitational field of the Moon is approximately 17% of that on the Earth.
              Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
              */
            Console.WriteLine("Input weight:");
            string text = Console.ReadLine();
            double weight = double.Parse(text);
            double moonWeight = 0.17 * weight;
            Console.WriteLine(moonWeight);
        }
    }
}
