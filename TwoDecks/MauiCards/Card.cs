using System;
using System.Collections.Generic;
using System.Text;

namespace MauiCards
{
    class Card(Suits suit, Values value)
    {
        public Suits Suit { get { return suit; } }
        public Values Value { get { return value; } }
        public string Name { get { return $"{Value} of {Suit}"; } }

        override public string ToString()
        {
            return Name;
        }
    }
}
