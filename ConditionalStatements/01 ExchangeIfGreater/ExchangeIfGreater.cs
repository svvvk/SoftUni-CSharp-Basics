/*Write an if-statement that takes two integer variables a and b and exchanges their values 
if the first one is greater than the second one. 
As a result print the values a and b, separated by a space. */

using System;

class ExchangeIfGreater
{
    static void Main(string[] args)
    {
        Console.Write("Enter a firest value: ");
        float a = float.Parse(Console.ReadLine()); 
        
        Console.Write("Enter a second value: ");
        float b = float.Parse(Console.ReadLine());

        if (a > b)
        {
            b = b + a;
            a = b - a;
            b = b - a;

            Console.WriteLine("{0}  {1}", a, b);
        }
        else
        {
            Console.WriteLine("{0}  {1}", a, b);
        }

    }
}
