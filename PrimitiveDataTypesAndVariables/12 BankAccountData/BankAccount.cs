/*A bank account has a holder name (first name, middle name and last name), 
available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types 
and descriptive names.*/

using System;

class BankAccount
{
    static void Main(string[] args)
    {
        string firstName = "FirstName";
        string middleName = "MiddleName";
        string lastName = "LastName";
        
        decimal moneyBalance = 10963.48m;
        
        string bankName = "SomeBank";
        string IBAN = "BG32 UBSS 1447 9012 5029 05";
        
        long CC1 = 23456789123504;
        long CC2 = 81341231251235;
        long CC3 = 34124132413413;

        Console.WriteLine("{0} {1} {2}\nAvailable amount of money: {3}\n{4} IBAN: {5}\nCard number: {6}\nCard number: {7}\nCard number: {8}",
            firstName, middleName, lastName, moneyBalance, bankName, IBAN, CC1, CC2, CC3);
    }
}
