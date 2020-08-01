using CQ.LeagueOfLegends.Objects;
using UnityEngine;

namespace CQ.LeagueOfLegends
{
	public class Player : AIHeroClient
	{
		public bool CastSpell(ESpellSlot slot)
		{
			return this.spellbook.CastSpell(slot);
		}

		public void Move(Vector3 pos)
		{
			Debug.Log("Moving");
			
			// agent.isStopped = false;
			agent.SetDestination(pos);
		}

		public void Move(UnitBase unit)
		{
			this.Move(unit.GetPosition());
		}

		public void Stop()
		{
			agent.isStopped = true;
		}

		public void Attack(AttackableUnit attackableUnit)
		{
			
		}
	}
}