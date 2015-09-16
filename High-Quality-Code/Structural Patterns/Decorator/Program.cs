using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program                                            // Price doesn't work.
    {                 
        static void Main(string[] args)
        {
            Sandwich sandwich = new Sandwich();
            sandwich.Details();
            Console.WriteLine("\n============");
            var sandwichWithHam = new Ham(sandwich);
            sandwichWithHam.Details();
            Console.WriteLine("\n============");
            var sandwichWithLettuce = new Lettuce(sandwich);
            sandwichWithLettuce.Details();
        }
    }
}
