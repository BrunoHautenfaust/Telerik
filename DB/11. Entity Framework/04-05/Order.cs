namespace _04
{
    using System;

    public class Order
    {
        public string ContactName { get; set; }

        public DateTime OrderYear { get; set; }

        public string ShipCountry { get; set; }

        public override string ToString()
        {
            return "Customer: " + this.ContactName +
                   "\t Order Year: " + this.OrderYear +
                   "\t Ship Country: " + this.ShipCountry;
        }
    }
}
