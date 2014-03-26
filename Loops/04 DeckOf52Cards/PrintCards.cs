/*Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). 
The card faces should start from 2 to A. Print each card face in its four possible suits: 
clubs, diamonds, hearts and spades. */

using System;

class PrintCards
{
    static void Main(string[] args)
    {
        string[] cards = new string[13]{
            "2", "3", "4", "5",
            "6", "7", "8", "9",
            "10", "J", "Q", "K", 
            "A"
        };

        string[] cardTypes = new string[4]{
            "♣", "♦", "♥", "♠"
        };

        for (int i = 0; i < cards.Length; i++)
        {
            for (int j = 0; j < cardTypes.Length; j++)
            {
                if (j + 1 == cardTypes.Length)
                {
                    Console.Write(cards[i] + cardTypes[j]);
                }
                else
                {
                    Console.Write(cards[i] + cardTypes[j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
