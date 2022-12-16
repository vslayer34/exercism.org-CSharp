using System;


class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
        damage = 10;
    }

    public override int DamagePoints(Character target)
    {
        if (!target.Vulnerable())
        {
            damage = 6;
        }
        return damage;
    }
}