using System;

class StringsAndObjects
{
    static void Main()
    {
        string firstWord = "Hello";
        string secondWord = "World";
        object twoWords = firstWord + " " + secondWord;
        string newWord = Convert.ToString(twoWords);
        Console.WriteLine(newWord);
    }
}

