using System;

internal class ClassName
{
    public static void Main(string[] args)
    {
        // Task 1
        Helper.DisplayTask("I", "Replace any spaces encountered with underscores");
        Helper.DisplayExample(
            "Identifier.Clean(\"my   Id\");",
            "my___Id");

        Console.WriteLine(Identifier.Clean("my   Id"));
        Console.WriteLine();



        // Task 2
        Helper.DisplayTask("II", "Replace control characters with the upper case string \"CTRL\"");
        Helper.DisplayExample(
            "Identifier.Clean(\"my\\0Id\");",
            "myCTRLId");

        Console.WriteLine(Identifier.Clean("my\0Id"));
        Console.WriteLine();



        // Task 3
        Helper.DisplayTask("III", "Convert kebab-case to camelCase");
        Helper.DisplayExample(
            "Identifier.Clean(\"à-ḃç\");",
            "àḂç");

        Console.WriteLine(Identifier.Clean("a-bc"));
        Console.WriteLine();
    }
}