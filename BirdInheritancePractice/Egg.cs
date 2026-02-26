using System;
using System.Collections.Generic;
using System.Text;

namespace BirdInheritancePractice
{
    class Egg
    {
        public double Size { get; private set; }
        public string Color { get; private set; }
        public Egg(double size, string color)
        {
            Size = size;
            Color = color;
        }
        public string Description
        {
            get { return $"A {Size:0.00cm} {Color} egg"; }
        }
    }
}
