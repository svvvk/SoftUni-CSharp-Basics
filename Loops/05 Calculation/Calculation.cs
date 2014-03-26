/*Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. 
Print the result with 5 digits after the decimal point.*/

using System;

class Calculation
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer number n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter an integer number x: ");
        int x = int.Parse(Console.ReadLine());

        double s = 1;

        for (int i = 1; i <= n; i++)
        {
            s += (Factorial(i) / Exponentiation(x, i));
        }

        Console.WriteLine("{0:F5}", s);
    }

    static double Exponentiation(int number, int times)
    {
        double result = 1;

        for (int i = 0; i < times; i++)
        {
            result *= number;
        }

        return result;
    }

    static double Factorial(int num)
    {
        double factorial = 1;

        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}
