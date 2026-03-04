using System;
using System.Collections.Generic;
using System.Text;

namespace ClownInterfaces
{
    class ScaryClown : FunnyClown, IScaryClown
    {
        private readonly int scaryThingCount;

        public string ScaryThingIHave { get { return $"{scaryThingCount} spiders"; } }

        public ScaryClown(int scaryThingCount,  string funnyThingIHave) : base(funnyThingIHave)
        {
            this.scaryThingCount = scaryThingCount;
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine($"Boo! Gotcha! Look at my {ScaryThingIHave}!");
        }.

    }
}
