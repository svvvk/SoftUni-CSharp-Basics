/*Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators. */

using System;

class SignOfProduct
{
    static void Main(string[] args)
    {
        Console.Write("Enter a real number: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Enter another real number: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Enter a third real number: ");
        float c = float.Parse(Console.ReadLine());

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            if (a > 0)
            {
                if (b > 0 && c > 0)
                {
                    Console.WriteLine("+");
                }
                else if (b < 0 && c < 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
            else
            {
                if (b > 0 && c > 0)
                {
                    Console.WriteLine("-");
                }
                else if (b < 0 && c < 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("+");
                }
            }
        }
    }
}