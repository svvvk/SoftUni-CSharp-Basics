/*Write a program that prints an isosceles triangle of 9 copyright symbols © */

using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;     //without UTF8 the copyright symbol doesn't appear on the console

        char copyright = '©';
        int width = 7;
        int spaces = 1;

        Console.Write(new string(' ', width / 2));      //first we print the first row
        Console.Write(copyright);         
        Console.WriteLine(new string(' ', width / 2));    

        for (int i = 1; i <= 2; i++)        //here we print the second and the third row 
        {
            Console.Write(new string(' ', width / 2 - i));
            Console.Write(copyright);
            Console.Write(new string(' ', spaces));
            Console.Write(copyright);
            Console.WriteLine(new string(' ', width / 2 - i));
            spaces += 2;
        }

        for (int i = 0; i < width / 2 + 1; i++)        //finally, we print the last row
        {
            Console.Write(copyright);
            Console.Write(' ');
        }

        Console.WriteLine();
    }
}
