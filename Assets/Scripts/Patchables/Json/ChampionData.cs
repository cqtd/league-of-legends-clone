using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Assertions;

namespace CQ.LeagueOfLegends
{
	//https://developer.riotgames.com/docs/lol
	//http://ddragon.leagueoflegends.com/cdn/10.14.1/data/ko_KR/championFull.json

	class Utility
	{
#if UNITY_EDITOR
		[UnityEditor.MenuItem("Tools/Champion Count")]
#endif
		static void ParseJson()
		{
			const string path = "Assets/Content/RawData/10.14.1.ko_KR.json";
			var f = JsonConvert.DeserializeObject<Full>(File.ReadAllText(path));
			
			Debug.Log($"Champion Count :: {f.data.Count}".Bold());
		}
#if UNITY_EDITOR
		[UnityEditor.MenuItem("Tools/Parse Champion Data")]
#endif
		static void ParseChampionData()
		{
			
		}
	}

	public class ChampionDatabase
	{
		readonly Dictionary<string, ChampionData> map;
		
		public ChampionDatabase()
		{
			const string path = "Assets/Content/RawData/10.14.1.ko_KR.json";
			var f = JsonConvert.DeserializeObject<Full>(File.ReadAllText(path));

			map = f.data;
		}

		public ChampionData GetChampionData(string championName)
		{
			if (map.TryGetValue(championName, out ChampionData data))
			{
				return data;
			}
			
#if UNITY_EDITOR
			throw new Exception($"Failed to find champion data::{championName}".Magenta());
#else
			return null;
#endif
		}
	}

	[Serializable]
	public class Full
	{
		public Dictionary<string, ChampionData> data;
	}
	
	[Serializable]
	public class ChampionData
	{
		public uint key;
		public string id;
		public string name;
		public string title;
		
		public ImageData image;
		public List<ChampionSkin> skins;
		
		public string lore;
		public string blurb;
		public string[] allytips;
		public string[] enemytips;
		public string[] tags;
		public string partytype;

		public ChampionInfo info;
		public ChampionStat stats;
		public ChampionSpell[] spells;

		public ChampionPassive passive;
		public ChampionRecommend[] reommended;
	}

	[Serializable]
	public class ImageData
	{
		public string full;
		public string sprite;
		public string group;
		public int x;
		public int y;
		public int w;
		public int h;
	}

	[Serializable]
	public class ChampionSkin
	{
		public uint id;
		public int num;
		public string name;
		public bool chromas;
	}

	[Serializable]
	public class ChampionInfo
	{
		public byte attack;
		public byte defense;
		public byte magic;
		public byte difficulty;
	}

	[Serializable]
	public class ChampionStat
	{
		public float hp;
		public float hpperlevel;
		public float mp;
		public float mpperlevel;
		public float movespeed;
		public float armor;
		public float armorperlevel;
		public float spellblock;
		public float spellblockperlevel;
		public float attackrange;
		public float hpregen;
		public float hpregenperlevel;
		public float mpregen;
		public float mpregenperlevel;
		public float crit;
		public float critperlevel;
		public float attackdamage;
		public float attackdamageperlevel;
		public float attackspeedperlevel;
		public float attackspeed;
	}

	[Serializable]
	public class ChampionSpell
	{
		public string id;
		public string name;
		public string description;
		public string tooltip;
		public LevelTip leveltip;
		public uint maxrank;
		public uint[] cooldown;
		public string cooldownBuron;
		public uint[] cost;
		public string costBurn;
		//public object datavalues;
		public float[][] effect;
		public string[] effectBurn;
		public Variables[] vars;
		public string costType;
		public int maxAmmo;
		public float[] range;
		public string rangeBurn;
		public ImageData image;
		public string resources;
	}

	[Serializable]
	public class LevelTip
	{
		public List<string> label;
		public List<string> effect;
	}

	[Serializable]
	public class Variables
	{
		public string link;
		//public float coeff; // possible array
		public string key;
	}
	
	[Serializable]
	public class ChampionPassive
	{
		public string name;
		public string description;
		public ImageData image;
	}

	[Serializable]
	public class ChampionRecommend
	{
		//@ todo
	}
}