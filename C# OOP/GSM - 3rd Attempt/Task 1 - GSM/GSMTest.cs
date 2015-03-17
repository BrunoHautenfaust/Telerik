
using System;
namespace Task_1___GSM
{
    class GSMTest
    {
        static void Main(string[] args)
        {
            GSM myGSM = new GSM("W610i", "Sony Ericsson", null, "Pesho",
               new Battery("G502", null, null, BatteryType.LiPo), new Display(null, null));

           Console.WriteLine(myGSM.ToString());                        //  cw myGSM works too!! HOW?!
           Console.WriteLine(GSM.iPhone);

            // GSM Array
           GSM[] GSMarray = new GSM[3];
           GSM phone1 = new GSM("Asha 302", "Nokia", 350.00m, "Gancho", new Battery("BL-5J", 707, 9, BatteryType.LiIon), new Display(2.4, 4));
           GSM phone2 = new GSM("Galaxy S5", "Samsung", 750.00m, "Dragan", new Battery("Z710", 390, 21, BatteryType.LiIon), new Display(5.1, 4));
           GSM phone3 = new GSM("T6S", "ThL", 980.00m, "Ivan", new Battery("BST-37", 200, 14, BatteryType.LiPo), new Display(3.5, 2));

           GSMarray[0] = phone1;
           GSMarray[1] = phone2;
           GSMarray[2] = phone3;

           foreach (var phone in GSMarray)
           {
               Console.WriteLine(phone);
           }
        }
    }
}
