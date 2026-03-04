using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace FinalWeaponDamageCalculator
{
    abstract class WeaponDamage
    {
        int roll;
        bool magic;
        bool flaming;
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }
        public int Damage { get; protected set; }

        public WeaponDamage(int roll)
        {
            Roll = roll;
            CalculateDamage();
        }

        protected abstract void CalculateDamage();
    }
}
