using System;

class FormattingNumbers
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        string binaryNumber = Convert.ToString(firstNumber, 2).PadLeft(10, '0');

        Console.WriteLine("{0, -10:X}|{1, 10}|{2, 10:0.00}|{3, -10:0.000}|", firstNumber, binaryNumber, secondNumber, thirdNumber);   
    }
}

