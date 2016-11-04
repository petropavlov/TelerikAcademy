using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = firstNumber + 1;
        int thirdNumber = firstNumber * 2;

        BigInteger firstFacturial = 0;
        BigInteger secondFacturial = 0;
        BigInteger thirdFacturial = 1;
  
        // Calculate facturials
        for (int i = 1; i <= thirdNumber; i++)
        {
            thirdFacturial *= i;

            if (secondNumber == i)
            {
                secondFacturial = thirdFacturial;
            }
            if (firstNumber == i)
            {
                firstFacturial = thirdFacturial;
            }
        }
        BigInteger result = thirdFacturial / (secondFacturial * firstFacturial);
        Console.WriteLine(result);
    }
}
