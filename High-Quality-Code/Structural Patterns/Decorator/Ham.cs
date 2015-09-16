using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Ham : Decorator
    {
        private decimal price = 1.50m;

        public Ham(SandwichComponent sComponent)
            : base(sComponent)
        {
        }

        public override void Details()
        {
            base.Details();
            Console.Write(" ham,");
        }

        public override decimal GetPrice()
        {
            return this.price + base.GetPrice();
        }
    }
}
