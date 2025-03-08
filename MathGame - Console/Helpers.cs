using MathGame.Models;

namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>()
        {
        };

        internal static string? ValueEntered(string answer)
        {

            while (string.IsNullOrEmpty(answer) || !Int32.TryParse(answer, out _))
            {
                Console.WriteLine("Please enter a valid number");
                answer = Console.ReadLine() ?? string.Empty;
            }

            return answer;
        }

            /*string? readResult;
            string valueEntered = "";
            int numValue = 0;
            bool validNumber = false;

            readResult = Console.ReadLine();
            {

                if (readResult == null)
                {
                    Console.WriteLine("Sorry, you entered a null input, please try again");
                }
                else
                {
                    valueEntered = readResult;
                }

                validNumber = int.TryParse(valueEntered, out numValue);
                if (validNumber == true)
                {
                    return validNumber;
                }
                else
                {
                    Console.WriteLine("Sorry, you entered a invalid input, please try again");
                    return null;
                }
            }
        }*/ // Function used to validate the input of a user as a integer.

        internal static int[] GetDivideNumbers(int difficultyForDivision)
        {
            
            
            Random random = new Random();
            int firstnumber = random.Next(1, difficultyForDivision);
            int secondnumber = random.Next(1, difficultyForDivision);

            while (firstnumber % secondnumber != 0)
            {
                firstnumber = random.Next(1, 99);
                secondnumber = random.Next(1, 99);
            }

            var result = new int[2];
            result[0] = firstnumber;
            result[1] = secondnumber;

            return result;
        } // Function used to get two random numbers that can be divided evenly.

        internal static void PrintGames()
        {
            
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("--------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type} in {game.Difficulty} mode: {game.Score} pts");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Type any key to return to the main menu.");
            Console.WriteLine("--------------------");
            Console.ReadLine();
        } // Function used to display the previous scores of the user.

        internal static void AddToHistory(int gameScore, GameType gameType, DifficultyTypes difficulty)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType,
                Difficulty = difficulty
            });
        }
    }
}
