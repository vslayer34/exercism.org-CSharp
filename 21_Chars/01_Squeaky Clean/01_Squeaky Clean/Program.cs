using System;

internal class ClassName
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine(Console.OutputEncoding);

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

        Console.WriteLine(Identifier.Clean("à-ḃç"));
        Console.WriteLine();



        // Task 4
        Helper.DisplayTask("IV", "Omit characters that are not letters");
        Helper.DisplayExample(
            "Identifier.Clean(\"1😀2😀3😀\");",
            "\"\""
            );
        Console.WriteLine(Identifier.Clean("1😀2😀3😀"));
        Console.WriteLine();



        // Task 5
        Helper.DisplayTask("V", "Omit Greek lower case letters");
        Helper.DisplayExample(
            "Identifier.Clean(\"MyΟβιεγτFinder\");",
            "MyΟFinder"
            );
        Console.WriteLine(Identifier.Clean("MyΟβιεγτFinder"));
        Console.WriteLine();
    }
}