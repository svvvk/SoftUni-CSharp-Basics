/*Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
The first and the second sequence of bits may not overlap.*/

using System;

class AdvancedBitExchange
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        long number = long.Parse(Console.ReadLine());

        Console.Write("Enter p: ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Enter q: ");
        int q = int.Parse(Console.ReadLine());

        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        bool outOfRange = (p + k > 32 || q + k > 32) || number > UInt32.MaxValue;
        bool overlapping = (p < q && p + k > q) || (q < p && q + k > p);        
        bool invalidBitPosition = p < 0 || q < 0;

        if (outOfRange)
        {
            Console.WriteLine("Out of range");
            return;
        }

        if (invalidBitPosition)
        {
            Console.WriteLine("Invalid bit position");
            return;
        }

        if (overlapping)
        {
            Console.WriteLine("Overlapping");
            return;
        }

        Console.WriteLine("Number {0} represented binary: ", number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        
        string pBits = GetPBits(number, k, p);
        string qBits = GetQBits(number, k, q);

        for (int i = 0; i < k; i++)
        {
            if (pBits[i] == '1')
            {
                long mask = 1 << q;
                number = (number | mask);
            }
            else
            {
                long mask = ~(1 << q);
                number = (number & mask);
            }

            q++;
        }

        for (int i = 0; i < k; i++)
        {
            if (qBits[i] == '1')
            {
                long mask = 1 << p;
                number = (number | mask);
            }
            else
            {
                long mask = ~(1 << p);
                number = (number & mask);
            }

            p++;
        }

        Console.WriteLine("The new number {0} represented binary: ", number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }

    static string GetPBits(long number, int k, int p)
    {
        string bits = null;

        for (int i = 0; i < k; i++)
        {
            long nRightP = number >> p;
            int bit = (int)nRightP & 1;

            bits += bit;
            p++;
        }

        return bits;
    }

    static string GetQBits(long number, int k, int q)
    {
        string bits = null;

        for (int i = 0; i < k; i++)
        {
            long nRightQ = number >> q;
            int bit = (int)nRightQ & 1;

            bits += bit;
            q++;
        }

        return bits;
    }
}
