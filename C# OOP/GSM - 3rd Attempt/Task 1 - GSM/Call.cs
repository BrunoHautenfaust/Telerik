
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


        // ToString:
        public override string ToString()
        {
            StringBuilder callInfo = new StringBuilder();
            callInfo.AppendFormat("Date: {0}\n", Date)
                .AppendFormat("Dialed Number: {0}\n", DialedNumber)
                .AppendFormat("Duration: {0}\n", Duration);
            return callInfo.ToString();
        }
        

    }
}
