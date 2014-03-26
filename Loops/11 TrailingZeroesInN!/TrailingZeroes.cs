/*Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000.*/

using System;

class TrailingZeroes
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int zeroCount = 0;
        int divByFive;
        
        for (int i = 5; i <= number; i += 5)
        {
            divByFive = i;
            while (divByFive % 5 == 0)
            {
                divByFive /= 5;
                zeroCount++;
            }
        }
        Console.WriteLine(zeroCount);
    }
}
