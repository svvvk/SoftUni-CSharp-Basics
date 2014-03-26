/*In combinatorics, the Catalan numbers are calculated by the following formula: (2n)! / ((n + 1)! * n!)
Write a program to calculate the nth Catalan number by given n (1 < n < 100).*/

using System;

class CatalanNums
{
    static void Main(string[] args)
    {
        Console.Write("Enter which n catalan number you want (1 < n < 100): ");
        double n = double.Parse(Console.ReadLine());

        double catalanNum = Factorial(2 * n) / (Factorial(n + 1) * Factorial(n));

        Console.WriteLine(catalanNum);
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

