using HairsparyTacoWarrior.data;
using HairsparyTacoWarrior.logic;

namespace HairsprayTacoWarrior.logic
{
	public class GameRunner
	{
		private GameState state;

		public int Stage => state.Stage;
		public int HitPoints => state.Player.hitpoints;

		public bool IsGameOver()
		{
			return state.Player.hitpoints <= 0;
		}

		public void Fight(string hp)
		{
			if (string.IsNullOrEmpty(hp)) return;

			if (int.TryParse(hp, out var num))
			{
				state.Player.hitpoints -= num;
			}
			state.Stage++;
		}

		public void NewGame()
		{
			state = new GameState();
			state.Venue = "Subway";
			state.Stage = 1;
			state.Player = new Fighter("Carnitas", 100, new List<Move> { Move.Chop, Move.Kick });
			JsonData.DataSave(state.ToGameStateDO());
		}

		public void LoadGame()
		{
			state = GameState.FromGameStateDO(JsonData.DataLoad());
		}

		public void SaveGame()
		{
			JsonData.DataSave(state.ToGameStateDO());
		}
	}
}
