﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_PrintSequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 12; i++)
            {
                if (i % 2 == 0)
                { 
                    Console.Write(i+", ");
                }
                else
                {
                    Console.Write(-i + ", ");
                }
            }    
        }
    }
}
