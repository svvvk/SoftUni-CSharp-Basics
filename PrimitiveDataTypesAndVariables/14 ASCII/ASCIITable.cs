/*Find online more information about ASCII (American Standard Code for Information Interchange)
and write a program to prints the entire ASCII table of characters at the console (characters from 0 to 255). */

using System;
using System.Text;

class ASCIITable
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.ASCII;
        
        for (int i = 0; i <= 255; i++)
        {
            System.Console.WriteLine("{0} = {1}", i, (char)i);
        }
    }
}
