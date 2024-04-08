using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsparyTacoWarrior.data
{
	public record GameStateDO(string Venue, int Stage, FighterDO Player)
	{
		public GameStateDO() :this("", 0, new FighterDO())
		{
			
		}
	}
	public record FighterDO(string Name, int HitPoints, List<int> Moves)
	{
		public FighterDO() : this("", -1, new List<int>())
		{ }
	}
}
