﻿/*Write a program that applies bonus score to given score in the range [1…9] by the following rules:
•	If the score is between 1 and 3, the program multiplies it by 10.
•	If the score is between 4 and 6, the program multiplies it by 100.
•	If the score is between 7 and 9, the program multiplies it by 1000.
•	If the score is 0 or more than 9, the program prints “invalid score”.
*/

using System;

class BonusScore
{
    static void Main(string[] args)
    {
        Console.Write("Enter a num in the range [1..9]");
        sbyte num = sbyte.Parse(Console.ReadLine());

        switch (num)
        {
            case 1:
                Console.WriteLine(num * 10);
                break;
            case 2:
                Console.WriteLine(num * 10);
                break;
            case 3:
                Console.WriteLine(num * 10);
                break;
            case 4:
                Console.WriteLine(num * 100);
                break;
            case 5:
                Console.WriteLine(num * 100);
                break;
            case 6:
                Console.WriteLine(num * 100);
                break;
            case 7:
                Console.WriteLine(num * 1000);
                break;
            case 8:
                Console.WriteLine(num * 1000);
                break;
            case 9:
                Console.WriteLine(num * 1000);
                break;
            default:
                Console.WriteLine("Invalid score");
                break;
        }
    }
}
