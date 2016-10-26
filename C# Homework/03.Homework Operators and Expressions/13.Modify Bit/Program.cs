using System;

class ModifyBit
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int bitToModify = int.Parse(Console.ReadLine());
        int bitContent = int.Parse(Console.ReadLine());
        if (bitContent == 0)
        {
            ulong mask = ~((ulong)1 << bitToModify);
            ulong bit = number & mask;
            Console.WriteLine(bit);
        }
        else
        {
            ulong mask = (ulong)1 << bitToModify;
            ulong bit = number | mask;
            Console.WriteLine(bit);
        }
    }
}

