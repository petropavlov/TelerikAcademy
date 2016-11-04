using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class DecimalToHex
{
    static void Main()
    {
        decimal input = decimal.Parse(Console.ReadLine());
        ulong number = (ulong)input;
        int counter = 0;
        decimal result;

        while (number != 0)
        {
            number = number / 16;
            counter++;
        }

        double[] hexNumber = new double[counter];

        for (int i = 0; i < hexNumber.Length; i++)
        {
            input = input / (decimal)16.0;
            result = (decimal)input % 1;
            hexNumber[i] = (double)result * 16.0;
            input = Math.Truncate(input);
        }

        Array.Reverse(hexNumber);   

        for (int i = 0; i < hexNumber.Length; i++)
        {
            if (hexNumber[i] == 10)
            {
                Console.Write("A");
            }
            if (hexNumber[i] == 11)
            {
                Console.Write("B");
            }
            if (hexNumber[i] == 12)
            {
                Console.Write("C");
            }
            if (hexNumber[i] == 13)
            {
                Console.Write("D");
            }
            if (hexNumber[i] == 14)
            {
                Console.Write("E");
            }
            if (hexNumber[i] == 15)
            {
                Console.Write("F");
            }
            if (hexNumber[i] < 10)
            {
                Console.Write(hexNumber[i]);
            }
        }
    }
}

