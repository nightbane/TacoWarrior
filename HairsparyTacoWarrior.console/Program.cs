// See https://aka.ms/new-console-template for more information
using HairsparyTacoWarrior.data;

Console.WriteLine("Hello, World!");


Console.Write("Create new game (y/n): ");
string choice = Console.ReadLine();

var game = new GameState();

if (choice.ToLower() == "y")
{

	game.Venue = "Subway";
	game.Stage = 1;
	game.Player = new Fighter("Carnitas", 100, new List<Move> { Move.Chop, Move.Kick });
	JsonData.DataSave(game);
}
else
{
	game = JsonData.DataLoad();
	choice = "y";
}


while (game.Player.hitpoints > 0 && choice != "n")
{

	Console.WriteLine("Level: " + game.Stage +
		", Hitpoints: " + game.Player.hitpoints);

	Console.Write("Damage taken: ");
	var hp = Console.ReadLine();

	if (int.TryParse(hp, out var num))
	{
		game.Player.hitpoints -= num;
	}
	game.Stage++;


	Console.Write("Continue (y/n): ");
	choice = Console.ReadLine();

}

JsonData.DataSave(game);

