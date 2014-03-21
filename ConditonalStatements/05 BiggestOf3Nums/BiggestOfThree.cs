// Write a program that finds the biggest of three numbers. 

using System;

class BiggestOfThree
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer number: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Enter another integer number: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Enter a third integer number: ");
        float c = float.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine(a);
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine(b);
        }
        else if (c >= a && c >= b)
        {
            Console.WriteLine(c);
        }
    }
}
