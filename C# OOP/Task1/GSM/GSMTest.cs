using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class GSMTest
    {
        public static void Main()
        {
            GSM myGSM = new GSM("Sony ERcs", "Sony ERRR", 124.56m, "Pesho", BatteryType.LiPo, 12.3); 
            // I can't create this object. Argument5: cannont convert from GSM.BatteryType to GSM.Battery. What gives!?
            // Display has 2 fields. I have an instance of it in GSM. Yet I don't know how to set it here so I can create myGSM

        }
    }
}
