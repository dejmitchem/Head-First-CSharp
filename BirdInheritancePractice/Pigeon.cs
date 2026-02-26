using System;
using System.Collections.Generic;
using System.Text;

namespace BirdInheritancePractice
{
     class Pigeon : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i<numberOfEggs; i++)
            {
                eggs[i] = new Egg(Random.Shared.NextDouble() * 2 + 1, "white");
            }
            return eggs;
        }
    }
}
