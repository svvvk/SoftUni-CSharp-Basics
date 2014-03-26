/*Write a program that enters 3 real numbers and prints them sorted in descending order. 
Use nested if statements. 
Don’t use arrays and the built-in sorting functionality.*/

using System;

class SortNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter a real number: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Enter another real number: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Enter a third real number: ");
        float c = float.Parse(Console.ReadLine());

        if (a >= b)
        {
            if (a >= c && b >= c)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            else if (a >= c && b < c)
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }
            else if (c >= a)
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
        }
        else if (b > a)
        {
            if (a >= c && b >= c)
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            else if (c >= a && b >= c)
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
            else if (c >= b)
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }
    }
}
