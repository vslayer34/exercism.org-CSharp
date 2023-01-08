using System;

public class Player
{
    private Random rand = new Random();
    private const int numSides = 18;

    public int RollDie()
    {
        return rand.Next(1, numSides);
    }

    public double GenerateSpellStrength()
    {
        return Math.Round(rand.NextDouble() * 100, 2);
    }
}
