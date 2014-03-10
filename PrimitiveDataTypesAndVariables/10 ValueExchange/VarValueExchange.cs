using System;

class VarValueExchange
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("a old value: {0}     b old value: {1}", a, b);

        b = a + b;
        a = b - a;      //a tricky way to exchange values
        b = b - a;

        Console.WriteLine("a new value: {0}    b new value: {1}", a, b);
    }
}
