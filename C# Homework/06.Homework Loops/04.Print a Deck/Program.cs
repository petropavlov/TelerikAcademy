using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintADeck
{
    static void Main()
    {
        string input = Console.ReadLine();
        int number = 0;
        switch (input)
        {
            case "2": number = 1; break;
            case "3": number = 2; break;
            case "4": number = 3; break;
            case "5": number = 4; break;
            case "6": number = 5; break;
            case "7": number = 6; break;
            case "8": number = 7; break;
            case "9": number = 8; break;
            case "10": number = 9; break;
            case "J": number = 10; break;
            case "Q": number = 11; break;
            case "K": number = 12; break;
            case "A": number = 13; break;
            default:
                break;
        }

        string[] cards = { "2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds",
                           "3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds",
                           "4 of spades, 4 of clubs, 4 of hearts, 4 of diamonds",
                           "5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds",
                           "6 of spades, 6 of clubs, 6 of hearts, 6 of diamonds",
                           "7 of spades, 7 of clubs, 7 of hearts, 7 of diamonds",
                           "8 of spades, 8 of clubs, 8 of hearts, 8 of diamonds",
                           "9 of spades, 9 of clubs, 9 of hearts, 9 of diamonds",
                           "10 of spades, 10 of clubs, 10 of hearts, 10 of diamonds",
                           "J of spades, J of clubs, J of hearts, J of diamonds",
                           "Q of spades, Q of clubs, Q of hearts, Q of diamonds",
                           "K of spades, K of clubs, K of hearts, K of diamonds",
                           "A of spades, A of clubs, A of hearts, A of diamonds"};

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(cards[i]);
        }
    }
}

