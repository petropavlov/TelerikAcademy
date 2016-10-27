using System;

class BiggestOfFive
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        double fourthNumber = double.Parse(Console.ReadLine());
        double fifthNumber = double.Parse(Console.ReadLine());

        if ((firstNumber == secondNumber && secondNumber == thirdNumber && thirdNumber == fourthNumber && fourthNumber == fifthNumber) || (firstNumber > secondNumber && firstNumber > thirdNumber && firstNumber > fourthNumber && firstNumber > fifthNumber))
        {
            Console.WriteLine(firstNumber);
        }
        if (secondNumber > firstNumber && secondNumber > thirdNumber && secondNumber > fourthNumber && secondNumber > fifthNumber)
        {
            Console.WriteLine(secondNumber);
        }
        if (thirdNumber > firstNumber && thirdNumber > secondNumber && thirdNumber > fourthNumber && thirdNumber > fifthNumber)
        {
            Console.WriteLine(thirdNumber);
        }
        if (fourthNumber > firstNumber && fourthNumber > secondNumber && fourthNumber > thirdNumber && fourthNumber > fifthNumber)
        {
            Console.WriteLine(fourthNumber);
        }
        if (fifthNumber > firstNumber && fifthNumber > secondNumber && fifthNumber > thirdNumber && fifthNumber > fourthNumber)
        {
            Console.WriteLine(fifthNumber);
        }
    }
}

