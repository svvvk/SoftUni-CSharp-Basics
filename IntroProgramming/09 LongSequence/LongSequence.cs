﻿//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … 

using System;

class LongSequence
{
    static void Main(string[] args)
    {
        for (int i = 2; i <= 1001; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write(i * -1 + " ");
            }
            else
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}
