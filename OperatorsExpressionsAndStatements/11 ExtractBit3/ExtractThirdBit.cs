/*Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0. 
The result of the expression should be either 1 or 0. */

using System;

class ExtractThirdBit
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer number: ");
        int n = int.Parse(Console.ReadLine());
        int p = 3;
        
        int nRightP = n >> p;
        int bit = nRightP & 1;

        Console.WriteLine("The third bit (starting from bit #0) is {0}", bit);
    }
}
