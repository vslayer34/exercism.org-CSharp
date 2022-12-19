using System;
using System.Collections.Generic;

internal class ClassName
{
    public static void Main(string[] args)
    {
        // Task 1
        Helper.DisplayTask("I", "Create a new list");
        Helper.DisplayExample(
            "Languages.NewList()",
            "empty list"
            );
        var listOFLanguages = Languages.NewList();
        Console.WriteLine(listOFLanguages);
        Console.WriteLine();



        // Task 2
        Helper.DisplayTask("II", "Define an existing list");
        Helper.DisplayExample(
            "Languages.GetExistingLanguages();",
            "{\"C#\", \"Clojure\", \"Elm\"}"
            );
        listOFLanguages = Languages.GetExistingLanguages();
        Console.WriteLine(listOFLanguages.Count);
        Console.WriteLine();
    }
}