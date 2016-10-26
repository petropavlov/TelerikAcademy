using System;

class Interval
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int difference = Math.Abs(firstNumber - secondNumber);
        int counter = 0;

        if (firstNumber > secondNumber)
        {
            firstNumber -= 1;
            secondNumber += 1;
            for (int i = secondNumber; i <= firstNumber; i++)
            {
                if (i % 5 == 0)
                {
                    counter += 1;
                }
            }
        }
        if (firstNumber < secondNumber)
        {
            firstNumber += 1;
            secondNumber -= 1;
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                if (i % 5 == 0)
                {
                    counter += 1;
                }
            }
        }

        Console.WriteLine(counter);
    }
}

