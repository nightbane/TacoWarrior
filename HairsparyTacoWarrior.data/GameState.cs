namespace HairsparyTacoWarrior.data
{
	public class GameState
	{
		public string Venue;
		public int Stage;
		public Fighter Player;
	}

	public class Fighter {
		public string name;
		public int hitpoints;
		public List<Move> moves;

		public Fighter(string v1, int v2, List<Move> moves)
		{
			name = v1;
			hitpoints = v2;
			this.moves = moves;
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
