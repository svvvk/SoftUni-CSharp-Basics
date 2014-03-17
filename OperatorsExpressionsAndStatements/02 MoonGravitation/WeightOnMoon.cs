/*The gravitational field of the Moon is approximately 17% of that on the Earth. 
Write a program that calculates the weight of a man on the moon by a given weight on the Earth. */

using System;

class WeightOnMoon
{
    static void Main(string[] args)
    {
        Console.Write("Enter your weight: ");
        float weightOnEarth = float.Parse(Console.ReadLine());
        float weightOnMoon = weightOnEarth * 17 / 100;

        Console.WriteLine("You weight {0} kilos on the moon", weightOnMoon);
    }
}
