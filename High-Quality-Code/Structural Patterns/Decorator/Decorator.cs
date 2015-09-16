using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Decorator : SandwichComponent
    {
        SandwichComponent sc= null;
        private decimal price = 0;

        public SandwichComponent SC { get; private set; }

        public Decorator(SandwichComponent sComponent)
        {
            this.SC = sComponent;
        }

        public override void Details()
        {
            this.SC.Details();
        }

        public override decimal GetPrice()
        {
            return this.price + sc.GetPrice();
        }
    }
}
