using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Practice
{
    class TallGuy : IClown
    {
        private string? name;
        private int height;
        public string FunnyThingsIHave { get { return "big shoes"; } }

        public TallGuy(string? name, int height)
        {
            this.name = name;
            this.height = height;
        }

        public void TalkAboutYourself()
        {
            Console.WriteLine($"My name is {name} and I am {height} inches tall.");
        }

        public void Honk()
        {
            Console.WriteLine("Honk honk!");
        }
    }
}
