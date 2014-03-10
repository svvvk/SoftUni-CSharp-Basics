/*Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result. */

using System;

class NullValues
{
    static void Main(string[] args)
    {
        int? firstNull = null;
        double? secondNull = null;

        Console.WriteLine(firstNull + "    " + secondNull);

        firstNull = firstNull + 2;
        secondNull = secondNull + 10.25;

        Console.WriteLine(firstNull + "    " + secondNull);

        firstNull = 2;
        secondNull = 10.25;

        Console.WriteLine(firstNull + "    " + secondNull);

        firstNull = firstNull + null;
        secondNull = secondNull + null;

        Console.WriteLine(firstNull + "    " + secondNull);
    }
}
