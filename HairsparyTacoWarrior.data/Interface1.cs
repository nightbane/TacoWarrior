using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsparyTacoWarrior.data
{
	public interface IDataSource
	{
		GameStateDO DataLoad();
		void DataSave(GameStateDO game);

	}
}
