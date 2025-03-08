namespace MathGame.Models;

class Game
{
    public DateTime Date { get; set; }

    public int Score { get; set; }

    public GameType Type { get; set; }

    public DifficultyTypes Difficulty { get; set; }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division
} // Function used to describe the type of game that exitst in the program.

internal enum DifficultyTypes
{
    Easy = 9,
    Medium = 99,
    Hard = 999
} // Function used to describe the difficulty of the game that exists in the program.