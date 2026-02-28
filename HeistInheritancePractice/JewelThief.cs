using System;
using System.Collections.Generic;
using System.Text;

namespace HeistInheritancePractice
{
    class JewelThief : Locksmith
    {
        private string stolenJewels = "";
        protected override void ReturnContents(string safeContents, SafeOwner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine($" I'm stealing the jewels! I stole: {stolenJewels}");
        }
    }
}
