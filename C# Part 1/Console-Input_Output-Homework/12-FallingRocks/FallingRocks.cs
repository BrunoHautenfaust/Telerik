using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _12_FallingRocks
{
   // STRUCTURES
    struct Rocks
      {
         public int x;
         public int y;
         public char c;
      }

    struct Dwarf
        {
         public int x;
         public int y;
         public char c;
        }

    class FallingRocks
    {
        static void PrintOnPosition(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
      
        static void Main(string[] args)
        {
            int livesCount = 5;

            Console.BufferWidth = Console.WindowWidth = 40;
            Console.BufferHeight = Console.WindowHeight = 20;

            // Create dwarf
            Dwarf d = new Dwarf();
            d.x = Console.WindowWidth - 20;
            d.y = Console.WindowHeight - 1;
            d.c = 'O';

            Random randomGenerator = new Random();

            // Create list of rocks
            List<Rocks> rocks = new List<Rocks>();
            
           
       
            while (true)
            {
                { 
                // Create a rock
                Rocks newRock = new Rocks();
                newRock.x = randomGenerator.Next(0, Console.WindowWidth);
                newRock.y = randomGenerator.Next(0);
                newRock.c = '%';
                // Add newRock to rocks list
                rocks.Add(newRock);
                }

                // Player movement
                if (Console.KeyAvailable)
                { 
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable) {Console.ReadKey(true);}     // Clears buffer that holds input keys
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if(d.x-1>=0)
                    { 
                    d.x -= 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if(d.x+1<=Console.WindowWidth-1)
                    { 
                    d.x += 1;
                    }
                }

                }
        
                // Rocks movement
                for (int i = 0; i< rocks.Count; i++)
                {
                    Rocks oldRock = rocks[i];
                    Rocks newRock = new Rocks();
                    newRock.x = oldRock.x;
                    newRock.y = oldRock.y+1;
                    newRock.c = oldRock.c;
                    rocks.Remove(oldRock);
                    if (newRock.y == d.y && newRock.x == d.x)
                    {
                        livesCount--;
                    }
                    if (newRock.y < Console.WindowHeight)
                    {
                        rocks.Add(newRock);
                    }
                }

                    // Rock-Player collision


                    // Clear console
                    Console.Clear();
                // Redraw console
                PrintOnPosition(d.x, d.y, d.c);
                foreach (Rocks rock in rocks) 
                {
                    PrintOnPosition(rock.x, rock.y, rock.c);
                }

                // Draw info

                // Slow down program
                Thread.Sleep(150);

            }
        }
    }
}
