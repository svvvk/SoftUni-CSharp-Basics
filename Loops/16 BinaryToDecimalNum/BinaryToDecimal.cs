/*Using loops write a program that converts a binary integer number to its decimal form. 
The input is entered as string. The output should be a variable of type long. 
Do not use the built-in .NET functionality.*/

using System;

class BinaryToDecimal
{
    static void Main(string[] args)
    {
        Console.Write("Enter a binary number: ");
        string binNumber = Console.ReadLine();

        long decNumber = DecimalNumber(binNumber);
        Console.WriteLine("The binary number {0} is {1} in the decimal numeral system", binNumber, decNumber);
    }

    static long DecimalNumber(string binNumber)
    {
        long decNumber = 0;

        for (int i = 1; i <= binNumber.Length; i++)
        {
            decNumber += Exponentiation(2, binNumber.Length - i) * (int)Char.GetNumericValue(binNumber[i - 1]);
        }
        return decNumber;
    }

    static int Exponentiation(int number, int times)
    {
        int num = number;
        if (times != 0)
        {
            while (times > 1)
            {
                number = number * num;
                times--;
            }
            return number;
        }
        else
        {
            number = 1;
            return number;
        }
    }
}
