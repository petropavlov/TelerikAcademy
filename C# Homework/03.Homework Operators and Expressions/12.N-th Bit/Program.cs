using System;

class NthBit
{
    static void Main()
    {
        ulong firstNumber = ulong.Parse(Console.ReadLine());
        byte secondNumber = byte.Parse(Console.ReadLine());
        ulong a = 1L;
        ulong mask = a << secondNumber;
        ulong bit = firstNumber & mask;
        ulong nthBit = bit >> secondNumber;
        Console.WriteLine(nthBit);
    }
}

