
using System;
using System.Text;
namespace Task_1___GSM
{
    public enum BatteryType { LiIon, LiPo, NiMH, NiCd };

    class Battery
    {
        private string batteryModel;
        private double? batteryHoursIdle;
        private double? batteryHoursTalk;
        BatteryType batteryType = new BatteryType();

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
        public double? BatteryHoursIdle
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
        public double? BatteryHoursTalk
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

        // BatteryType
        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;                          // VALIDATION !?
            }
        }

        // CONSTRUCTORS:
        public Battery()
        {

        }

        public Battery(string batteryModel, double? batteryHoursIdle, double? batteryHoursTalk)
        {
            this.BatteryModel = batteryModel;
            this.BatteryHoursIdle = batteryHoursIdle;
            this.BatteryHoursTalk = batteryHoursTalk;
        }

          public Battery(string batteryModel, double? batteryHoursIdle, double? batteryHoursTalk, BatteryType batteryType)
              : this(batteryModel, batteryHoursIdle, batteryHoursTalk)
        {
            this.BatteryType = batteryType;
        }

        // ToString
          public override string ToString()
          {
              StringBuilder batteryInfo = new StringBuilder();
              batteryInfo.AppendFormat("Battery Model: {0}\n", batteryModel)
                 .AppendFormat("Battery Hours Idle: {0}\n", batteryHoursIdle)
                     .AppendFormat("Battery Hours Talk: {0}\n", batteryHoursTalk)
                          .AppendFormat("Battery Type: {0}\n", batteryType);
              return batteryInfo.ToString();
          }


    }
}
