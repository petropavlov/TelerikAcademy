using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int loopNumber = input;
        int forNumber = 1;
        int j;

        for (int i = 1; i <= input; i++)     
        {
            for (j = forNumber; j <= loopNumber; j++)
            {
                if (j < loopNumber)
                {
                    Console.Write("{0} ",j);
                }
                if (j == loopNumber)
                {
                    Console.WriteLine("{0}", j);
                }
            }
            loopNumber++;
            forNumber++;
        }
    }
}

