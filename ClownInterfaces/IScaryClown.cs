using System;
using System.Collections.Generic;
using System.Text;

namespace ClownInterfaces
{
    interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();
    }
}
