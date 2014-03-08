﻿//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class AgeAfterTenYears
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your birthyear: ");
        int year = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter your birthmonth: ");
        int month = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter your birthday: ");
        int day = int.Parse(Console.ReadLine());

        DateTime yourBirthday = new DateTime(year, month, day);
        DateTime today =  DateTime.Today;
        
        if (today.Month >= yourBirthday.Month && today.Day >= yourBirthday.Day)
        {
            byte age = (byte)(today.Year - yourBirthday.Year);
            byte newAge = (byte)(age + 10);
            Console.WriteLine("Age now: {0}", age);
            Console.WriteLine("Age after 10 years: {0}", newAge);
        }
        
        else
        {
            byte age = (byte)(today.Year - yourBirthday.Year - 1);
            byte newAge = (byte)(age + 10);
            Console.WriteLine("Age now: {0}", age);
            Console.WriteLine("Age after 10 years: {0}", newAge);
        }
    }
}
