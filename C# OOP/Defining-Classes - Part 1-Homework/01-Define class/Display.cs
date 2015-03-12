using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Define_class
{
    class Display
    {
       private double displaySize = 1.96;
       private int displayNumberColors;

        // PROPERTIES:
                // DisplaySize
       public double DisplaySize
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
       // DisplayNumberColors
        public int DisplayNumberColors
       {
            get
           {
               return this.displayNumberColors;
           }
           set
           {
               if (displayNumberColors <= 0)
               {
                   throw new Exception("Number must be positive and non zero.");
               }
               this.displayNumberColors = value;
           }
       }

        // CONSTRUCTORS:
        public Display(double displaySize)
        {
            this.displaySize = displaySize;
        }
        public Display(double displaySize, int displayNumberColors)
        {
            this.displaySize = displaySize;
            this.displayNumberColors = displayNumberColors;
        }
    }
}
