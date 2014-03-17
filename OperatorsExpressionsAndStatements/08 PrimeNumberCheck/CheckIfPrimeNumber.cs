//Write an expression that checks if given positive integer number n (n ≤ 100) is prime.

using System;
using System.Text;

class CheckIfPrimeNumber
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Enter a number in the range n ≤ 100: ");
        sbyte number = sbyte.Parse(Console.ReadLine());

        while (number > 100 || number < 0)      //check if the number is in the range
        {
            Console.WriteLine("Invalid input!");
            Console.Write("Enter a number in the range n ≤ 100: ");
            number = sbyte.Parse(Console.ReadLine());
        }

        byte counter = 0;

        for (byte i = 1; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                counter++;      //count by how many numbers can the number be devided without remainder
                if (counter > 2 || number == 1)
                {
                    Console.WriteLine("The number {0} is not prime", number);
                    break;
                }
            }
        }

        if (counter < 2 && number != 1)
        {
            Console.WriteLine("The number {0} is prime", number);
        }
    }
}
