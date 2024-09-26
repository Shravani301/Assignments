using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessApp.Models
{
    internal class NumberGuessingGame
    {
        private int targetNumber { get; set; }
        static int tries;
        private Random random;
        const int lowerBound = 1;
        const int upperBound = 100;

        public NumberGuessingGame()
        {
            random = new Random();
            ResetGame();
        }

        public void ResetGame()
        {
            targetNumber = random.Next(lowerBound, upperBound);
            tries = 0;
        }

        public int GetTries()
        {
            return tries;
        }

        public int GuessNumber(int guess)
        {
            tries++;
            if (guess < targetNumber)
            {
                return -1; 
            }
            else if (guess > targetNumber)
            {
                return 1; 
            }
            return 0; 
        }
    }
}
