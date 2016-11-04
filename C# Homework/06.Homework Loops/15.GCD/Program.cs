using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GCD
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] splitInput = input.Split(new[] { " " }, StringSplitOptions.None);
        int[] intNumbers = Array.ConvertAll(splitInput, int.Parse);

        int firstNumber = intNumbers[0];
        int secondNumber = intNumbers[1];
        int temp = 0;
        int devisor = 1;

        do
        {
            temp = firstNumber / secondNumber;
            devisor = firstNumber - (temp * secondNumber);
            firstNumber = secondNumber;
            secondNumber = devisor;
        } while (devisor != 0 || devisor < 0);

        Console.WriteLine(firstNumber);
    }
}

