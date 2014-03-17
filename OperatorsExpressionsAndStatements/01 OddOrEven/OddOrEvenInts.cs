//Write an expression that checks if given integer is odd or even. 

using System;

class OddOrEvenInts
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        bool isOdd = n % 2 != 0;

        if (isOdd)
        {
            Console.WriteLine("Odd? {0}", isOdd);
        }
        else
        {
            Console.WriteLine("Odd? {0}", isOdd);
        }
    }
}
