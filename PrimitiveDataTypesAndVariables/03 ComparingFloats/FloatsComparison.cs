// Write a program that safely compares floating-point numbers with precision eps = 0.000001.

using System;

class FloatsComparison
{
    public const decimal eps = 0.000001m;       //this is the constant
    
    static void Main(string[] args)
    {
        float firstA = 5.3f;
        float firstB = 6.01f;

        double secondA = 5.00000001;
        double secondB = 5.00000003;

        double thirdA = -0.0000007;
        double thirdB = 0.00000007;

        double forthA = -4.999999;
        double forthB = -4.999998;

        Console.WriteLine("The numbers {0} and {1} are equal: ", firstA, firstB);
        NumComparison((decimal)firstA, (decimal)firstB);                        //compare the 2 numbers with a method
        
        Console.WriteLine("The numbers {0} and {1} are equal: ", secondA, secondB);
        NumComparison((decimal)secondA, (decimal)secondB);
        
        Console.WriteLine("The numbers {0} and {1} are equal: ", thirdA, thirdB);
        NumComparison((decimal)thirdA, (decimal)thirdB);
        
        Console.WriteLine("The numbers {0} and {1} are equal: ", forthA, forthB);
        NumComparison((decimal)forthA, (decimal)forthB);

        Console.WriteLine("\nType 2 numbers you like!\nNumber 1: ");
        decimal userA = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Number 2: ");
        decimal userB = decimal.Parse(Console.ReadLine());

        Console.WriteLine("The numbers {0} and {1} are equal: ", userA, userB);
        NumComparison(userA, userB);
    }

    public static void NumComparison(decimal firstNum, decimal secondNum)       
    {
        decimal difference = NumDifference(firstNum, secondNum);                //get the difference using another method
        
        if (difference >= eps)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("true");
        }
    }

    public static decimal NumDifference(decimal firstNum, decimal secondNum)    
    {
        if (firstNum - secondNum >= 0 )
        {
            return firstNum - secondNum;
        }
        else
        {
            return secondNum - firstNum;
        }
    }
}
