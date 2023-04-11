using System;

internal class ClassName
{
    public static void Main(string[] args)
    {
        Helper.DisplayTask("I", "Write to the database");

        Helper.DisplayTask("II", "Write to the database and return an indication of whether the write was successful to the caller");
    }
}