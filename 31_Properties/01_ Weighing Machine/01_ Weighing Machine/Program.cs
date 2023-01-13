using System;

// URL: https://exercism.org/tracks/csharp/exercises/weighing-machine
internal class ClassName
{
    public static void Main(string[] args)
    {
        // Task 1
        Helper.DisplayTask("I", "Allow the weighing machine to have a precision");
        var wm = new WeighingMachine(precision: 3);

        Helper.DisplayExample("wm.Precision",
            "3"
            );
        Console.WriteLine(wm.Precision);
        Console.WriteLine();



        // Task 2
        Helper.DisplayTask("II", "Allow the weight to be set on the weighing machine");
        wm.Weight = 60.5f;
        Console.WriteLine(wm.Weight);
        Console.WriteLine();


        // Task 3
        Helper.DisplayTask("III", "Ensure that a negative input weight is rejected");
        //wm.Weight = -10;


        // Task 4
        Helper.DisplayTask("IV", "Allow a tare adjustment to be applied to the weighing machine");
        //wm.TareAdjustment = -10.6f;



        // Task 5
        Helper.DisplayTask("V", "Ensure that the weighing machine has a default tare adjustment");
        Console.WriteLine(wm.TareAdjustment == 5.0f);
        Console.WriteLine();



        // Task 6
        Helper.DisplayTask("VI", "Allow the weight to be retrieved");
        wm.TareAdjustment = 10;
        wm.Weight = 60.567f;
        Helper.DisplayExample(
            "wm.DisplayWeight == \"50.567 kg\"",
            "50.567 kg"
            );
        Console.WriteLine(wm.DisplayWeight);
        Console.WriteLine();
    }
}