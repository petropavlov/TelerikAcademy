using System;

class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double perimeter = 2.0 * (width + height);
        double area = width * height;
        Console.WriteLine("{0:0.00} {1:0.00}", area, perimeter);
    }
}

