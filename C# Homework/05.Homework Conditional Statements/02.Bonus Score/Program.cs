using System;

class BonusScore
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (number >= 1 && number <= 3)
        {
            Console.WriteLine(number*10);
        }
        if (number >= 4 && number <= 6)
        {
            Console.WriteLine(number * 100);
        }
        if (number >= 7 && number <= 9)
        {
            Console.WriteLine(number * 1000);
        }
        if (number >= 10 || number <= 0)
        {
            Console.WriteLine("invalid score");
        }
    }
}

