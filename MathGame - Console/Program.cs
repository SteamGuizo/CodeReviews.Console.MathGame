using MathGame;
using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;

var menu = new Menu();
var date = DateTime.UtcNow;

List<string> games = new ();

string? name = GetName();

menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Please type your name");
    string? name = Console.ReadLine();
    if (name == null)
    {
        Console.WriteLine("Invalid name, goodbye");
        Environment.Exit(1);
    }
    return name;
}