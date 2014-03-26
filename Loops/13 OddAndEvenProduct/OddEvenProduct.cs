/*You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements. 
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.*/

using System;

class OddEvenProduct
{
    static void Main(string[] args)
    {
        Console.Write("Enter how many integers you want: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        Console.WriteLine("Enter each number on a new line: ");

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < numbers.Length; i+= 2)
        {
            oddProduct *= numbers[i];
        }

        for (int i = 1; i < numbers.Length; i += 2)
        {
            evenProduct *= numbers[i];
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes, product = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no, odd product = {0} ; even product = {1}", oddProduct, evenProduct);
        }
    }
}
