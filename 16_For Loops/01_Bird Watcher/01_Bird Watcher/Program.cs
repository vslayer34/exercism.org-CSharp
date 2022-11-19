using System;

internal class ClassName
{
    public static void Main(string[] args)
    {
        // Task 1
        Helper.DisplayTask("I", "Check what the counts were last week");
        Helper.DisplayExample("BirdCount.LastWeek();", "[0, 2, 5, 3, 7, 8, 4]");

        Console.WriteLine($"[{String.Join(", ", BirdCount.LastWeek())}]");
        Console.WriteLine();


        // Task 2
        Helper.DisplayTask("II", "Check how many birds visited today");
        Helper.DisplayExample(
            "int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };\r\n" +
            "var birdCount = new BirdCount(birdsPerDay);\r\n" +
            "birdCount.Today();", "1");

        int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
        BirdCount birdCount = new BirdCount(birdsPerDay);
        Console.WriteLine(birdCount.Today());
        Console.WriteLine();


        // Task 3
        Helper.DisplayTask("III", "Increment today's count");
        Helper.DisplayExample(
            "int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };\r\n" +
            "var birdCount = new BirdCount(birdsPerDay);\r\n" +
            "birdCount.IncrementTodaysCount();\r\n" +
            "birdCount.Today();", "2");

        birdCount.IncrementTodaysCount();
        Console.WriteLine(birdCount.Today());
        Console.WriteLine();


        // Task 4
        Helper.DisplayTask("IV", "Check if there was a day with no visiting birds");
        Helper.DisplayExample(
            "int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };\r\n" +
            "var birdCount = new BirdCount(birdsPerDay);\r\n" +
            "birdCount.HasDayWithoutBirds();"
            , "True");

        Console.WriteLine(birdCount.HasDayWithoutBirds());
        Console.WriteLine();


        // Task 5
        Helper.DisplayTask("V", "Calculate the number of visiting birds for the first number of days");
        Helper.DisplayExample(
            "int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };\r\n" +
            "var birdCount = new BirdCount(birdsPerDay);\r\n" +
            "birdCount.CountForFirstDays(4);", "14");

        Console.WriteLine(birdCount.CountForFirstDays(4));
        Console.WriteLine();


        // Task 6
        Helper.DisplayTask("VI", "Calculate the number of busy days");
        Helper.DisplayExample(
            "int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };\r\n" +
            "var birdCount = new BirdCount(birdsPerDay);\r\n" +
            "birdCount.BusyDays();",
            "2");

        Console.WriteLine(birdCount.BusyDays());
        Console.WriteLine();
    }
}