/*Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
in given integer number n has value of 1.*/

using System;

class BitAtGivenPosition
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter which bit to check: ");
        int p = int.Parse(Console.ReadLine());

        int nRightP = n >> p;
        int bit = nRightP & 1;

        bool isBitOne = bit == 1;

        Console.WriteLine("The bit at position {0} of the number {1} is 1: {2}", p, n, isBitOne);
    }
}
