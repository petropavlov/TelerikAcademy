﻿using System;

class Trapezoids
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double area = 0.5 * h * (a + b);
        Console.WriteLine("{0:0.0000000}", area);
    }
}

