namespace MathGame
{
    internal class Menu
    {
        GameEngine engine = new();
        
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine($"Hello {name}. It's {date}. this is your Math'sGame. That's great that you're working on improving yourself\n");
            Console.WriteLine("Press any key to show menu");
            Console.ReadLine();

            bool isGameOn = true;

            do
            {
                Console.WriteLine("Plese, select one of difficultys levels below:");
                Console.WriteLine("1 - Easy (0-9)");
                Console.WriteLine("2 - Medium (0-99)");
                Console.WriteLine("3 - Hard (0-999");

                var difficultySelected = Console.ReadLine();
                if (string.IsNullOrEmpty(difficultySelected))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
                difficultySelected = Helpers.ValueEntered(difficultySelected);
                if (!int.TryParse(difficultySelected, out int difficulty))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }
                else
                {
                    difficulty = int.Parse(difficultySelected);
                }

                switch(difficulty)
                {
                    case 1:
                        difficulty = 9;
                        break;
                    case 2:
                        difficulty = 99;
                        break;
                    case 3:
                        difficulty = 999;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        continue;
                }


                Console.Clear();
                Console.WriteLine("--------------------");
                Console.WriteLine("What game would you loke to play today? Choose from the option below:");
                Console.WriteLine("A - Addttion");
                Console.WriteLine("S - Subtraction");
                Console.WriteLine("M - Multiplication");
                Console.WriteLine("D - Division");
                Console.WriteLine("V - View Previous Scores");
                Console.WriteLine("Q - Quit program");
                Console.WriteLine("--------------------");

                string? gameSelected = Console.ReadLine();

                if (gameSelected == null)
                {
                    Console.WriteLine("Invalid selection, try again");
                    continue;
                }


                switch (gameSelected.ToUpper().Trim())
                {
                    case "A":
                        engine.AddtionGame(difficulty);
                        break;
                    case "S":
                        engine.SubtractionGame(difficulty);
                        break;
                    case "M":
                        engine.MultiplicationGame(difficulty);
                        break;
                    case "D":
                        engine.DivisionGame(difficulty);
                        break;
                    case "Q":
                        Console.WriteLine("Quit program");
                        isGameOn = false;
                        Environment.Exit(1);
                        break;
                    case "V":
                        Helpers.PrintGames();
                        break;
                    default:
                        Console.WriteLine("Invalid selection, goodbye");
                        Environment.Exit(1);
                        break;
                }
            } while (isGameOn);
        }
    }
}
