using System;

class NumbersFromOneToN
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            if (i < number)
            {
                Console.Write("{0} ", i);
            }
            if (i == number)
            {
                Console.Write("{0}", i);
            }
        }
    }
}

