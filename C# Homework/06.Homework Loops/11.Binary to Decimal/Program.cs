using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] array = input.ToCharArray();
        ulong sum = 0;

        for (int i = 0; i < array.Length; i++)
        {

            if (i == 0 && array[i] == '1')
            {
                sum = sum + (ulong)(Math.Pow(2, (array.Length - 1)));
            }
            if (i == array.Length - 1 && array[i] == '1')
            {
                sum += 1;
            }
            if (i != array.Length - 1 && i != 0 && array[i] == '1')
            {
                sum = sum + (ulong)(Math.Pow(2, (array.Length - 1 - i)));
            }
        }
        Console.WriteLine(sum);
    }
}

