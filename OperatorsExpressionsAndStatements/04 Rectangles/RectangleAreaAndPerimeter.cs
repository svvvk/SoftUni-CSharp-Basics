using System;

class RectangleAreaAndPerimeter
{
    static void Main(string[] args)
    {
        Console.Write("Enter the height of the rectangle: ");
        float height = float.Parse(Console.ReadLine());
        
        Console.Write("Enter the width of the rectangle: ");
        float width = float.Parse(Console.ReadLine());

        Console.WriteLine("The rectangle's area is {0}", height * width);
        Console.WriteLine("The rectangle's perimeter is {0}", 2 * height + 2 * width);
    }
}
