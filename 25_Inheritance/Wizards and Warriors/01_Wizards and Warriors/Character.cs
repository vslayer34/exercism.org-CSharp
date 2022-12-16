using System;


abstract class Character
{
    private string characterType;

    protected int damage;
    protected bool isVulnerable;


    protected Character(string characterType)
    {
        this.characterType = characterType;
        isVulnerable = false;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return isVulnerable;
    }

    public override string ToString()
    {
        return $"Character is a {characterType}";
    }
}
