using NumberGuessApp.Models;

namespace NumberGuessApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guess Number Game");
            var game = new NumberGuessingGame();

            do
            {
                RunGameSession(game);
            } while (UserWantsToPlayAgain());

            Console.WriteLine("Thanks for playing!");
        }

        private static void RunGameSession(NumberGuessingGame game)
        {
            Console.WriteLine("You Will Be Asked To Guess A Number To Win The Game");
            game.ResetGame();

            int result;
            do
            {
                result = ProcessGuess(game);
            } while (result != 0);

            Console.WriteLine($"Yayyy! Your guessed number is correct. You took {game.GetTries()} tries!\n");
        }

        private static int ProcessGuess(NumberGuessingGame game)
        {
            var guess = GetUserGuess();
            var result = game.GuessNumber(guess);

            if (result == -1)
            {
                Console.WriteLine("Oops! Sorry, too low.");
            }
            else if (result == 1)
            {
                Console.WriteLine("Oops! Sorry, too high.");
            }

            return result;
        }

        private static int GetUserGuess()
        {
            int guess;
            Console.Write("Enter a guess number between 1 to 100: ");

            while (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            return guess;
        }

        private static bool UserWantsToPlayAgain()
        {
            Console.Write("Do you want to play again? (y/n): ");
            var response = Console.ReadLine()?.ToLower() ?? string.Empty;
            return response == "y";
        }
    }
}
