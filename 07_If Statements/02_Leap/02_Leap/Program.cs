using System;
using static System.Net.Mime.MediaTypeNames;

class Leap
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Test 1");
        Console.WriteLine("Year 2015");
        Console.WriteLine(IsLeapYear(2015));
        Console.WriteLine();

        Console.WriteLine("Test 2");
        Console.WriteLine("Year 1970");
        Console.WriteLine(IsLeapYear(1970));
        Console.WriteLine();

        Console.WriteLine("Test 3");
        Console.WriteLine("Year 1996");
        Console.WriteLine(IsLeapYear(1996));
        Console.WriteLine();

        Console.WriteLine("Test 4");
        Console.WriteLine("Year 1960");
        Console.WriteLine(IsLeapYear(1960));
        Console.WriteLine();

        Console.WriteLine("Test 5");
        Console.WriteLine("Year 2100");
        Console.WriteLine(IsLeapYear(2100));
        Console.WriteLine();

        Console.WriteLine("Test 6");
        Console.WriteLine("Year 1900");
        Console.WriteLine(IsLeapYear(1900));
        Console.WriteLine();

        Console.WriteLine("Test 7");
        Console.WriteLine("Year 2000");
        Console.WriteLine(IsLeapYear(2000));
        Console.WriteLine();

        Console.WriteLine("Test 8");
        Console.WriteLine("Year 2400");
        Console.WriteLine(IsLeapYear(2400));
        Console.WriteLine();

        Console.WriteLine("Test 9");
        Console.WriteLine("Year 1800");
        Console.WriteLine(IsLeapYear(1800));
        Console.WriteLine();
    }

    public static bool IsLeapYear(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return true;
                }
                return false;
            }
            return true;
        }
        else
            return false;
    }
}