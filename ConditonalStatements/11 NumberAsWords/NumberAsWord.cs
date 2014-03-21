// Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;

class NumberAsWord
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer number in the range [0..999]: ");
        int number = int.Parse(Console.ReadLine());
        string numberAsStr = number.ToString();
        string hundret = null;
        string ten = null;
        string numTillTwenty = null;
        
        string[] numsTillTwenty = new string[19]{
            "One", "Two", "Three",
            "Four", "Five", "Six", "Seven",
            "Eight", "Nine", "Ten", "Eleven",
            "Twelve", "Thirteen", "Fourteen",
            "Fifteen", "Sixteen", "Seventeen",
            "Eighteen", "Nineteen"
        };
        
        string[] tens = new string[8]{
            "Twenty", "Thirty", "Forthy",
            "Fifty", "Sixty", "Seventy", "Eighty",
            "Ninety",
        };

        string[] hundrets = new string[9]{
            "One Hundred", "Two Hundred", "Three Hundred",
            "Four Hundred", "Five Hundred", "Six Hundred", "Seven Hundred",
            "Eight Hundred", "Nine Hundred"
        };

        if (number / 100 != 0)
        {
            switch (numberAsStr[0])
            {
                case '1':
                    hundret = hundrets[0];
                    break;
                case '2':
                    hundret = hundrets[1];
                    break;
                case '3':
                    hundret = hundrets[2];
                    break;
                case '4':
                    hundret = hundrets[3];
                    break;
                case '5':
                    hundret = hundrets[4];
                    break;
                case '6':
                    hundret = hundrets[5];
                    break;
                case '7':
                    hundret = hundrets[6];
                    break;
                case '8':
                    hundret = hundrets[7];
                    break;
                case '9':
                    hundret = hundrets[8];
                    break;
                default:
                    break;
            }

            switch (numberAsStr[1])
            {
                case '1':
                    switch (numberAsStr[2])
	                {
                        case '1':
                            numTillTwenty = numsTillTwenty[10];
                            break;
                        case '2':
                            numTillTwenty = numsTillTwenty[11];
                            break;
                        case '3':
                            numTillTwenty = numsTillTwenty[12];
                            break;
                        case '4':
                            numTillTwenty = numsTillTwenty[13];
                            break;
                        case '5':
                            numTillTwenty = numsTillTwenty[14];
                            break;
                        case '6':
                            numTillTwenty = numsTillTwenty[15];
                            break;
                        case '7':
                            numTillTwenty = numsTillTwenty[16];
                            break;
                        case '8':
                            numTillTwenty = numsTillTwenty[17];
                            break;
                        case '9':
                            numTillTwenty = numsTillTwenty[18];
                            break;
		                default:
                            numTillTwenty = numsTillTwenty[9];
                            break;
	                };
                    break;
                case '2':
                    ten = tens[0];
                    break;
                case '3':
                    ten = tens[1];
                    break;
                case '4':
                    ten = tens[2];
                    break;
                case '5':
                    ten = tens[3];
                    break;
                case '6':
                    ten = tens[4];
                    break;
                case '7':
                    ten = tens[5];
                    break;
                case '8':
                    ten = tens[6];
                    break;
                case '9':
                    ten = tens[7];
                    break;
                default:
                    break;
            }

            if (numberAsStr[1] != '1')
            {
                switch (numberAsStr[2])
                {
                    case '0':
                        numTillTwenty = null;
                        break;
                    case '2':
                        numTillTwenty = numsTillTwenty[1];
                        break;
                    case '3':
                        numTillTwenty = numsTillTwenty[2];
                        break;
                    case '4':
                        numTillTwenty = numsTillTwenty[3];
                        break;
                    case '5':
                        numTillTwenty = numsTillTwenty[4];
                        break;
                    case '6':
                        numTillTwenty = numsTillTwenty[5];
                        break;
                    case '7':
                        numTillTwenty = numsTillTwenty[6];
                        break;
                    case '8':
                        numTillTwenty = numsTillTwenty[7];
                        break;
                    case '9':
                        numTillTwenty = numsTillTwenty[8];
                        break;
                    default:
                        numTillTwenty = "One";
                        break;
                }
            }
            Console.WriteLine(hundret + " " + ten + " " + numTillTwenty);
        }
        else if (number / 10 != 0)
        {
            switch (numberAsStr[0])
            {
                case '1':
                    switch (numberAsStr[1])
                    {
                        case '1':
                            numTillTwenty = numsTillTwenty[10];
                            break;
                        case '2':
                            numTillTwenty = numsTillTwenty[11];
                            break;
                        case '3':
                            numTillTwenty = numsTillTwenty[12];
                            break;
                        case '4':
                            numTillTwenty = numsTillTwenty[13];
                            break;
                        case '5':
                            numTillTwenty = numsTillTwenty[14];
                            break;
                        case '6':
                            numTillTwenty = numsTillTwenty[15];
                            break;
                        case '7':
                            numTillTwenty = numsTillTwenty[16];
                            break;
                        case '8':
                            numTillTwenty = numsTillTwenty[17];
                            break;
                        case '9':
                            numTillTwenty = numsTillTwenty[18];
                            break;
                        default:
                            numTillTwenty = numsTillTwenty[9];
                            break;
                    };
                    break;
                case '2':
                    ten = tens[0];
                    break;
                case '3':
                    ten = tens[1];
                    break;
                case '4':
                    ten = tens[2];
                    break;
                case '5':
                    ten = tens[3];
                    break;
                case '6':
                    ten = tens[4];
                    break;
                case '7':
                    ten = tens[5];
                    break;
                case '8':
                    ten = tens[6];
                    break;
                case '9':
                    ten = tens[7];
                    break;
                default:
                    break;
            }

            if (numberAsStr[0] != '1')
            {
                switch (numberAsStr[1])
                {
                    case '0':
                        numTillTwenty = null;
                        break;
                    case '2':
                        numTillTwenty = numsTillTwenty[1];
                        break;
                    case '3':
                        numTillTwenty = numsTillTwenty[2];
                        break;
                    case '4':
                        numTillTwenty = numsTillTwenty[3];
                        break;
                    case '5':
                        numTillTwenty = numsTillTwenty[4];
                        break;
                    case '6':
                        numTillTwenty = numsTillTwenty[5];
                        break;
                    case '7':
                        numTillTwenty = numsTillTwenty[6];
                        break;
                    case '8':
                        numTillTwenty = numsTillTwenty[7];
                        break;
                    case '9':
                        numTillTwenty = numsTillTwenty[8];
                        break;
                    default:
                        numTillTwenty = "One";
                        break;
                }
            }
            Console.WriteLine(ten + " " + numTillTwenty);
        }
        else
        {
            switch (numberAsStr[0])
            {
                case '0':
                    numTillTwenty = "Zero";
                    break;
                case '2':
                    numTillTwenty = numsTillTwenty[1];
                    break;
                case '3':
                    numTillTwenty = numsTillTwenty[2];
                    break;
                case '4':
                    numTillTwenty = numsTillTwenty[3];
                    break;
                case '5':
                    numTillTwenty = numsTillTwenty[4];
                    break;
                case '6':
                    numTillTwenty = numsTillTwenty[5];
                    break;
                case '7':
                    numTillTwenty = numsTillTwenty[6];
                    break;
                case '8':
                    numTillTwenty = numsTillTwenty[7];
                    break;
                case '9':
                    numTillTwenty = numsTillTwenty[8];
                    break;
                default:
                    numTillTwenty = "One";
                    break;
            }
            Console.WriteLine(numTillTwenty);
        }
    }
}
