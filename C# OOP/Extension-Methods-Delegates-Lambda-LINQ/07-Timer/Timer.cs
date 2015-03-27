using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

// Using delegates write a class Timer that can execute certain method at each t seconds.

namespace _07_Timer
{
    public delegate void SimpleDelegate(string param);

    public class Timer
    {
        public static void Main()
        {
            Console.WriteLine("Input seconds interval:");
            int t = int.Parse(Console.ReadLine());
            t *= 1000;
            var timer = new System.Timers.Timer(t);
            // Hook up the Elapsed event for the timer. 
            timer.Elapsed += OnTimedEvent;
            timer.Enabled = true;

            Console.WriteLine("Press the Enter key to exit the program... ");
            Console.ReadLine();
            Console.WriteLine("Timer stopped.");
        }

        public static void MethodCalledByDelegate(string param)
        {
            Console.WriteLine("Hey! {0}", param);
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            SimpleDelegate sd = new SimpleDelegate(MethodCalledByDelegate);
            sd = MethodCalledByDelegate;
            sd("I want pizza!");
        }
    }
}

