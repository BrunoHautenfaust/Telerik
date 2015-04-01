
using System;
using System.Text;
namespace Task_1___GSM
{
    class Display
    {
        private double? displaySize;
        private int? displayNumberOfColors;

        // PROPERTIES:
        // DisplaySize
        public double? DisplaySize
        {
            get
            {
                return this.displaySize;
            }
            set
            {
                if (displaySize <= 0)
                {
                    throw new Exception("Number must be positive and non zero.");
                }
                this.displaySize = value;
            }
        }
        // DisplayNumberOfColors
        public int? DisplayNumberOfColors
        {
            get
            {
                return this.displayNumberOfColors;
            }
            set
            {
                if (displayNumberOfColors <= 0)
                {
                    throw new Exception("Number must be positive and non zero.");
                }
                this.displayNumberOfColors = value;
            }
        }

        // CONSTRUCTORS:
        public Display()
        {

        }

        public Display(double? displaySize, int? displayNumberOfColors)
        {
            this.DisplaySize = displaySize;
            this.DisplayNumberOfColors = displayNumberOfColors;
        }

        // ToString
        public override string ToString()
        {
            StringBuilder displayInfo = new StringBuilder();
            displayInfo.AppendFormat("Display Size: {0} inches\n", displaySize)
                .AppendFormat("Number of colors: {0}\n", displayNumberOfColors);
            return displayInfo.ToString();
        }

    }
}
