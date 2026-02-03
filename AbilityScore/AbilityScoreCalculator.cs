using System;
using System.Collections.Generic;
using System.Text;

namespace AbilityScore
{
    internal class AbilityScoreCalculator
    {
        public int RollResult = 14;
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;

        /// <summary>
        /// Calculate the ability score using the following steps:
        /// 1. Divide <see cref="RollResult"/> by <see cref="DivideBy"/>.
        /// 2. Convert the divided result to an integer and add <see cref="AddAmount"/>.
        /// 3. If the result is less than <see cref="Minimum"/>, set <see cref="Score"/> to <see cref="Minimum"/>;
        ///    otherwise set <see cref="Score"/> to the computed value.
        /// </summary>
        public void CalculateAbilityScore()
        {
            double divided = RollResult / DivideBy;

            int added = AddAmount + (int)divided;

            if (added < Minimum)
            {
                Score = Minimum;
            }
            else
            {
                Score = added;
            }

        }
    }
}
