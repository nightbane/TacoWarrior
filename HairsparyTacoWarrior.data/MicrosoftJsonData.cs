using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace HairsparyTacoWarrior.data
{
	public class MicrosoftJsonData : IDataSource
	{
		public const string _filename = "game.data";

		public GameStateDO DataLoad()
		{
			string data = "{}";
			using (var file = new StreamReader(_filename))
			{
				data = file.ReadToEnd();
			}
			var game = JsonSerializer
				.Deserialize<GameStateDO>(data)
				?? new GameStateDO();
			return game;
		}

		public void DataSave(GameStateDO game)
		{
			using (var file = new StreamWriter(_filename))
			{
				var serial = JsonSerializer.Serialize(game);
				file.Write(serial);
			}
		}
	}
}
