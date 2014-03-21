// Write a program that finds the biggest of five numbers by using only five if statements. 

using System;

class BiggestOfFive
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        float b = float.Parse(Console.ReadLine());
        
        Console.Write("Enter third number: ");
        float c = float.Parse(Console.ReadLine());
        
        Console.Write("Enter forth number: ");
        float d = float.Parse(Console.ReadLine());
        
        Console.Write("Enter fifth number: ");
        float e = float.Parse(Console.ReadLine());

        if (a >= b && a >= c && a >= d && a >= e)
        {
            Console.WriteLine(a);
        }
        else if (b >= a && b >= c && b >= d && b >= e)
        {
            Console.WriteLine(b);
        }
        else if (c >= b && c >= a && c >= d && c >= e)
        {
            Console.WriteLine(c);
        }
        else if (d >= b && d >= c && d >= a && d >= e)
        {
            Console.WriteLine(d);
        }
        if (e >= b && e >= c && e >= d && e >= a)
        {
            Console.WriteLine(e);
        }
    }
}
