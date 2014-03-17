//Write an expression that checks for given integer if its third digit from right-to-left is 7. 

using System;

class IsThirdDigit7
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        num = num / 100;    //remove the last 2 digits

        bool thirdDigit7 = num % 10 == 7;   //check if the third digit is 7

        if (thirdDigit7)
        {
            Console.WriteLine("The third digit is 7");
        }
        else
        {
            Console.WriteLine("The third digit is not 7");
        }
    }
}
