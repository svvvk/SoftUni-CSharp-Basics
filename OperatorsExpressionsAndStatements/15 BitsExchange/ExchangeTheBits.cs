//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. 

using System;

class ExchangeTheBits
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive number: ");
        uint number = uint.Parse(Console.ReadLine());

        Console.WriteLine("Number {0} represented binary: ", number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        string bits345 = GetBits345(number);    //a method that returns bits 3, 4 and 5 as string
        string bits242526 = GetBits242526(number);      //a method that returns bits 24, 25 and 26 as string

        int p = 3;

        for (int i = 0; i < 3; i++)
        {
            if (bits242526[i] == '1')   //check if the new bit needs to be 1 or 0
            {
                int mask = 1 << p;
                number = (uint) (number | mask);
            }
            else
            {
                int mask = ~(1 << p);
                number = (uint) (number & mask);
            }

            p++;
        }

        p = 24;

        for (int i = 0; i < 3; i++)
        {
            if (bits345[i] == '1')
            {
                int mask = 1 << p;
                number = (uint)(number | mask);
            }
            else
            {
                int mask = ~(1 << p);
                number = (uint) (number & mask);
            }

            p++;
        }

        Console.WriteLine("New number {0} represented binary: ", number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }

    static string GetBits345(uint number)
    {
        int p = 3;
        string bits345 = null;
        
        for (int i = 0; i < 3; i++)
        {
            uint nRightP = number >> p;
            int bit = (int) nRightP & 1;

            bits345 += bit;     //get the 3, 4 and 5 bit and concatenate them as a string
            p++;
        }

        return bits345;
    }

    static string GetBits242526(uint number)
    {
        int p = 24;
        string bits242526 = null;

        for (int i = 0; i < 3; i++)
        {
            uint nRightP = number >> p;
            int bit = (int) nRightP & 1;

            bits242526 += bit;      //get the 24, 25 and 26 bit and concatenate them as a string
            p++;
        }

        return bits242526;
    }
}
