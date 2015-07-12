using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___PrintStatistics
{
    class PrintStatisticsTEST
    {
        public static void Main(string[] args)
        {
            Statistics s = new Statistics();
            double[] arr = {4, 3, 2};
            s.PrintStatistics(arr);
        }
    }
}
