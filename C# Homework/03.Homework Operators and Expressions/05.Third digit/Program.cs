using System;

class ThirdDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int thirddigit = (number / 100) % 10;
        if (thirddigit == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}", thirddigit);
        }
    }
}

