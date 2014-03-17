/*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
•	Prints on the console the number in reversed order: dcba (in our example 1102).
•	Puts the last digit in the first position: dabc (in our example 1201).
•	Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0. */

using System;

class FourDigitNumber
{
    static void Main(string[] args)
    {
        short number = short.Parse(Console.ReadLine());

        if (number < 0)
        {
            number = (short) (number * -1);     //check if the number is negative
        }

        byte numSum = DigitSum(number);     //a method that returns the sum of the digits
        Console.WriteLine("The sum of the digits: {0}", numSum);

        string reversedNum = ReversedNumber(number);    //a method that reverses the number digits
        Console.WriteLine("The reversed number is: {0}", reversedNum);

        string lastDigitFirst = LastDigitFirst(number);     //a method that puts the last digit as first
        Console.WriteLine("The number with the last digit becoming first is: {0}", lastDigitFirst);

        string digitsExchanged = MiddleDigitsExchange(number);  //a method that exchanges the middle digits
        Console.WriteLine("The number with the middle digits exchanged is: {0}", digitsExchanged);

    }

    static byte DigitSum(short number)
    {
        string numAsStr = number.ToString();    //represent the number as string to access the separate digits
        byte sum = 0;   

        for (int i = 0; i < numAsStr.Length; i++)   //a string is an array of chars, so so we can get the separate digits with this loop
        {
            number = short.Parse(numAsStr[i].ToString());   //convert the char digits to short
            sum += (byte)number;                            //and add them
        }

        return sum;
    }

    static string ReversedNumber(short number)
    {
        char[] numToCharArray = number.ToString().ToCharArray();    //convert the number to a char array
        Array.Reverse(numToCharArray);                              //and reverse its elements
        string charArray = null;

        for (int i = 0; i < numToCharArray.Length; i++)
        {
            charArray += numToCharArray[i].ToString();      //concatenate the reversed number digits as a string
        }

        return charArray;
    }

    static string LastDigitFirst(short number)
    {
        short lastDigit = (short)(number % 10);      //get the last digit
        number = (short) (number / 10);         // remove the last digit from the number

        string numAsStr = number.ToString();    //convert the number to string
        numAsStr = lastDigit + numAsStr;        //and concatenate the last digit as first

        return numAsStr;
    }

    static string MiddleDigitsExchange(short number)
    {
        byte[] numAsArray = new byte[4];    //create an array with 4 elements
        string numAsStr = number.ToString();    //convert the number to string to access the digits
        byte temp = 0;

        for (int i = 0; i < numAsArray.Length; i++)
        {
            numAsArray[i] = byte.Parse(numAsStr[i].ToString());     //assign every digit in the array
        }

        temp = numAsArray[1];
        numAsArray[1] = numAsArray[2];      //exchange the second and the third element of the array 
        numAsArray[2] = temp;

        numAsStr = "";

        for (int i = 0; i < numAsArray.Length; i++)
        {
            numAsStr += numAsArray[i];      //concatenate every element of the array as a string
        }

        return numAsStr;
    }
}
