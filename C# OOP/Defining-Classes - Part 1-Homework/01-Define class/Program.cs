using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Define_class
{
   
    class Program
    {

        static void Main(string[] args)
        {
            GSM g = new GSM("W610i", "Sony Ericsson", 199.90m, "Pesho");
           Console.WriteLine(g.ToString());
        
           
        }
    }
}
