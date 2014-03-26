/*Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). 
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. */

using System;

class MinMaxSumAverage
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the n sequence of integer numbers: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        double numsSum = 0;

        Console.WriteLine("Enter each number of the sequence on a new line:");

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            numsSum += numbers[i];
        }

        Array.Sort(numbers);

        int min = numbers[0];
        int max = numbers[numbers.Length - 1];
        double average = numsSum / numbers.Length;

        Console.WriteLine("Min number: {0}", min);
        Console.WriteLine("Max number: {0}", max);
        Console.WriteLine("The sum of the numbers: {0}", numsSum);
        Console.WriteLine("The average of the numbers: {0:0.00}", average);
    }
}
