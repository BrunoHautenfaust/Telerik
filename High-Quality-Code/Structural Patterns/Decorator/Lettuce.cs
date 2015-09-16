using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Lettuce: Decorator
    {
        private decimal price = 0.70m;
        public Lettuce(SandwichComponent sComponent)
            : base(sComponent)
        {
        }

        public override void Details()
        {
            base.Details();
            Console.Write("lettuce, ");
        }

        public override decimal GetPrice()
        {
            return this.price + base.GetPrice();
        }
    }
}
