using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Define_class
{
    class Battery
    {
        public enum BatteryType
        {
            Li_Ion, NiMH, NiCd, Li_Po
        }

       private string batteryModel = "Li-Po";
       private double batteryHoursIdle = 350;
       private double batteryHoursTalk = 7;

        // PROPERTIES:
             // BatteryModel
        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value must not be null.");
                }
                this.batteryModel = value;
            }
        }
             // BatteryHoursIdle
        public double BatteryHoursIdle
        {
            get
            {
                return this.batteryHoursIdle;
            }
            set
            {
                if (batteryHoursIdle <= 0)
                {
                    throw new Exception("Number must be positive and non zero.");
                }
                this.batteryHoursIdle = value;
            }
        }
             // BatteryHoursTalk
        public double BatteryHoursTalk
        {
            get
            {
                return this.batteryHoursTalk;
            }
            set
            {
                if (batteryHoursIdle <= 0)
                {
                    throw new Exception("Number must be positive and non zero.");
                }
                this.batteryHoursTalk = value;
            }
        }

        // CONSTRUCTORS:
        public Battery(string batteryModel, double batteryHoursIdle)
        {
            this.batteryModel = batteryModel;
            this.batteryHoursIdle = batteryHoursIdle;
        }
       
          public Battery(string batteryModel, double batteryHoursIdle, double batteryHoursTalk)
        {
            this.batteryModel = batteryModel;
            this.batteryHoursIdle = batteryHoursIdle;
            this.batteryHoursTalk = batteryHoursTalk;
        }

    }
}
