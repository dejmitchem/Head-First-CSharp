using System;
using System.Collections.Generic;
using System.Text;

namespace ElephantObjects
{
    internal class Elephant
    {
        public int EarSize;
        public string? Name;
        public void WhoAmI()
        {
            Console.WriteLine($"Calling {Name}.WhoAmI");
            Console.WriteLine($"My name is {Name}.");
            Console.WriteLine($"My ear size is {EarSize}.");
        }


        public void HearMessage(string message, Elephant whoSaidIt)
        {
            Console.WriteLine(Name + " heard a message");
            Console.WriteLine(whoSaidIt.Name + " said this: " + message);
        }

        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.HearMessage(message, this);
        }
    }
}


