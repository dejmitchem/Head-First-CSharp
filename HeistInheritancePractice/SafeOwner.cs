using System;
using System.Collections.Generic;
using System.Text;

namespace HeistInheritancePractice
{
    class SafeOwner
    {
        private string valuables = "";
        public void ReceiveValuables(string safeContents)
        {
            valuables = safeContents;
            Console.WriteLine($"Thank you for returning my {valuables}");
        }
    }
}
