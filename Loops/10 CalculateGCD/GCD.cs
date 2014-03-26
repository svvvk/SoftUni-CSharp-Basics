/*Write a program that calculates the greatest common divisor (GCD) of given two integers a and b. 
Use the Euclidean algorithm (find it in Internet).*/

using System;

class GCD
{
    static void Main(string[] args)
    {
        Console.Write("Enter integer number a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter integer number b: ");
        int b = int.Parse(Console.ReadLine());

        int numGCD = b;
        int rest = a % b;
        int oldRest = rest;

        while (rest != 0)
        {
            rest = numGCD % oldRest;
            numGCD = oldRest;
            oldRest = rest;
        } 

        Console.WriteLine(numGCD);
    }
}
