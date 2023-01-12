using System;

internal class ClassName
{
    public static void Main(string[] args)
    {
        // Task 1
        Helper.DisplayTask("I", "Implement the calculator operations");
        Console.WriteLine(SimpleCalculator.Calculate(16, 51, "+"));
        Console.WriteLine(SimpleCalculator.Calculate(32, 6, "*"));
        Console.WriteLine(SimpleCalculator.Calculate(512, 4, "/"));
        Console.WriteLine();


        // Task 2
        Helper.DisplayTask("II", "Handle illegal operations");
        //SimpleCalculator.Calculate(100, 10, "-");                   // => throws ArgumentOutOfRangeException
        //SimpleCalculator.Calculate(8, 2, "");                       // => throws ArgumentException
        //SimpleCalculator.Calculate(58, 6, null);                    // => throws ArgumentNullException
        Console.WriteLine();



        // Task 3
        Helper.DisplayTask("III", "Handle errors when dividing by zero");
        Console.WriteLine(SimpleCalculator.Calculate(512, 0, "/"));
        Console.WriteLine();
    }
}