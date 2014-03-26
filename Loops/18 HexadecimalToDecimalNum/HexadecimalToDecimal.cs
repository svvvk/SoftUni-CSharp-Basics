/*Using loops write a program that converts a hexadecimal integer number to its decimal form. 
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.*/

using System;

class HexadecimalToDecimal
{
    static void Main(string[] args)
    {
        Console.Write("Enter a hexadecimal number: ");
        string hexNum = Console.ReadLine();
        
        int[] hexArray = HexValues(hexNum, out hexArray);
        long decNum = HexToDecNumber(hexArray);
        Console.WriteLine("The hexadecimal number {0} is {1} in the decimal numeral system", hexNum, decNum);
    }

    static long HexToDecNumber(int[] hexArray)
    {
        long decTotalNum = 0;

        for (int i = 1; i <= hexArray.Length; i++)
        {
            decTotalNum += Exponentiation(16, hexArray.Length - i) * hexArray[i - 1];
        }
        return decTotalNum;
    }

    static int[] HexValues(string hexNumber, out int[] hexArray)
    {
        hexArray = new int[hexNumber.Length];
        bool tryParse = true;
        for (int i = 0; i < hexNumber.Length; i++)
        {
            string currChar = hexNumber[i].ToString();
            tryParse = int.TryParse(currChar, out hexArray[i]);
            if (tryParse)
            {
                hexArray[i] = int.Parse(currChar);
            }
            else
            {
                switch (currChar)
                {
                    case "A":
                        hexArray[i] = 10;
                        break;
                    case "B":
                        hexArray[i] = 11;
                        break;
                    case "C":
                        hexArray[i] = 12;
                        break;
                    case "D":
                        hexArray[i] = 13;
                        break;
                    case "E":
                        hexArray[i] = 14;
                        break;
                    case "F":
                        hexArray[i] = 15;
                        break;
                }
            }
        }
        return hexArray;
    }

    static long Exponentiation(long number, int times)
    {
        int num = (int)number;
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
