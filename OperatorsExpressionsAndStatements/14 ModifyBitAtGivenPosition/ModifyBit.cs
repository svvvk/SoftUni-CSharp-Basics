/*We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n
to hold the value v at the position p from the binary representation of n while preserving all other bits in n.*/

using System;

class ModifyBit
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter a position of the bit: ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Enter a bit value (0 or 1): ");
        int v = int.Parse(Console.ReadLine());

        if (v == 0)
        {
            int mask = ~(1 << p);
            int nAndMask = n & mask;

            Console.WriteLine("The new number is: {0}", nAndMask);
        }
        else
        {
            int mask = 1 << p;
            int nOrMask = n | mask;

            Console.WriteLine("The new number is: {0}", nOrMask);
        }
    }
}
