using System;

class BitExchange
{
    static void Main()
    {
        ulong number = 255406592; //uint.Parse(Console.ReadLine()); 00001111 00111001 00110010 00000000

        byte firstBitPosition = 3;                                     //11111111 11111111 00000000 00001111
        ulong firstMask = (ulong)1 << firstBitPosition;                //00000000 00000000 00000000 00001000 
        ulong firstMaskBit = firstMask & number;                       //00000000 00000000 00000000 00001000
        ulong firstMaskBitFill = firstMaskBit >> firstBitPosition;     //00000000 00000000 00000000 00000001

        byte secondBitPosition = 24;                                   //11111111 11111111 00000000 00001111
        ulong secondMask = (ulong)1 << secondBitPosition; //             00000001 00000000 00000000 00000000    
        ulong secondMaskBit = secondMask & number;  //                   00000001 00000000 00000000 00000000
        ulong secondMaskBitFill = secondMaskBit >> secondBitPosition; // 00000000 00000000 00000000 00000001

        ulong newNumber;
        if (secondMaskBitFill != firstMaskBitFill)
        {
            ulong exchangeNumbers = secondMaskBitFill;
            secondMaskBitFill = firstMaskBitFill;                         
            secondMask = secondMaskBitFill << secondBitPosition;        
            firstMaskBitFill = exchangeNumbers;                          
            firstMask = firstMaskBitFill << firstBitPosition;
            if (secondMaskBitFill == 0)
            {
                int newMask = ~(1 << secondBitPosition);
                newNumber = number & secondMask; 
            }
            else
            {
                int newMask = 1 << firstBitPosition;
                newNumber = number | secondMask;
            }
            if (firstMaskBitFill == 0)
            {
                int newMask = ~(1 << firstBitPosition);
                newNumber = number & firstMask;
            }
            else
            {
                int newMask = 1 << firstBitPosition;
                newNumber = number | firstMask;
            }
        }
        else
        {
            newNumber = number;
        }
        
        string numberToPrint = Convert.ToString((int)newNumber, 2);
        Console.WriteLine(numberToPrint); // 00001110 00111001 00110010 00001000
    }
}
