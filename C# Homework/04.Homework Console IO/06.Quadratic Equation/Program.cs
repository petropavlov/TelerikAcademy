using System;

class QuadraticEquation
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        double discriminant = (Math.Pow(secondNumber, 2)) - (4 * firstNumber * thirdNumber);
        double firstRoot;
        double secondRoot;
        if (discriminant > 0)
        {
            firstRoot = ((-secondNumber) + (Math.Sqrt(discriminant))) / (2 * firstNumber);
            secondRoot = ((-secondNumber) - (Math.Sqrt(discriminant))) / (2 * firstNumber);
            if (firstRoot > secondRoot)
            {
                Console.WriteLine("{0:0.00}", secondRoot);
                Console.WriteLine("{0:0.00}", firstRoot);
            }
            else
            {
                Console.WriteLine("{0:0.00}", firstRoot);
                Console.WriteLine("{0:0.00}", secondRoot);
            }
        }
        if (discriminant == 0)
        {
            firstRoot = (-secondNumber) / (2 * firstNumber);
            Console.WriteLine("{0:0.00}", firstRoot);
        }
        if (discriminant < 0)
        {
            Console.WriteLine("no real roots");
        }
    }
}

