using System;
using System.Collections.Generic;
using System.Text;

namespace SloppyJoe
{
    internal class MenuItem
    {
        public string[] Proteins = [
            "Roast beef", "Salami", "Turkey",
            "Ham", "Pastrami", "Tofu"
            ];

        public string[] Condiments = [
            "yello mustard", "brown mustard",
            "honey mustard", "mayo", "relish", "French dressing"
            ];

        public string[] Breads = ["rye", "white", "wheat", "pumpernickel", "a roll", "sourdough"];

        public string Description = "";
        public string Price = "";

        public void Generate()
        {
            int[] values = [0, 0, 0];
            for (int i = 0; i < 3; i++)
                values[i] = Random.Shared.Next(0, 6);

            Description = $"{Proteins[values[0]]} with {Condiments[values[1]]} on {Breads[values[2]]}";

            int pounds = Random.Shared.Next(1, 16);
            decimal pence = Random.Shared.Next(0, 100) * 0.1M;
            decimal price = pounds + pence;
            Price = price.ToString("c");

        }
    }
}

