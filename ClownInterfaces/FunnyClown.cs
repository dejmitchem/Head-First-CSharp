using System;
using System.Collections.Generic;
using System.Text;

namespace ClownInterfaces
{
    class FunnyClown(string funnyThingIHave) : IClown
    {
        public string FunnyThingIHave { get { return funnyThingIHave; }}

        public void Honk()
        {
            Console.WriteLine($"Hi Kids! I have {funnyThingIHave}.");
        }
            
    }
}
