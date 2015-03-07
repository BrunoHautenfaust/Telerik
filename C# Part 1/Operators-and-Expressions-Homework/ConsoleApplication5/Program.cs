﻿using System;

class PointInsideCircleAndOutOfRectangle
{
    static void Main()
    {
        Console.Write("Enter X: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter Y: ");
        double y = double.Parse(Console.ReadLine());

        bool isInCircle = ((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= (1.5 * 1.5);
        bool isOutOfRect = x > 1 && x <= 5 && y > -1 && y <= 1;
        if (isInCircle == true && isOutOfRect == false)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("NO!");
        }

    }
}