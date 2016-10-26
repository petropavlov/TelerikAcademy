using System;

class FibonacciNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        long firstFibonnaciNumber = 0;
        long secondFibonnaciNumber = 1;
        long fibonacciNumber;
        if (number == 2)
        {
            Console.Write("0, 1");
        }
        if (number == 1)
        {
            Console.Write("0");
        }
        if (number > 2)
        {
            Console.Write("0, 1, ");
            for (int i = 3; i <= number; i++)
            {
                fibonacciNumber = firstFibonnaciNumber + secondFibonnaciNumber;
                if (i < number)
                {
                    Console.Write("{0}, ", fibonacciNumber);
                }
                if (i == number)
                {
                    Console.Write("{0}", fibonacciNumber);
                }

                firstFibonnaciNumber = secondFibonnaciNumber;
                secondFibonnaciNumber = fibonacciNumber;
            }
        }

    }
}

