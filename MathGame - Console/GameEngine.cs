using System.Dynamic;
using MathGame.Models;

namespace MathGame
{
    internal class GameEngine
    {
        Helpers helpers = new Helpers();

        internal void AddtionGame(int difficulty)
        {
            Random random = new Random();

            int firstnumber;
            int secondnumber;
            int score = 0;


            for (int i = 0; i < 5; i++)
            {

                Console.Clear();
                Console.WriteLine("Addtion game");
                firstnumber = random.Next(1, difficulty);
                secondnumber = random.Next(1, difficulty);

                Console.WriteLine($"What is {firstnumber} + {secondnumber}?");

                var answer = Console.ReadLine();
                if (string.IsNullOrEmpty(answer))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    i--;
                    continue;
                }
                answer = Helpers.ValueEntered(answer);

                if (!string.IsNullOrEmpty(answer) && int.Parse(answer) == firstnumber + secondnumber)
                {
                    Console.WriteLine("Correct. Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. You got {score} out of 5 correct. Type any key to start again");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Addition, (DifficultyTypes)difficulty);
        }

        internal void SubtractionGame(int difficulty)
        {
            Random random = new Random();

            int firstnumber;
            int secondnumber;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Subtraction game");
                firstnumber = random.Next(1, difficulty);
                secondnumber = random.Next(1, difficulty);

                Console.WriteLine($"What is {firstnumber} - {secondnumber}?");

                var answer = Console.ReadLine();
                if (string.IsNullOrEmpty(answer))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    i--;
                    continue;
                }
                answer = Helpers.ValueEntered(answer);

                if (!string.IsNullOrEmpty(answer) && int.Parse(answer) == firstnumber - secondnumber)
                {
                    Console.WriteLine("Correct. Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. You got {score} out of 5 correct. Type any key to start again.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Subtraction, (DifficultyTypes)difficulty);
        }

        internal void MultiplicationGame(int difficulty)
        {
            Random random = new Random();

            int firstnumber;
            int secondnumber;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Multiplication game");
                firstnumber = random.Next(1, difficulty);
                secondnumber = random.Next(1, difficulty);

                Console.WriteLine($"What is {firstnumber} * {secondnumber}?");

                var answer = Console.ReadLine();
                if (string.IsNullOrEmpty(answer))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    i--;
                    continue;
                }
                answer = Helpers.ValueEntered(answer);

                if (!string.IsNullOrEmpty(answer) && int.Parse(answer) == firstnumber * secondnumber)
                {
                    Console.WriteLine("Correct. Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. You got {score} out of 5 correct. Type any key to start again.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Multiplication, (DifficultyTypes)difficulty);
        }

        internal void DivisionGame(int difficulty)
        {
            int score = 0;
            int difficultyForDivision = difficulty;
             

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Division game");
                int[] divisionNumbers = Helpers.GetDivideNumbers(difficultyForDivision);
                int firstnumber = divisionNumbers[0];
                int secondnumber = divisionNumbers[1];

                Console.WriteLine($"What is {firstnumber} / {secondnumber}?");
                var answer = Console.ReadLine();
                if (string.IsNullOrEmpty(answer))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    i--;
                    continue;
                }
                answer = Helpers.ValueEntered(answer);

                if (!string.IsNullOrEmpty(answer) && int.Parse(answer) == firstnumber / secondnumber)
                {
                    Console.WriteLine("Correct. Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. You got {score} out of 5 correct. Type any key to start again.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Division, (DifficultyTypes)difficulty);
        }


    }

    

}
