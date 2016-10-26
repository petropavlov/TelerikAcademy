using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        int numberToCheck = int.Parse(Console.ReadLine());
        if (numberToCheck % 7 == 0 && numberToCheck % 5 == 0)
        {
            Console.WriteLine("true {0}", numberToCheck);
        }
        else
        {
            Console.WriteLine("false {0}", numberToCheck);
        }
    }
}
