using System;

class MoonGravity
{
    static void Main()
    {
        float weight = float.Parse(Console.ReadLine());
        float weightOnMoon = weight * (float)0.17;
        Console.WriteLine("{0:0.000}", weightOnMoon);
    }
}

