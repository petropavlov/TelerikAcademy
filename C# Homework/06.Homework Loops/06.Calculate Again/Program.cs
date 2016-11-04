using System;
using System.Numerics;

class CalculateAgain
{
    static void Main()
    {
        ulong firstNumber = ulong.Parse(Console.ReadLine());
        ulong secondNumber = ulong.Parse(Console.ReadLine());
        BigInteger firstFacturial = 1;
        BigInteger secondFacturial = 0;

        for (uint i = 1; i <= firstNumber; i++)
        {
            firstFacturial *= i;

            if (secondNumber == i)
            {
                secondFacturial = firstFacturial;
            }
        }


        BigInteger result = firstFacturial / secondFacturial;
        Console.WriteLine(result);
    }
}


 