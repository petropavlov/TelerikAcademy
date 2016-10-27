using System;

class ExchangeNumbers
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double exchange = 0;

        if (firstNumber > secondNumber)
        {
            exchange = firstNumber;
            firstNumber = secondNumber;
            secondNumber = exchange;
            Console.WriteLine("{0} {1}", firstNumber, secondNumber);
        }
        else
        {
            Console.WriteLine("{0} {1}", firstNumber, secondNumber);
        }
    }
}

