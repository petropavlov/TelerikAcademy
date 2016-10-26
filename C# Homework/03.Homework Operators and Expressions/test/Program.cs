using System;
class BitSwap
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint p = uint.Parse(Console.ReadLine());
        uint q = uint.Parse(Console.ReadLine());
        uint k = uint.Parse(Console.ReadLine());

        for (int i = (int)q; i <= q + k - 1; i++)
        {
            uint checkP = (n >> (int)p) & 1;
            uint checkQ = (n >> i) & 1;

            if (checkP != checkQ)
            {
                n = n ^ ((uint)1 << (int)p);
                n = n ^ ((uint)1 << i);
            }
            p++;
        }

        Console.WriteLine(n);
    }
}