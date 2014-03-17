//Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 

using System;

class IsPointInCircle
{
    static void Main(string[] args)
    {
        Console.Write("Enter x: ");
        float x = float.Parse(Console.ReadLine());
        
        Console.Write("Enter y: ");
        float y = float.Parse(Console.ReadLine());

        float radius = 2;
        float pointPosition = (float)(Math.Sqrt(x * x + y * y));

        if (pointPosition <= radius)
        {
            Console.WriteLine("The point is in the circle: true");
        }
        else
        {
            Console.WriteLine("The point is in the circle: false");
        }
    }
}
