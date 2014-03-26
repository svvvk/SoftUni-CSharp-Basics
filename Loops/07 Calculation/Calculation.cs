/*In combinatorics, the number of ways to choose k different members out of a group of n different elements 
(also known as the number of combinations) is calculated by the following formula: n! / (k! * (n-k)!).
For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. 
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
Try to use only two loops.*/

using System;

class Calculation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter n and k (1 < k < n < 100), each on a new line:");

        double n = double.Parse(Console.ReadLine());
        double k = double.Parse(Console.ReadLine());

        double result = Factorial(n) / (Factorial(k) * Factorial(n - k));

        Console.WriteLine(result);
    }

    static double Factorial(double num)
    {
        double factorial = 1;

        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}
