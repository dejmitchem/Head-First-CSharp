using System;
using System.Collections.Generic;
using System.Text;

namespace SloppyJoe_sMenu
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

        public string[] Breads = ["rye", "white", "wheat", "pumpernickel", "a roll"];

        public string Description = "";
        public string Price = "";

        public void Generate()
        {


        }
    }
}
