// Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;
using System.Collections.Generic;

class Randomize
{
    static void Main(string[] args)
    {
        Console.Write("Enter integer number n: ");
        int n = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();
        Random randomGenerator = new Random();
        List<int> randomNums = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            numbers.Add(i);
        }

        while (numbers.Count > 0)
        {
            int randomElement = randomGenerator.Next(0, numbers.Count);
            randomNums.Add(numbers[randomElement]);
            numbers.Remove(numbers[randomElement]);
        }

        for (int i = 0; i < randomNums.Count; i++)
        {
            if (i + 1 == randomNums.Count)
            {
                Console.Write(randomNums[i]);
            }
            else
            {
                Console.Write(randomNums[i] + " ");
            }
        }
        Console.WriteLine();
    }
}
