using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace CQ.LeagueOfLegends
{
	public class UnitManager : MonoSingleton<UnitManager>
	{
		[SerializeField] Player localPlayer; 
		readonly List<UnitBase> units = new List<UnitBase>();
		
		public uint GetMaxSize()
		{
			return (uint) units.Count;
		}

		public UnitBase[] GetUnitArray()
		{
			return units.ToArray();
		}

		public UnitBase GetUnitByIndex(int index)
		{
#if UNITY_EDITOR
			Assert.IsTrue(units.Count > index);
#endif
			return units[index];
		}

		public void AddUnit()
		{
			units.Add(null);
			Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
		}

		public Player GetLoaclPlayer()
		{
			return localPlayer;
		}
	}
}