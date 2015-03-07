using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OneSystemToAnyOther
{
    static void Main()
    {
        SplashScreen();
        Menu();
       

    }
    static ConsoleKeyInfo SplashScreen()
    {
        string logo = @"
######## ####                                                                          ####
######## ####                                             ##########                   ####
####     ####                                             ####   #### #### #######     ####
######## ####  ######### #########  #########  ####  #### ####   #### #### ####### ########
######## #### ####  #### ###   #### ###   #### ####  #### ##########       ####  ##########
####     #### ####  #### ###    ### ###    ### ####  #### ####   #### #### ####  ####   ###
####     #### ####  #### ###   #### ###   ####  ######### ####   #### #### ####  ##########
####     ####  ######### #########  #########       ##### ##########  #### ####   #########
                         ####       ####        ########                               
                         ####       ####        ######  
";

        int horizontalAllign = Console.WindowWidth / 2;
        int verticalAllign = Console.WindowHeight / 2 - 8;
        Console.SetCursorPosition(horizontalAllign, verticalAllign);
        Console.CursorVisible = false;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(logo);
        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Threading.Thread.Sleep(1200);
        Console.SetCursorPosition(horizontalAllign - 15, verticalAllign + 15);
        Console.WriteLine("P R E S S    S T A R T");
        Console.ResetColor();
        var key = Console.ReadKey(true);
        return key;
        
    }



    static public ConsoleKeyInfo Menu()
    {
        Console.Clear();
        Console.CursorVisible = false;
        Console.WriteLine(@"
                                      #####    ##### ############ ######    #####  ####    ####
                                      ######  ###### ####         #######   #####  ####    ####
                                      ############## ###########  ##### ##  #####  ####    ####
                                      #####    ##### ###########  #####  ## #####  ####    #### 
                                      #####    ##### ####         #####   #######  ####    ####  
                                      #####    ##### ############ #####    ######    ######## ");


        Console.WriteLine();
        Console.SetCursorPosition(Console.WindowWidth / 2 - 7, Console.WindowHeight / 2 - 7);
        Console.WriteLine("1. START GAME");
        Console.SetCursorPosition(Console.WindowWidth / 2 - 7, Console.WindowHeight / 2 - 6);
        Console.WriteLine("2. SCORE");
        Console.SetCursorPosition(Console.WindowWidth / 2 - 7, Console.WindowHeight / 2 - 5);
        Console.WriteLine("3. EXIT");
        var result = Console.ReadKey(true);
        return result;

    }

}