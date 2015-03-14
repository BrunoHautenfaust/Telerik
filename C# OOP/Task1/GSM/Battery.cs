
namespace GSM
{
    public enum BatteryType             // Is this suppose to be here or inside the class?
    {
        LiIon, LiPo, NiMH, NiCd
    }

    class Battery
    {
        //battery characteristics
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType batteryType = new BatteryType();

        // CONSTRUCTORS:
        public Battery(string model, int hoursIdle, int hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType batteryType)
            : this(model, hoursIdle, hoursTalk)
        {
            this.batteryType = batteryType;
        }
      
    }
}
