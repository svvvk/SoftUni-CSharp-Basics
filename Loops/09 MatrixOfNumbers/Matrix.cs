/*Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
and prints a matrix like in the examples below. Use two nested loops. */

using System;

class Matrix
{
    static void Main(string[] args)
    {
        Console.Write("Enter n in the range n (1 <= n <= 20): ");
        byte n = byte.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 1 + i; j <= n + i; j++)
            {
                Console.Write("{0, 3}", j);
            }
            Console.WriteLine();
        }
    }
}
