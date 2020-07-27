using CQ.LeagueOfLegends.Objects;
using UnityEngine;

namespace CQ.LeagueOfLegends
{
	public abstract class AIBase : AttackableUnit
	{
		[Header("AIBase")] 
		[ReadOnly(EReadOnlyType.EDITABLE_RUNTIME)] [SerializeField]
		protected float gold = -1;

		[ReadOnly(EReadOnlyType.EDITABLE_RUNTIME)] [SerializeField]
		protected float goldTotal = -1;

		public HeroInventory inventory;
	}
}