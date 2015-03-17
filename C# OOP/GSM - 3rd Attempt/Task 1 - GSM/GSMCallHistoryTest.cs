
using System;
using System.Collections.Generic;
namespace Task_1___GSM
{
    class GSMCallHistoryTest
    {
        GSM theGSM = new GSM("W610i", "Sony Ericsson", 59.99m, "Pesho",
               new Battery("G502", 350, 7, BatteryType.LiPo), new Display(1.96, 2), new List<Call>());

        public static DateTime testCallDate1 = new DateTime(2015, 03, 15, 17, 50, 23);
        public static DateTime testCallDate2 = new DateTime(2015, 03, 15, 20, 20, 05);
        public static DateTime testCallDate3 = new DateTime(2015, 03, 17, 11, 45, 00);
     
        // Create test calls
        public Call[] testCalls = 
        {
            new Call(testCallDate1, 0889111111, 5),
            new Call(testCallDate2, 0889222222, 10),
            new Call(testCallDate3, 0889333333, 3)
        };

        // Add test calls to call history         @!@?!?!?!?!

	
    }
}
