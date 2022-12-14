using System;

internal class ClassName
{
    public static void Main(string[] args)
    {
        // Task 1
        Helper.DisplayTask("I", "Calculate the interest rate");
        Helper.DisplayExample(
            "SavingsAccount.InterestRate(balance: 200.75m)",
            0.5f.ToString()
            );
        Console.WriteLine(SavingsAccount.InterestRate(balance: 200.75m));
        Console.WriteLine();



        // Task 2
        Helper.DisplayTask("II", "Calculate the interest");
        Helper.DisplayExample(
            "SavingsAccount.Interest(balance: 200.75m)",
            1.00375m.ToString()
            );
        Console.WriteLine(SavingsAccount.Interest(balance: 200.75m));
        Console.WriteLine();



        // Task 3
        Helper.DisplayTask("III", "Calculate the annual balance update");
        Helper.DisplayExample(
            "SavingsAccount.AnnualBalanceUpdate(balance: 200.75m)",
            201.75375m.ToString()
            );
        Console.WriteLine(SavingsAccount.AnnualBalanceUpdate(balance: 200.75m));
        Console.WriteLine();



        // Task 4
        Helper.DisplayTask("IV", "Calculate the years before reaching the desired balance");
        Helper.DisplayExample(
            "SavingsAccount.YearsBeforeDesiredBalance(balance: 200.75m, targetBalance: 214.88m)",
            14.ToString()
            );
        Console.WriteLine(SavingsAccount.YearsBeforeDesiredBalance(balance: 200.75m, targetBalance: 214.88m));
        Console.WriteLine();
    }
}