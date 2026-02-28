using System;
using System.Collections.Generic;
using System.Text;

namespace HeistInheritancePractice
{
    class Locksmith
    {
        public void OpenSafe(Safe safe, SafeOwner owner)
        {
            safe.PickLock(this);
            string safeContents = safe.Open(Combination);
            ReturnContents(safeContents, owner);
        }

        public string Combination { get; set; } = "";

        protected virtual void ReturnContents(string safeContents, SafeOwner owner)
        {
            owner.ReceiveValuables(safeContents);
        }
    }
}
