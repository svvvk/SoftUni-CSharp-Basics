//Write an expression that extracts from given integer n the value of given bit at index p. 

using System;

class BitFromInteger
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter which bit to extract: ");
        int p = int.Parse(Console.ReadLine());

        int nRightP = n >> p;
        int bit = nRightP & 1;

        Console.WriteLine("The bit at position {0} of the number {1} is {2}",p , n, bit);
    }
}
