using System;
using System.Collections.Generic;

namespace CQ.LeagueOfLegends.Game
{
	[Serializable]
	public class GameModeContext
	{
		public EGameMode gameMode;
		public ChampionData[] teamBlue;
		public ChampionData[] teamPurple;

		public class Builder
		{
			EGameMode gameMode;
			
			readonly List<ChampionData> teamBlue = new List<ChampionData>();
			readonly List<ChampionData> teamPurple = new List<ChampionData>();

			public Builder AddBluePlayer(ChampionData hero)
			{
				this.teamBlue.Add(hero);
				return this;
			}

			public Builder AddPurplePlayer(ChampionData hero)
			{
				this.teamPurple.Add(hero);
				return this;
			}

			public Builder SetGameMode(EGameMode mode)
			{
				this.gameMode = mode;
				return this;
			}

			public GameModeContext Build()
			{
				return new GameModeContext()
				{
					gameMode = this.gameMode,
					teamBlue = this.teamBlue.ToArray(),
					teamPurple = this.teamPurple.ToArray()
				};
			}
		}
	}
}