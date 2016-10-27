using System;

class IntDoubleString
{
    static void Main()
    {
        string type = Console.ReadLine();
        string inputValue = Console.ReadLine();
        double number;

        switch (type)
        {
            case "integer":
                number = double.Parse(inputValue) + 1;
                Console.WriteLine(number);
                break;
            case "real":
                number = double.Parse(inputValue) + 1;
                Console.WriteLine("{0:0.00}", number);
                break;
            case "text":
                Console.WriteLine(inputValue + '*');
                break;
            default:
                break;
        }
    }
}

