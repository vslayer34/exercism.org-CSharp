using System;

class AssemblyLine
{
    public static void Main(string[] args)
    {
        // Task I: Calculate the success rate
        Console.WriteLine("Task I: Calculate the success rate:");
        //=====================================
        // Test I: Success rate for speed zero
        Console.WriteLine($"Success rate for speed zero: {SuccessRate(0)}");

        // Test II: Success rate for speed one
        Console.WriteLine($"Success rate for speed one: {SuccessRate(1)}");

        // Test III: Success rate for speed four
        Console.WriteLine($"Success rate for speed four: {SuccessRate(4)}");

        // Test IV: Success rate for speed five
        Console.WriteLine($"Success rate for speed five: {SuccessRate(5)}");

        // Test V: Success rate for speed nine
        Console.WriteLine($"Success rate for speed nine: {SuccessRate(9)}");

        // Test VI: Success rate for speed ten
        Console.WriteLine($"Success rate for speed ten: {SuccessRate(10)}");
        //====================================================================
        Console.WriteLine();

        // Task II: Calculate the production rate per hour
        Console.WriteLine("Task II: Calculate the production rate per hour");
        //================================================
        Console.WriteLine();

        // Test VII: Production rate per hour for speed zero
        Console.WriteLine($"Test VII: Production rate per hour for speed zero: {ProductionRatePerHour(0)}");

        // Test VIII: Production rate per hour for speed one
        Console.WriteLine($"Test VIII: Production rate per hour for speed one: {ProductionRatePerHour(1)}");

        // Test IX: Production rate per hour for speed four
        Console.WriteLine($"Test IX: Production rate per hour for speed four: {ProductionRatePerHour(4)}");

        // Test X: Production rate per hour for speed seven
        Console.WriteLine($"Test X: Production rate per hour for speed seven: {ProductionRatePerHour(7)}");

        // Test XI: Production rate per hour for speed nine
        Console.WriteLine($"Test XI: Production rate per hour for speed nine: {ProductionRatePerHour(9)}");

        // Test XII: Production rate per hour for speed ten
        Console.WriteLine($"Test XII: Production rate per hour for speed ten: {ProductionRatePerHour(10)}");
        //====================================================================
        Console.WriteLine();

        // Task III: Calculate the number of working items produced per minute
        Console.WriteLine("Task III: Calculate the number of working items produced per minute");
        //=====================================================================

        // Test XIII: Working items per minute for speed zero

        // Test XIV: Working items per minute for speed one
        Console.WriteLine($"Test XIV: Working items per minute for speed one: {WorkingItemsPerMinute(1)}");

        // Test XV: Working items per minute for speed five
        Console.WriteLine($"Test XV: Working items per minute for speed five: {WorkingItemsPerMinute(5)}");

        // Test XVI: Working items per minute for speed eight
        Console.WriteLine($"Test XVI: Working items per minute for speed eight: {WorkingItemsPerMinute(8)}");

        // Test XVII: Working items per minute for speed nine
        Console.WriteLine($"Test XVII: Working items per minute for speed nine: {WorkingItemsPerMinute(9)}");

        // Test XVIII: Working items per minute for speed ten
        Console.WriteLine($"Test XVIII: Working items per minute for speed ten: {WorkingItemsPerMinute(10)}");
    }

    public static double SuccessRate(int speed)
    {
        if (speed == 0)
            return 0;
        else if (speed >= 1 && speed <= 4)
            return 1.0;
        else if (speed >= 5 && speed <= 8)
            return 0.9;
        else if (speed == 9)
            return 0.8;
        else
            return 0.77;

        /*
         * AssemblyLine.SuccessRate(10)
         * // => 0.77
         */
    }

    public static double ProductionRatePerHour(int speed)
    {
        return speed * 221 * SuccessRate(speed);

        /*
         * AssemblyLine.ProductionRatePerHour(6)
         * // => 1193.4
         */
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed) / 60;

        /*
         * AssemblyLine.WorkingItemsPerMinute(6)
         * // => 19
         */
    }
}