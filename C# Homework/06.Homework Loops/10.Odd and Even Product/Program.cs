using System;
using System.Linq;
using System.Numerics;

class OddAndEvenProduct
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        BigInteger productOdd = 1;
        BigInteger productEven = 1;
        string input = Console.ReadLine();

        for (int i = 0; i < numbers; i++)
        {          
            if (i % 2 != 0)
            {
                productEven *= int.Parse(input.Split(' ')[i]);
            }
            else
            {
                productOdd *= int.Parse(input.Split(' ')[i]);
            }
        }
        if (productOdd == productEven)
        {
            Console.WriteLine("yes {0}", productEven);
        }
        else
        {
            Console.WriteLine("no {0} {1}", productOdd, productEven);
        }
    }
}


