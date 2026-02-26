using System;
using System.Collections.Generic;
using System.Text;

namespace BirdInheritancePractice
{
     class Ostrich : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i<numberOfEggs; i++)
            {
                eggs[i] = new Egg(Random.Shared.NextDouble() + 12, "speckled");
            }
            return eggs;
        }
    }
}
