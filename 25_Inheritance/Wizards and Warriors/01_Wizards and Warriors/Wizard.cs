using System;


class Wizard : Character
{
    private bool isSpellPrepared;

    public Wizard() : base("Wizard")
    {
        isSpellPrepared = false;
        isVulnerable = true;
        damage = 3;
    }

    public override int DamagePoints(Character target)
    {
        if (isSpellPrepared)
        {
            damage = 12;
        }

        return damage;
    }

    public void PrepareSpell()
    {
        isSpellPrepared = true;
        isVulnerable = false;
    }
}
