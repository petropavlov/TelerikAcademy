using System;

class PointCircleRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double point = 1;
        double result = Math.Sqrt((Math.Pow((point - x), 2)) + (Math.Pow((point - y), 2)));
        if (result <= 1.5)
        {
            Console.WriteLine("yes {0:0.00}", result);
        }
        else
        {
            Console.WriteLine("no {0:0.00}", result);
        }
    }
}

