﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HairsparyTacoWarrior.data
{
	public static class JsonData
	{
		public static readonly string _filename = "game.data";

		public static GameState DataLoad()
		{
			string data = "{}";
			using(var file = new StreamReader(_filename))
			{
				data = file.ReadToEnd();
			}
			var game = JsonConvert
				.DeserializeObject<GameState>(data)
				?? new GameState();
			return game;
		}

		public static void DataSave(GameState game)
		{
			using (var file = new StreamWriter(_filename)) 
			{ 
				var serial = JsonConvert.SerializeObject(game);
				file.Write(serial);
			}
		}
	}
}