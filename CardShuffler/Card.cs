using System;
using System.Collections.Generic;
using System.Text;

namespace CardClass
{
    class Card(Suits suit, Values value)
    {
        public Suits Suit { get { return suit; } }
        public Values Value { get { return value; } }
        public string Name { get { return $"{Value} of {Suit}"; } }
    }
}
