using System;

internal class ClassName
{
    public static void Main(string[] args)
    {
        Player player = new Player();
        // Task I
        Helper.DisplayTask("I", "Enable a wizards and warriors player to roll a die.");
        Console.WriteLine(player.RollDie());
        Console.WriteLine();



        // Task 2
        Helper.DisplayTask("II", "Players need their strength. Provide a means to generate spell strength");
        Console.WriteLine(player.GenerateSpellStrength());
        Console.WriteLine();
    }
}