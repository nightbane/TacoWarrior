using HairsparyTacoWarrior.data;
using System.Threading.Tasks.Sources;

namespace HairsparyTacoWarrior.logic
{
	public class GameState
	{
		public string Venue;
		public int Stage;
		public Fighter Player;

		public GameStateDO ToGameStateDO()
		{
			var data = new GameStateDO(Venue, Stage, Player.ToFighterDO());
			return data;
		}

		public static GameState FromGameStateDO(GameStateDO data)
		{
			var state = new GameState
			{
				Venue = data.Venue,
				Stage = data.Stage,
				Player = Fighter.FromFighterDO(data.Player)
			};
			return state;
		}
	}

	public class Fighter {
		public string name;
		public int hitpoints;
		public List<Move> moves;

		public Fighter(string n, int h, List<Move> moves)
		{
			name = n;
			hitpoints = h;
			this.moves = moves;
		}

		public FighterDO ToFighterDO()
		{
			var data = new FighterDO(name, hitpoints,
				moves.Select(i => (int)i).ToList());
			return data;
		}
		public static Fighter FromFighterDO(FighterDO data)
		{
			var fighter = new Fighter(
				data.Name,data.HitPoints,
				data.Moves.Select(i => (Move)i).ToList()
			);
			return fighter;
		}

	}

	public enum Move
	{
		Chop,
		Kick,
		DragonPunch,
		NachoKick
	}
}
