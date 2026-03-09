using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeCollection
{
    class Shoe(Style style, string? color)
    {
        public Style Style { get { return style; } }

        public string? Color { get { return color; } }

        public string Description { get { return $"A {color} {style}"; } }
    }
}
