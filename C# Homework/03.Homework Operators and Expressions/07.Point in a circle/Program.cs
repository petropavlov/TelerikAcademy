using System;

class PointInACircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double point = 0;
        double result = Math.Sqrt((Math.Pow((point - x), 2)) + (Math.Pow((point - y), 2)));
        if (result <= 2)
        {
            Console.WriteLine("yes {0:0.00}", result);
        }
        else
        {
            Console.WriteLine("no {0:0.00}", result);
        }
    }
}

