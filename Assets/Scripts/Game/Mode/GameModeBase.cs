using System;
using UnityEngine;

namespace CQ.LeagueOfLegends.Game
{
	public enum EGameMode
	{
		SummonersRift,
		SummonersRiftUrf,
	}
	
	public class GameModeBase : MonoBehaviour
	{
		public EGameMode gameMode;
		public string[] teamBlue;
		public string[] teamPurple;

		void Awake()
		{
			var ctx = new GameModeContext.Builder();
			var db = new ChampionDatabase();

			foreach (string hero in teamBlue)
			{
				ctx.AddBluePlayer(db.GetChampionData(hero));
			}
			
			foreach (string hero in teamPurple)
			{
				ctx.AddPurplePlayer(db.GetChampionData(hero));
			}
			
			ctx.SetGameMode(this.gameMode);
			
			Launch(ctx.Build());
		}

		public void Launch(GameModeContext context)
		{
			
		}
	}
}