/*We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0. 
 * Assume that repeating the same subset several times is not a problem.*/

using System;

class ZeroSubset
{
    static void Main()
    {
        Console.Write("Enter a number a: ");
        float a = float.Parse(Console.ReadLine());
        
        Console.Write("Enter a number b: ");
        float b = float.Parse(Console.ReadLine());
        
        Console.Write("Enter a number c: ");
        float c = float.Parse(Console.ReadLine());
        
        Console.Write("Enter a number d: ");
        float d = float.Parse(Console.ReadLine());
        
        Console.Write("Enter a number e: ");
        float e = float.Parse(Console.ReadLine());
        bool noZeroSubsets = true;

        if (a + b == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, b);
            noZeroSubsets = false;
        }
        if (a + c == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, c);
            noZeroSubsets = false;
        }
        if (a + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, d);
            noZeroSubsets = false;
        }
        if (a + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, e);
            noZeroSubsets = false;
        }
        if (b + c == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, c);
            noZeroSubsets = false;
        }
        if (b + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, d);
            noZeroSubsets = false;
        }
        if (b + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, e);
            noZeroSubsets = false;
        }
        if (c + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, d);
            noZeroSubsets = false;
        }
        if (c + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, e);
            noZeroSubsets = false;
        }
        if (d + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", d, e);
            noZeroSubsets = false;
        }
        //------------------------------------------------------------------------------------------
        if (a + b + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
            noZeroSubsets = false;
        }
        if (a + b + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
            noZeroSubsets = false;
        }
        if (a + b + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
            noZeroSubsets = false;
        }
        if (a + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
            noZeroSubsets = false;
        }
        if (a + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
            noZeroSubsets = false;
        }
        if (a + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
            noZeroSubsets = false;
        }
        if (b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
            noZeroSubsets = false;
        }
        if (b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
            noZeroSubsets = false;
        }
        if (b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
            noZeroSubsets = false;
        }
        if (c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
            noZeroSubsets = false;
        }
        //-------------------------------------------------------------------------------------------------
        if (a + b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
            noZeroSubsets = false;
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
            noZeroSubsets = false;
        }
        if (a + b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
            noZeroSubsets = false;
        }
        if (a + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e);
            noZeroSubsets = false;
        }
        if (b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e);
            noZeroSubsets = false;
        }
        //-------------------------------------------------------------------------------------------------
        if (a + b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4}= 0", a, b, c, d, e);
            noZeroSubsets = false;
        }
        if (noZeroSubsets)
        {
            Console.WriteLine("no zero subset");
        }
    }
}
