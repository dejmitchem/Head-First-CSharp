using System;
using System.Collections.Generic;
using System.Text;

namespace DamageCalculator
{
    internal class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;
        private int roll;
        private bool flaming;
        private bool magic;

        public SwordDamage(int roll)
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
            if (Magic)
            {
                Damage = (int)(Roll * 1.75) + BASE_DAMAGE;

            }
            else
            {
                Damage = Roll + BASE_DAMAGE;
            }

            if (Flaming)
            {
                Damage += FLAME_DAMAGE;
            }
            
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
}
