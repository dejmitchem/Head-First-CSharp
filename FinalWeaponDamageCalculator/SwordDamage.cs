using System;
using System.Collections.Generic;
using System.Text;

namespace FinalWeaponDamageCalculator;

    class SwordDamage : WeaponDamage
{
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;
        private const decimal MAGIC_MULTIPLIER = 1.75M;

        protected override void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic) magicMultiplier = MAGIC_MULTIPLIER;

            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;
        }

        public SwordDamage(int startingRoll) : base(startingRoll) { }
    }
