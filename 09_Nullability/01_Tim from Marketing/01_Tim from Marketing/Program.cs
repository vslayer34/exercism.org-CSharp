using System;

internal class ClassName
{
    public static void Main(string[] args)
    {
        // Task 1
        Helper.DisplayTask("I", "Print a badge for an employee");
        Console.WriteLine(Badge.Print(734, "Ernest Johnny Payne", "Strategic Communication"));
        Console.WriteLine();



        // Task 2
        Helper.DisplayTask("II", "Print a badge for a new employee");
        Console.WriteLine(Badge.Print(id: null, "Jane Johnson", "Procurement"));
        Console.WriteLine();


        // Task 3
        Helper.DisplayTask("III", "Print a badge for the owner");
        Console.WriteLine(Badge.Print(id: null, "Charlotte Hale", department: null));
        Console.WriteLine();
    }
}