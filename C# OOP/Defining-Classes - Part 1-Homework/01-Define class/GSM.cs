using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Define_class
{
    class GSM
    {
        private string model = null;
        private string manufacturer = null;
        private decimal price = 0;
        private string owner = null;

        private static string IPhone4S = null;

        // PROPERTIES:
        // Model
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value must not be null.");
                }
                this.model = value;
            }
        }
        // Manufacturer
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value must not be null.");
                }
                this.manufacturer = value;
            }
        }
        // Price
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (price <= 0)
                {
                    throw new Exception("Number must be positive and non zero.");
                }
                this.price = value;
            }
        }
        // Owner
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value must not be null.");
                }
                this.owner = value;
            }
        }

        // IPhone4S
        //    public static string IPhone4S { get; set; }

        // CONSTRUCTORS:
        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }
        public GSM(string model, string manufacturer, decimal price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }
        public GSM(string model, string manufacturer, decimal price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }

        public override string ToString()
        {
            StringBuilder GSMinfo = new StringBuilder();
            GSMinfo.Append("model: " + model)
            .Append("\nmanufacturer: " + manufacturer)
             .Append("\nprice: " + price)
              .Append("\nowner: " + owner);
            return GSMinfo.ToString();
        }

        Battery b = new Battery("Nokia", 9);
        Display d = new Display(0.5);
    }
}
