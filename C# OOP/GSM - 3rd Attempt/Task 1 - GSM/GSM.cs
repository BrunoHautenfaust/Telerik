
using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1___GSM
{
    class GSM 
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery = new Battery();                               
        private Display display = new Display();                                 
        private List<Call> callHistory;

        private static GSM iPhone = new GSM("IPhone4S", "Apple", 1999.99m, "Petkan",
            new Battery("A1332", 200, 14, BatteryType.LiPo), new Display(3.5, 2));

        // PROPERTIES:
        // Iphone                                                   <<< DOES THIS DO ANYTHING?!
        public static GSM IPhone
        {
            get
            {
                return iPhone;
            }
        }

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
        public decimal? Price
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
        // Battery
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }
        // Display
        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }
        // CallHistory 
        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }

        // CONSTRUCTORS:
        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal? price, string owner)
            : this(model, manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner)
        {
            this.Battery = battery;
            this.Display = display;
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display, List<Call> callHistory)
            : this(model, manufacturer, price, owner, battery, display)
        {
            this.CallHistory = callHistory;     // Why do I create a list here like this and not where the fields are!!?
        }

        public GSM(string model, string manufacturer, List<Call> callHistory)
            : this(model, manufacturer)
        {
            this.CallHistory = callHistory; 
        }

        // METHODS

        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public void ClearHistory()
        {
            this.CallHistory.Clear();
        }

        public decimal TotalPrice(decimal price)
        {
            int totalDuration = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                totalDuration += callHistory[i].Duration;
            }
            decimal totalPrice = price * totalDuration;
            return totalPrice / 60;
        }

        //public string PrintCallHistory()
        //{
        //    return string.Format("Call history:\n{0}", string.Join(Environment.NewLine, new List<Call>(this.callHistory)));
        //}
        public string PrintCallHistory()
        {
            StringBuilder printCallhistory = new StringBuilder();
            foreach (Call call in this.callHistory)
            {
                printCallhistory.Append(call.ToString());
            }
            return printCallhistory.ToString();
        }
       

        // ToString
        public override string ToString()
        {
            StringBuilder GSMInfo = new StringBuilder();
            GSMInfo.AppendFormat("Model: {0}\n", model)
                .AppendFormat("Manufacturer: {0}\n", manufacturer)
                    .AppendFormat("Price: {0}\n", price)
                        .AppendFormat("Owner: {0}\n", owner)
             .Append(battery.ToString())
             .Append(display.ToString())
             .Append("===============");
            return GSMInfo.ToString();
        }
    }
}

