/*Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, 
on a single line, separated by a space.*/

using System;

class NumsOneToN
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive integer number: ");
        uint num = uint.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            if (i + 1 > num)
            {
                Console.Write(i);
            }
            else
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}
