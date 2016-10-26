using System;

class ThirdBit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine()); // 10000000000
        int mask = 1 << 3;                          //        1000
        int numberAndMask = number & mask;          // 00000000000
        int thirdBit = numberAndMask >> 3;          // 00000000000
        Console.WriteLine(thirdBit);
    }
}

