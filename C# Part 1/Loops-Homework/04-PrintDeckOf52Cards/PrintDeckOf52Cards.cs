using System;

    class PrintDeckOf52Cards
    {
        static void Main()      // XXXXXXXXXXXXX
        {
            /*Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
    The card faces should start from 2 to A.
    Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.*/
                
            string[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            string[] suits = {" of spades", " of hearts", " of clubs", " of diamonds"};
           
            for (int i = 0; i < cards.Length; i++)
            {
                Console.Write(cards[i]);
                
                for (int j = 0; j < suits.Length; j++)
                {
                    Console.Write(suits[j]+", "+cards[i]);
                }
                Console.WriteLine();
               
            }
     

        }
    }

