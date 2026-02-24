using System;
using System.Collections.Generic;
using System.Text;

namespace MoreWeaponsDamageCalculator;

internal class ArrowDamage
{
    private const decimal BASE_MULTIPLIER = 0.35M;
    private const decimal MAGIC_MULTIPLIER = 1.75M;
    private const decimal FLAME_DAMAGE = 1.25M;
    private int roll;
    private bool flaming;
    private bool magic;

    public ArrowDamage(int roll)
    {
        this.roll = roll;
    }

    public int Damage { get; private set; }
    public int Roll
    {
        get
        {
            return roll;
        }
        set
        {
            roll = value;
            CalculateDamage();
        }
    }

    private void CalculateDamage()
    {
        decimal baseDamage = Roll * BASE_MULTIPLIER;
        if (Magic) baseDamage *= MAGIC_MULTIPLIER;
        if (Flaming) Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
        else Damage = (int) Math.Ceiling(baseDamage);
    }
    public bool Magic
    {
        get
        {
            return magic;
        }
        set
        {
            magic = value;
            CalculateDamage();
        }
    }

    public bool Flaming
    {
        get
        {
            return flaming;
        }

        set
        {
            flaming = value;
            CalculateDamage();
        }
    }
}
