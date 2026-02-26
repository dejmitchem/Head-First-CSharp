using System;
using System.Collections.Generic;
using System.Text;

namespace BirdInheritancePractice
{
    class Bird
    {
        public virtual Egg[] LayEggs(int numberOfEggs)
        {
            Console.Error.WriteLine("Bird.LayEggs should never get called");
            return new Egg[0];
        }
    }
}
