/*A marketing company wants to keep record of its employees. Each record would have the following characteristics:
•	First name
•	Last name
•	Age (0...100)
•	Gender (m or f)
•	Personal ID number (e.g. 8306112507)
•	Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
Use descriptive names. Print the data at the console.
*/

using System;

class Employee
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your first name: ");
        string firstName = Console.ReadLine();
        
        Console.WriteLine("Please enter your last name: ");
        string lastName = Console.ReadLine();
       
        Console.WriteLine("Please enter your age: ");
        byte age = byte.Parse(Console.ReadLine());
        
        Console.WriteLine("Please enter your gender (m or f): ");
        char gender = char.Parse(Console.ReadLine());
        
        Console.WriteLine("Please write your ID number: ");
        long id = long.Parse(Console.ReadLine());

        Console.WriteLine("Please write your unique employee number: ");
        int uniqueEmployeeNumber = int.Parse(Console.ReadLine());

        if (gender == 'm')
        {
            Console.Write("Hello, " + firstName + " " + lastName + ", {0} years old", age);
            Console.WriteLine(", male");
            Console.Write("Your ID number is {0}", id);
            Console.WriteLine("    Your unique employee number is {0}", uniqueEmployeeNumber);
        }
        else
        {
            Console.Write("Hello " + firstName + " " + lastName + ", {0} years old", age);
            Console.WriteLine(", female");
            Console.Write("Your ID number is {0}", id);
            Console.WriteLine("    Your unique employee number is {0}", uniqueEmployeeNumber);
        }
    }
}
