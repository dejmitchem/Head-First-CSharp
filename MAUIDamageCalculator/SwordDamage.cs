using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace MAUIDamageCalculator
{
    internal class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;

        public int Roll;
        public decimal MagicMultiplier = 1M;
        public int Damage;

        public void CalculateDamage()
        {
            Damage = (int)(Roll * MagicMultiplier) + BASE_DAMAGE;
            Debug.WriteLine($"CalculateDamage set Damage to: {Damage} (Roll: {Roll}");
        }

        public void SetMagic(bool isMagic)
        {
            if (isMagic)
                MagicMultiplier = 1.75M;
            else
                MagicMultiplier = 1M;
            CalculateDamage();
            Debug.WriteLine($"SetMagic set Damage to: {Damage} (Roll: {Roll}");
        }

        public void SetFlaming(bool isFlaming)
        {
            CalculateDamage();
            if (isFlaming)
                Damage += FLAME_DAMAGE;
            Debug.WriteLine($"SetFlaming set Damage to: {Damage} (Roll: {Roll}");
        }
    }
}
