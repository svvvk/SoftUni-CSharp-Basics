/*Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop.*/

using System;

class Calculation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter n and k (1 < k < n < 100), each on a new line:");
        
        double n = double.Parse(Console.ReadLine());
        double k = double.Parse(Console.ReadLine());

        if (k >= n)
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        double result = 1;

        for (double i = k + 1; i <= n; i++)
        {
            result *= i;
        }

        Console.WriteLine(result);
    }
}
