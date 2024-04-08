// See https://aka.ms/new-console-template for more information
using HairsprayTacoWarrior.logic;

var game = new GameRunner();

Console.Write("Create new game (y/n): ");
string choice = Console.ReadLine() ?? "";

if (choice.ToLower() == "y")
{
	game.NewGame();
}
else
{
	game.LoadGame();
	choice = "y";
}


while (!game.IsGameOver() && choice != "n")
{
	Console.WriteLine("Level: " + game.Stage +
		", Hitpoints: " + game.HitPoints);

	Console.Write("Damage taken: ");
	var hp = Console.ReadLine() ?? "";

	game.Fight(hp);

	Console.Write("Continue (y/n): ");
	choice = Console.ReadLine() ?? "";

}

game.SaveGame();

