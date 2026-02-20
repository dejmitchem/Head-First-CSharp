using System;
using System.Collections.Generic;
using System.Text;

namespace Hi_Lo_Game
{
    static class HiLoGame
    {
        public const int MAXIMUM = 10;
        public static int currentNumber = Random.Shared.Next(1, MAXIMUM + 1);
        public static int nextNumber = Random.Shared.Next(1, MAXIMUM + 1);
        private static int pot = 10;


        static public int GetPot()
        {
            return pot;
        }

        static public void Guess(bool guess)
        {
            if (guess == (nextNumber >= currentNumber))
            {
                Console.WriteLine("You guessed right!");
                pot++;
            }
            else
            {
                Console.WriteLine("Bad luck, you guessed wrong");
                pot--;
            }
            currentNumber = nextNumber;
            nextNumber= Random.Shared.Next(1, MAXIMUM + 1);
            Console.WriteLine($"The current number is {currentNumber}");
        }

        static public void Hint()
        {
            int half = MAXIMUM / 2;

            if (nextNumber >= half) Console.WriteLine($"The current number is {currentNumber} " +
                $"The next number is at least {half}");
            else Console.WriteLine($"The current number us {currentNumber} " +
                $"The next number is at most {half}");
            pot--;
        }
    }
}
