using System;

class asd
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool result = (number % 5 == 0 && number % 7 == 0) ? true : false;
        if (result == true)
        {
            Console.WriteLine("true {0}", number);
        }
        else
        {
            Console.WriteLine("false {0}", number);
        }
    }

}