using System;

class ComparingFloats
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        double number;
        if (firstNumber < secondNumber)
        {
            number = secondNumber - firstNumber;
        }
        else
        {
            number = firstNumber - secondNumber;
        }
        if (number >= eps)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("true");
        }
    }
}

