using System;

class BiggestOfThree
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber == secondNumber && secondNumber == thirdNumber)
        {
            Console.WriteLine(firstNumber);
        }
        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine(firstNumber);
        }
        if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine(secondNumber);
        }
        if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            Console.WriteLine(thirdNumber);
        }
    }
}

