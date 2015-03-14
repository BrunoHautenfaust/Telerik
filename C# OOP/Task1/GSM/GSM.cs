
namespace GSM
{
    using System.Text;

    class GSM
    {
       public string model;
       public string manufacturer;
       public decimal price;
       public string owner;

        Battery battery = new Battery("Nokia", 7, 5);
        Display display = new Display(12.5, 3);

        // CONSTRUCTORS:
        public GSM(string model, string manufacturer, decimal price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner)
        {
            this.battery = battery;
            this.display = display;
        }
      
        // ToString
        public override string ToString()
        {
            StringBuilder gsmInfo = new StringBuilder();
            gsmInfo.AppendFormat("Model: {0}\n", model)
                .AppendFormat("Manufacturer: {0}\n", manufacturer)
                  .AppendFormat("Price: {0}\n", price)
                    .AppendFormat("Owner: {0}\n", owner);
            return gsmInfo.ToString();
        }

    }
}
