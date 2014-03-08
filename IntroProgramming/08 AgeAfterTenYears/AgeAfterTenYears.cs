//Print your age after ten years
using System;

class AgeAfterTenYears
{
    static void Main(string[] args)
    {
        byte currentAge = 19;
        byte newAge = (byte) (currentAge + 10);
        Console.WriteLine("Age now: {0}", currentAge);
        Console.WriteLine("Age after 10 years: {0}", newAge);
    }
}
