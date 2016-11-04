using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


class TrailingZeroInNFacturial
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());       
        BigInteger firstFacturial = 1;
               
        // Calculate the facturial
        for (uint i = 1; i <= firstNumber; i++)
        {
            firstFacturial *= i;          
        }

        string number = Convert.ToString(firstFacturial);
        char[] splitNumber = number.ToArray();
        Array.Reverse(splitNumber);
        int counter = 0;

        for (int i = 0; i < splitNumber.Length; i++)
        {
            if (splitNumber[i] == '0')
            {
                counter += 1;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(counter);
       
    }
}

