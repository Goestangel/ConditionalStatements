using System;
using System.Globalization;

class Beer
//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator)
// and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed    
{

    static void Main()
    {
        Console.WriteLine("Please enter a time in format hh:mm tt");
        string dateString = Console.ReadLine();
        string format = "hh:mm tt";

        DateTime dateTime;
        bool inputCheck = DateTime.TryParseExact(dateString, format, null, System.Globalization.DateTimeStyles.None, out dateTime);
        while (inputCheck == false)
        {
            Console.WriteLine("Please enter a valid date!");
            dateString = Console.ReadLine();
            inputCheck = DateTime.TryParseExact(dateString, format, null, System.Globalization.DateTimeStyles.None, out dateTime);
        }

        string startTimtstr = "01:00 PM";
        string endTimestr = "03:00 AM";

        DateTime startTime = DateTime.ParseExact(startTimtstr, format, CultureInfo.InvariantCulture);
        DateTime endTime = DateTime.ParseExact(endTimestr, format, CultureInfo.InvariantCulture);

        bool check = (dateTime >= startTime && dateTime <= endTime);
        if (check)
            Console.WriteLine("Beer time");
        else
            Console.WriteLine("Not a Beer time");
    }
}