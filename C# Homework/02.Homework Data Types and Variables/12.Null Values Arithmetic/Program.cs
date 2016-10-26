using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine(a + b);
        string c = null;
        int d = 123;
        Console.WriteLine(a + b + c + d);
    }
}

