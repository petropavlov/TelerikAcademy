using System;

class SortThreeNumbers
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("{0} {1} {2}", firstNumber, secondNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", firstNumber, thirdNumber, secondNumber);
            }
        }
        if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("{0} {1} {2}", secondNumber, firstNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", secondNumber, thirdNumber, firstNumber);
            }
        }
        if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("{0} {1} {2}", thirdNumber, firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", thirdNumber, secondNumber, firstNumber);
            }
        }
        if (firstNumber == secondNumber && secondNumber == thirdNumber)
        {
            Console.WriteLine("{0} {1} {2}", thirdNumber, secondNumber, firstNumber);
        }
    }
}

