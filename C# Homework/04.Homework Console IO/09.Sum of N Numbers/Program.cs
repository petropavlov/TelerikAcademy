using System;

class SumOfNNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());    
        double sumOfNumbers = 0;

        for (int i = 1; i <= number; i++)
        {
            double inputNumber = double.Parse(Console.ReadLine());
            sumOfNumbers += inputNumber; 
        }

        Console.WriteLine(sumOfNumbers);
    }
}

