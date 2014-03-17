/*Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
and out of the rectangle R(top=1, left=-1, width=6, height=2).*/

using System;

class PointInCircleOutsideRectangle
{
    static void Main(string[] args)
    {
        float x = float.Parse(Console.ReadLine());
        float y = float.Parse(Console.ReadLine());

        float circleX = 1;
        float circleY = 1;
        float circleR = 1.5f;

        float pointPosition = (float)(Math.Sqrt(Math.Pow((x - circleX), 2) + Math.Pow((y - circleY), 2)));

        bool insideCircle = pointPosition <= circleR;
        bool outsideRectangle = x > 5 || x < -1 || y > 1 || y < -1;

        if (insideCircle && outsideRectangle)
        {
            Console.WriteLine("The point is inside the circle and outside the rectangle");
        }
        else
        {
            Console.WriteLine("The point is not inside the circle and outside the rectangle");
        }
    }
}
