/*Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender. 
Print it on the console.*/

using System;

class BoolVar
{
    static void Main(string[] args)
    {
        bool isFemale = false;
        
        string female = "female";
        string male = "male";
        
        Console.WriteLine("I am a {0} ", isFemale? female : male);
    }
}
