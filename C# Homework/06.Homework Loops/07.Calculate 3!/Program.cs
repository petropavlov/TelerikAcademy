using System;
using System.Numerics;

class CalculateThreeFacturials
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        BigInteger firstFacturial = 1;
        BigInteger secondFacturial = 0;
        int difference = firstNumber - secondNumber;
        BigInteger thirdFacturial = 1;

        // Calculate first and second facturials
        for (uint i = 1; i <= firstNumber; i++)
        {
            firstFacturial *= i;

            if (secondNumber == i)
            {
                secondFacturial = firstFacturial;
            }
        }

        // Calculate difference facturial
        for (int i = 1; i <= difference; i++)
        {
           thirdFacturial *= i;
        }


        BigInteger result = firstFacturial / (secondFacturial * thirdFacturial);
        Console.WriteLine(result);
    }
}

