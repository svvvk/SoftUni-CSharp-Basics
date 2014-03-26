// Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max].

using System;

class RandomNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter min: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Enter max(min <= max): ");
        int max = int.Parse(Console.ReadLine());

        if (max < min)
        {
            Console.WriteLine("Max is smaller than min!");
        }
        else
        {
            Random randomGenerator = new Random();

            for (int i = 0; i < n; i++)
            {
                if (i + 1 == n)
                {
                    Console.Write(randomGenerator.Next(min, max + 1));
                }
                else
                {
                    Console.Write(randomGenerator.Next(min, max + 1) + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
