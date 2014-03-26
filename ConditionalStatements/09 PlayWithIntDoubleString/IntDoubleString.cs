/*Write a program that, depending on the user’s choice, inputs an int, double or string variable. 
If the variable is int or double, the program increases it by one. 
If the variable is a string, the program appends "*" at the end. 
Print the result at the console. Use switch statement.*/

using System;

class IntDoubleString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please choose a type");
        Console.WriteLine("1 ---> int\n2 ---> double\n3 ---> string\n");

        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Console.Write("Please enter an int: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num + 1);
                break;
            case "2":
                Console.Write("Please enter a double: ");
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine(number + 1);
                break;
            case "3":
                Console.Write("Please enter an int: ");
                string text = Console.ReadLine();
                Console.WriteLine(text + "*");
                break;
            default:
                break;
        }
    }
}
