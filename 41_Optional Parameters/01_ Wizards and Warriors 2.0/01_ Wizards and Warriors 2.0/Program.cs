using System;


public enum TravelMethod
{
    Walking,
    Horseback
}

internal class Program
{
    public static void Main(string[] args)
    {
        Helper.DisplayTask("I", "Describe a character");

        var character = new Character();
        character.Class = "Wizard";
        character.Level = 4;
        character.HitPoints = 28;

        Console.WriteLine(GameMaster.Describe(character: character));
        Console.WriteLine();
        
        //---------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------

        Helper.DisplayTask("II", "Describe a destination");
        var destination = new Destination();
        destination.Name = "Muros";
        destination.Inhabitants = 732;

        Console.WriteLine(GameMaster.Describe(destination: destination));
        Console.WriteLine();
        
        //---------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------

        Helper.DisplayTask("III", "Describe the travel method");
        Console.WriteLine(GameMaster.Describe(travelMethod: TravelMethod.Horseback));
        Console.WriteLine();
        
        //---------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------

        Helper.DisplayTask("IV", "Describe a character traveling to a destination");

        Console.WriteLine(GameMaster.Describe(character: character, destination: destination, travelMethod: TravelMethod.Horseback));
        Console.WriteLine();

        //---------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------

    }
}