using System;
using System.Collections.Generic;
using System.Text;

namespace ClownInterfaces
{
    interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();

        void ScareAdults()
        {
            Console.WriteLine($@"I am an ancient evil and will haunt your nightmares.
Behold my necklace with {Random.Shared.Next(4,10)} of my last victim's fingers.
Oh, also, before I forget...");
            ScareLittleChildren();
        }
    }
}
