using System;

class IsoscalesTriangle
{
    static void Main()
    {
        char symbol = '\u0040';
        Console.WriteLine("   {0}\n", symbol);
        Console.WriteLine("  {0} {0}\n", symbol);
        Console.WriteLine(" {0}   {0}\n", symbol);
        Console.WriteLine("{0} {0} {0} {0}", symbol);
    }
}

