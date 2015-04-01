
using System;
using System.Collections.Generic;

namespace Task_1___GSM
{
    class GSMCallHistoryTest
    {
        private const decimal price = 0.37m;

        public static DateTime testCallDate1 = new DateTime(2015, 03, 15, 17, 50, 23);
        public static DateTime testCallDate2 = new DateTime(2015, 03, 15, 20, 20, 05);
        public static DateTime testCallDate3 = new DateTime(2015, 03, 17, 11, 45, 00);

    
       public static List<Call> callHistory = new List<Call>
        {
            new Call(testCallDate1, 0889111111, 5),
            new Call(testCallDate2, 0889222222, 10),
            new Call(testCallDate3, 0889333333, 3)
        };

           GSM theGSM = new GSM("MODEL", "MANUFACTURER", callHistory);

        // Display call history
           public void DisplayCallHistory()
           {
               Console.WriteLine(theGSM.PrintCallHistory()); 
           }

           // Calculate Total price call
        public void CalculateAndPrintTotalPriceCall()
           {
            decimal totalPrice = theGSM.TotalPrice(price);
            Console.WriteLine("Total price of calls: {0}", totalPrice);
           }

        // Remove longest call
        public void RemoveLongestCall()
        {
            Call longestCall = new Call(new DateTime(1999, 5, 5, 5, 5, 5), 0, 0);

            foreach (var call in theGSM.CallHistory)
            {
                if (call.Duration >= longestCall.Duration)
                {
                    longestCall = call;
                }
            }
            theGSM.DeleteCall(longestCall);
        }
        // Calculate Total price call again
        public void CalculateAndPrintTotalPriceCallAGAIN()
        {
            decimal totalPrice = theGSM.TotalPrice(price);
            Console.WriteLine("Total price of calls: {0}", totalPrice);
        }
        // Clear callHistory and print
        public void clearHistoryAndPrint()
        {
            theGSM.ClearHistory();
            DisplayCallHistory();
        }
    }
}

