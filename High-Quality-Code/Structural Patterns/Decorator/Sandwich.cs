using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Sandwich : SandwichComponent
    {
        private decimal price = 0.50m;

        public Sandwich()
        {
        }

        public override void Details()
        {
            Console.Write("Price: " + this.GetPrice() + "\n");
            Console.Write("Ingredients: \t");
            Console.Write("bread, ");
        }

        public override decimal GetPrice()
        {
            return this.price;
        }
    }
}
