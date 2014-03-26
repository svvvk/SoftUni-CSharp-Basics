/*Using loops write a program that converts an integer number to its binary representation. 
The input is entered as long. The output should be a variable of type string. 
Do not use the built-in .NET functionality.*/

using System;

class DecimalToBinary
{
    static void Main(string[] args)
    {
        Console.Write("Enter a decimal number: ");
        long decNum = long.Parse(Console.ReadLine());
        
        string binNum = BinaryNumber(decNum);
        Console.WriteLine("The decimal number {0} is {1} in the binary system", decNum, binNum);
    }

    static string BinaryNumber(long number)
    {
        long rest = 0;
        string binNumber = null;
        
        do
        {
            rest = number % 2;
            binNumber += rest.ToString();
            number = number / 2;
        } while (number != 0);

        char[] binNumChar = binNumber.ToCharArray();
        Array.Reverse(binNumChar);
        binNumber = new string(binNumChar);
        return binNumber;
    }
}
