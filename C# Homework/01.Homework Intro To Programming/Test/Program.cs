using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        DateTime enterDate = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", CultureInfo.InvariantCulture);
        DateTime currendDate = DateTime.Now;

        if (currendDate.Month > enterDate.Month)
        {
            Console.WriteLine(currendDate.Year - enterDate.Year);
            Console.WriteLine((currendDate.Year - enterDate.Year) + 10);
        }
        if (currendDate.Month < enterDate.Month)
        {
            Console.WriteLine((currendDate.Year - enterDate.Year) - 1);
            Console.WriteLine((currendDate.Year - enterDate.Year) + 9);
        }
        if (currendDate.Month == enterDate.Month)
        {
            if (currendDate.Day > enterDate.Day)
            {
                Console.WriteLine(currendDate.Year - enterDate.Year);
                Console.WriteLine((currendDate.Year - enterDate.Year) + 10);
            }
            if (currendDate.Day < enterDate.Day)
            {
                Console.WriteLine((currendDate.Year - enterDate.Year) - 1);
                Console.WriteLine((currendDate.Year - enterDate.Year) + 9);
            }
        }
    }
}

