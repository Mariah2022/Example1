using System;

class MonthDays
{
    static void Main()
    {

        string Month, days;
        int mDays;

        Console.WriteLine("Please enter the name of the current month: ");
        Month = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Please enter the number of days in the month: ");
        days = Console.ReadLine();
        Console.WriteLine();

        mDays = Int32.Parse(days);

        Console.Title = "Month Days";
        Console.WriteLine("This month is " + Month + " and it has " + mDays + " days.");
        Console.WriteLine();
    }
}