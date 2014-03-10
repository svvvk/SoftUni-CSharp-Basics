/*Declare two string variables and assign them with following value:
The "use" of quotations causes difficulties.
 Do the above in two different ways: with and without using quoted strings.*/

using System;

class Quotes
{
    static void Main(string[] args)
    {
        string firstQuotes = "The \"use\" of quotations causes difficulties";
        Console.WriteLine(firstQuotes);

        string secondQuotes = @"The ""use"" of quotations causes difficulties";
        Console.WriteLine(secondQuotes);
    }
}
