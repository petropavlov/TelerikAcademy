using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] array = input.ToCharArray();
        Array.Reverse(array);
        int[] intHexNumbers = new int[array.Length];
        ulong result = 0;

        for (int i = 0; i < array.Length; i++)
        {
            switch (array[i])
            {
                case '0': intHexNumbers[i] = 0; break;
                case '1': intHexNumbers[i] = 1; break;
                case '2': intHexNumbers[i] = 2; break;
                case '3': intHexNumbers[i] = 3; break;
                case '4': intHexNumbers[i] = 4; break;
                case '5': intHexNumbers[i] = 5; break;
                case '6': intHexNumbers[i] = 6; break;
                case '7': intHexNumbers[i] = 7; break;
                case '8': intHexNumbers[i] = 8; break;
                case '9': intHexNumbers[i] = 9; break;
                case 'A': intHexNumbers[i] = 10; break;
                case 'B': intHexNumbers[i] = 11; break;
                case 'C': intHexNumbers[i] = 12; break;
                case 'D': intHexNumbers[i] = 13; break;
                case 'E': intHexNumbers[i] = 14; break;
                case 'F': intHexNumbers[i] = 15; break;
                default:
                    break;
            }
        }

        for (int i = 0; i < intHexNumbers.Length; i++)
        {
            result = result + ((ulong)intHexNumbers[i] * (ulong)Math.Pow(16, i));
        }

        Console.WriteLine(result);
    }
}

