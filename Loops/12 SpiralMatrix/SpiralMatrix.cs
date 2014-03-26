/*Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20)
and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.*/

using System;

class SpiralMatrix
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive integer number n (1 <= n <= 20): ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        int row = 0;
        int col = 0;

        int num = 1;
        int lastPos = 0;

        while (true)
        {
            while (col < matrix.GetLength(1) - 1 - lastPos)
            {
                matrix[row, col] = num;
                col++;
                num++;
            }

            if (num > n * n)
            {
                break;
            }

            while (row < matrix.GetLength(0) - 1 - lastPos)
            {
                matrix[row, col] = num;
                row++;
                num++;
            }

            while (col > lastPos)
            {
                matrix[row, col] = num;
                col--;
                num++;
            }

            while (row > lastPos)
            {
                matrix[row, col] = num;
                row--;
                num++;
            }
            
            if (n % 2 != 0 && num == n * n)
            {
                row++;
                col++;
            }
            else
            {
                lastPos++;
                row++;
                col++;
            }
        }

        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                Console.Write("{0, 4} ", matrix[r, c]);
            }
            Console.WriteLine();
        }
    }
}
