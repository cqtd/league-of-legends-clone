using System;
using CQ.LeagueOfLegends.Objects;
using UnityEngine;

namespace CQ.LeagueOfLegends
{
	public class AIHeroClient : AIBase
	{
		[Header("AI Hero Client")]
		[ReadOnly(EReadOnlyType.EDITABLE_RUNTIME)]
		[SerializeField] protected string championName = default;

		[ReadOnly(EReadOnlyType.EDITABLE_RUNTIME)] [SerializeField]
		protected Experience experience;

		[ReadOnly(EReadOnlyType.EDITABLE_RUNTIME)] [SerializeField]
		protected int level;

		[ReadOnly(EReadOnlyType.EDITABLE_RUNTIME)] [SerializeField]
		protected Avatar avatar;

		[SerializeField] protected Animator animator;
		[SerializeField] protected SkinnedMeshRenderer meshRenderer;
		
		
		public bool DoEmote(int emoteID)
		{
			return false;
		}

		public string GetChampionName()
		{
			return this.championName;
		}

		public Experience GetExperience()
		{
			return this.experience;
		}

		public int GetLevel()
		{
			return this.level;
		}

		public Avatar GetAvatar()
		{
			return this.avatar;
		}
	}
}