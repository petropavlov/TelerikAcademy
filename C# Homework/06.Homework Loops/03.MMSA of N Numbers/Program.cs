using System;
using System.Linq;

class MinMaxSumOfNNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        double[] array = new double[number];

        for (int i = 0; i < number; i++)
        {
            array[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("min={0:0.00}", array.Min());
        Console.WriteLine("max={0:0.00}", array.Max());
        Console.WriteLine("sum={0:0.00}", array.Sum());
        Console.WriteLine("avg={0:0.00}", array.Average());
    }
}

