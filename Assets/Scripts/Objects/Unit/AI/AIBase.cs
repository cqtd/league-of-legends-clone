using CQ.LeagueOfLegends.Objects;
using UnityEngine;
using UnityEngine.AI;

namespace CQ.LeagueOfLegends
{
	[RequireComponent(typeof(NavMeshAgent))]
	public abstract class AIBase : AttackableUnit
	{
		[Header("AIBase")] 
		[ReadOnly(EReadOnlyType.EDITABLE_RUNTIME)] [SerializeField]
		protected float gold = -1;

		[ReadOnly(EReadOnlyType.EDITABLE_RUNTIME)] [SerializeField]
		protected float goldTotal = -1;

		public HeroInventory inventory;

		public NavMeshAgent agent;
	}
}