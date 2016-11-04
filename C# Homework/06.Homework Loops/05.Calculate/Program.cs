using System;
using System.Numerics;

class Calculate
{
    static void Main()
    {       
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine()), s = 1, pow = 1, fact = 1;

            for (int i = 1; i <= n; i++)
            {
                pow *= x;
                fact *= i;
                s += fact / pow;
            }

            Console.WriteLine("{0:0.00000}", s);
        }
    }
}





