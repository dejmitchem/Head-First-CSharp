using System;
using System.Collections.Generic;
using System.Text;

namespace ClownInterfaces
{
    internal class FunnyClown : IClown
    {
        private string funnyThingIHave;

        public string FunnyThingIHave { get { return funnyThingIHave; }}

        public FunnyClown(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        public void Honk()
        {
            Console.WriteLine($"Hi Kids! I have {funnyThingIHave}.");
        }
            
    }
}
