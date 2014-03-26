/*Write a program that enters from the console a positive integer n and prints all the numbers from 
1 to n not divisible by 3 and 7, on a single line, separated by a space.*/

using System;

class NotDivisibleBy3And7
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive integer number: ");
        uint num = uint.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            if (!(i % 3 == 0 || i % 7 == 0))
            {
                if (i + 1 > num)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
        Console.WriteLine();
    }
}
