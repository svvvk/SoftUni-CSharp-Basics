//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class DivideBy7And5
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        bool divideBy7And5 = n % 5 == 0 && n % 7 == 0;

        if (divideBy7And5)
        {
            Console.WriteLine("Divided by 5 and 7? {0}", divideBy7And5);
        }
        else
        {
            Console.WriteLine("Divided by 5 and 7? {0}", divideBy7And5);
        }
    }
}
