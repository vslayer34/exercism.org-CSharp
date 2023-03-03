using System;


static class GameMaster
{
    // "You're a level <LEVEL> <CLASS> with <HIT_POINTS> hit points."
    public static string Describe(Character character)
    {
        return $"You're a level {character.Level} {character.Class} with {character.HitPoints} hit points.";
    }


    // "You've arrived at <NAME>, which has <INHABITANTS> inhabitants."
    public static string Describe(Destination destination)
    {
        return $"You've arrived at {destination.Name}, which has {destination.Inhabitants} inhabitants.";
    }



    /// <summary>
    /// Characters can travel to a destination using one of two options:
    ///  Walking, described as: "You're traveling to your destination by walking."
    ///  On horseback, described as: "You're traveling to your destination on horseback."
    /// </summary>
    /// <param name="travelMethod"></param>
    /// <returns></returns>
    public static string Describe(TravelMethod travelMethod) => travelMethod switch
    {
        TravelMethod.Walking   => "You're traveling to your destination by walking.",
        TravelMethod.Horseback => "You're traveling to your destination on horseback."
    };


    // "You're a level 4 Wizard with 28 hit points. You're traveling to your destination on horseback. You've arrived at Muros, which has 732 inhabitants."
    public static string Describe(Character character, Destination destination, TravelMethod travelMethod = TravelMethod.Walking)
    {
        return $"{Describe(character)} {Describe(travelMethod)} {Describe(destination)}";
    }

    //public static string Describe(Character character, Destination destination, TravelMethod travelMethod = )
    //{
    //    return $"{Describe(character)} {Describe(travelMethod)} {Describe(destination)}";
    //}
}