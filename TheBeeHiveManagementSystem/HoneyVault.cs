using System;
using System.Collections.Generic;
using System.Text;

namespace TheBeeHiveManagementSystem
{
    static class HoneyVault
    {
        private static decimal honey = Constants.INITIAL_HONEY;
        private static decimal nectar = Constants.INITIAL_NECTAR;

        public static string StatusReport
        {
            get
            {
                string report = $"Honey: {honey}\nNectar: {nectar}";
                if (honey < Constants.LOW_LEVEL_WARNING)
                {
                    report += "\nLOW HONEY - ADD A HONEY MANUFACTURER";
                }
                if (nectar < Constants.LOW_LEVEL_WARNING)
                {
                    report += "\nLOW NECTAR - ADD A NECTAR COLLECTOR";
                }
                return report;
            }
        }

        public static bool ConsumeHoney(decimal amount)
        {
            if (honey >= amount)
            {
                honey -= amount;
                return true;
            }
            else return false;
        }

        public static void CollectNectar(decimal amount)
        {
            nectar += amount;
        }

        public static void ConvertNectarToHoney(decimal amount)
        {
            if (nectar < amount)
            {
                amount = nectar;
            }
            nectar -= amount;
            honey += amount * Constants.NECTAR_CONVERSION_RATIO;

        }
        public static void Reset()
        {
            honey = Constants.INITIAL_HONEY;
            nectar = Constants.INITIAL_NECTAR;
        }
    }
}
