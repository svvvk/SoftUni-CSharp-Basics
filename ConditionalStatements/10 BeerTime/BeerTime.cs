/*A beer time is after 1:00 PM and before 3:00 AM. 
 Write a program that enters a time in format “hh:mm tt” 
(an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints 
“beer time” or “non-beer time” according to the definition above or “invalid time” if the time cannot be parsed.
 Note that you may need to learn how to parse dates and times.*/

using System;
using System.Globalization;

class BeerTime
{
    static void Main(string[] args)
    {
        Console.Write("Enter a time in the format (hh:mm tt) (example: 1:00 PM): ");
        string time = Console.ReadLine();
        string beginningBeerTime = "1:00 PM";
        string endBeerTime = "3:00 AM";
        
        try
        {
            TimeSpan inputTime = (DateTime.ParseExact(time, "h:mm tt", CultureInfo.InvariantCulture)).TimeOfDay;
            TimeSpan startBeerTime = (DateTime.ParseExact(beginningBeerTime, "h:mm tt", CultureInfo.InvariantCulture)).TimeOfDay;
            TimeSpan stopBeerTime = (DateTime.ParseExact(endBeerTime, "h:mm tt", CultureInfo.InvariantCulture)).TimeOfDay;

            if (inputTime >= startBeerTime || inputTime < stopBeerTime)
            {
                Console.WriteLine("Beer time");
            }
            else
            {
                Console.WriteLine("Non- beer time");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Time");
        }
    }
}
