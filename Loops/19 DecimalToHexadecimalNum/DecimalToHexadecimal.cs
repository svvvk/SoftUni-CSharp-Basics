/*Using loops write a program that converts an integer number to its hexadecimal representation. 
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.*/

using System;

class DecimalToHexadecimal
{
    static void Main(string[] args)
    {
        Console.Write("Enter a decimal number: ");
        long decNum = long.Parse(Console.ReadLine());
        
        string hexNum = HexNumber(decNum);
        
        char[] hexNumChar = hexNum.ToCharArray();
        Array.Reverse(hexNumChar);
        
        hexNum = new string(hexNumChar);
        Console.WriteLine("The number {0} is {1} in hexadecimal numeral system", decNum, hexNum);
    }

    static string HexNumber(long number)
    {
        int rest = 0;
        string hexNum = null;
        char symbol = 'A';
        while (number != 0)
        {
            rest = (int)(number % 16);
            number = number / 16;
            if (rest > 9)
            {
                switch (rest)
                {
                    case 10:
                        symbol = 'A';
                        break;
                    case 11:
                        symbol = 'B';
                        break;
                    case 12:
                        symbol = 'C';
                        break;
                    case 13:
                        symbol = 'D';
                        break;
                    case 14:
                        symbol = 'E';
                        break;
                    case 15:
                        symbol = 'F';
                        break;
                }
                hexNum += symbol;
            }
            else
            {
                hexNum += rest.ToString();
            }
        }
        return hexNum;
    }
}
