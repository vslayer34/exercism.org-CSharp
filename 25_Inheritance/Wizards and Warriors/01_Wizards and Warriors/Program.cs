using System;

internal class ClassName
{
    public static void Main(string[] args)
    {
        // Task 1
        Helper.DisplayTask("I", "Describe a character");
        Helper.DisplayExample(
            "warrior.ToString();",
            "Character is a Warrior"
            );
        Warrior warrior = new Warrior();
        Console.WriteLine(warrior.ToString());
        Console.WriteLine();



        // Task 2
        Helper.DisplayTask("II", "Make characters not vulnerable by default");
        Helper.DisplayExample(
            "warrior.Vulnerable()",
            false.ToString());
        Console.WriteLine(warrior.Vulnerable());
        Console.WriteLine();



        // Task 3
        Helper.DisplayTask("III", "Allow Wizards to prepare a spell");
        Console.WriteLine();



        // Task 4
        Helper.DisplayTask("IV", "Make Wizards vulnerable when not having prepared a spell");

        Wizard wizard= new Wizard();
        Console.WriteLine($"Wizard is vulnerable (before preparing a spell): {wizard.Vulnerable()}");
        //wizard.PrepareSpell();
        Console.WriteLine($"Wizard is vulnerable (after preparing a spell): {wizard.Vulnerable()}");
        Console.WriteLine();



        // Task 5
        Helper.DisplayTask("V", "Calculate the damage points for a Wizard");
        Console.WriteLine($"Wizared attack the warrior with {wizard.DamagePoints(warrior)} points of damage (no spell)");
        //wizard.PrepareSpell();
        Console.WriteLine($"Wizared attack the warrior with {wizard.DamagePoints(warrior)} points of damage (with spell)");
        Console.WriteLine();

        // Task 6
        Helper.DisplayTask("VI", "Calculate the damage points for a Warrior");
        Console.WriteLine($"The warrior attacked th wizard with {warrior.DamagePoints(wizard)} points of damage (no spell)");
        wizard.PrepareSpell();
        Console.WriteLine($"The warrior attacked th wizard with {warrior.DamagePoints(wizard)} points of damage (with spell)");
    }
}