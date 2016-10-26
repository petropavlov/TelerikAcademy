using System;

class PrintTheAsciiTable
{
    static void Main()
    {
        for (int i = 33; i < 127; i++)
        {
            char firstSymbol = (char)i;
            Console.Write(firstSymbol);
        }      
    }
}

