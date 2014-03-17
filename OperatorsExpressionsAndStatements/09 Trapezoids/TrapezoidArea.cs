//Write an expression that calculates trapezoid's area by given sides a and b and height h. 

using System;

class TrapezoidArea
{
    static void Main(string[] args)
    {
        Console.Write("Enter side a of the trapezoid: ");
        float a = float.Parse(Console.ReadLine());
        
        Console.Write("Enter side b of the trapezoid: ");
        float b = float.Parse(Console.ReadLine());
        
        Console.Write("Enter the height of the trapezoid: ");
        float h = float.Parse(Console.ReadLine());

        float area = ((a + b)/2) * h;

        Console.WriteLine("The area of the trapezoid is: {0}", area);
    }
}
