//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class AgeAfterTenYears
{
    static void Main(string[] args)
    {
        Console.Write("Enter your current age: ");
        byte currentAge = byte.Parse(Console.ReadLine());
        byte newAge = (byte) (currentAge + 10);
        Console.WriteLine("Age now: {0}", currentAge);
        Console.WriteLine("Age after 10 years: {0}", newAge);
    }
}
