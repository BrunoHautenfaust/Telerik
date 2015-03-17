
using System;
using System.Text;
namespace Task_1___GSM
{
    class Call
    {
        public DateTime Date { get; set; }
        public int DialedNumber { get; set; }
        public int Duration { get; set; }


        // CONSTRUCTOR
        public Call()
        {

        }

        public Call(DateTime date, int dialedNumber, int duration)
        {
            this.Date = date;
            this.DialedNumber = dialedNumber;
            this.Duration = duration;
        }

        
        //// ToString:
        //public override string ToString()
        //{
        //    StringBuilder callInfo = new StringBuilder();
        //    callInfo.AppendFormat("Date: {0}\n", date)
        //        .AppendFormat("Dialed Number: {0}\n", dialedNumber)
        //        .AppendFormat("Duration: {0}\n", duration);
        //    return callInfo.ToString();
        //}
        

    }
}
