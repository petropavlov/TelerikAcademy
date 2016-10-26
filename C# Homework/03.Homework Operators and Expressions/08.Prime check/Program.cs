using System;

class PrimeCheck
{
    static void Main()
    {
        int numberToCheck = int.Parse(Console.ReadLine());
        if (numberToCheck <= 1)
        {
            Console.WriteLine("false");
        }
        else
        {
            if (numberToCheck == 2 || numberToCheck == 3 || numberToCheck == 5 || numberToCheck == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                if (numberToCheck % 2 == 0 || numberToCheck % 3 == 0 || numberToCheck % 5 == 0 || numberToCheck % 7 == 0)
                {
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine("true");
                }
            }
        }
    }
}

