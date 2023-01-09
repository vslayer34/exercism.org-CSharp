using System;

internal class ClassName
{
    public static void Main(string[] args)
    {
        // Task 1
        Helper.DisplayTask("I", "Output descriptions of the players based on their shirt number");
        Console.WriteLine(PlayAnalyzer.AnalyzeOnField(10));
        Console.WriteLine();



        // Task 2
        Helper.DisplayTask("II", "Raise an alert if an unknown shirt number is encountered");
        //Console.WriteLine(PlayAnalyzer.AnalyzeOnField(12));
        Console.WriteLine();



        // Task 3
        Helper.DisplayTask("III", "Extend the coverage to include off field activity");
        Console.WriteLine(PlayAnalyzer.AnalyzeOffField(5000));
        Console.WriteLine(PlayAnalyzer.AnalyzeOffField("5 minutes to go!"));
        //Console.WriteLine(PlayAnalyzer.AnalyzeOffField(0.5));
        Console.WriteLine();



        // Task 4
        Helper.DisplayTask("IV", "Report on incidents during the match");
        Console.WriteLine(PlayAnalyzer.AnalyzeOffField(new Foul()));
        Console.WriteLine(PlayAnalyzer.AnalyzeOffField(new Injury(8)));
        Console.WriteLine();



        // Task 5
        Helper.DisplayTask("V", "Report on club managers");
        Console.WriteLine(PlayAnalyzer.AnalyzeOffField(new Manager("José Mário dos Santos Mourinho Félix", null)));
        Console.WriteLine(PlayAnalyzer.AnalyzeOffField(new Manager("Jürgen Klopp", "Liverpool")));
        Console.WriteLine();
    }
}