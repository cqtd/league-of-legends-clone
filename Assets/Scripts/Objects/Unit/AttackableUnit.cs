using System;
using UnityEngine;

namespace CQ.LeagueOfLegends
{
	
	public abstract class AttackableUnit : UnitBase
	{
		[Header("AttackableUnit")]
		[ReadOnly(EReadOnlyType.EDITABLE_RUNTIME)]
		[SerializeField] protected float health = -1;

		[ReadOnly(EReadOnlyType.EDITABLE_RUNTIME)]
		[SerializeField] protected float maxHealth = -1;

		[ReadOnly(EReadOnlyType.EDITABLE_RUNTIME)]
		[SerializeField] protected float mana = -1;

		[ReadOnly(EReadOnlyType.EDITABLE_RUNTIME)]
		[SerializeField] protected float maxMana = -1;
		
		
		public float GetHealth()
		{
			return this.health;
		}

		public float GetMaxHealth()
		{
			return this.maxHealth;
		}

		public float GetMana()
		{
			return this.mana;
		}

		public float GetMaxMana()
		{
			return this.maxMana;
		}

		public bool IsBot()
		{
			throw new NotImplementedException();
		}

		public bool IsZombie()
		{
			throw new NotImplementedException();
		}

		public bool IsVulnerable()
		{
			throw new NotImplementedException();
		}

		public float GetAllShield()
		{
			throw new NotImplementedException();
		}

		public float GetMagicShield()
		{
			throw new NotImplementedException();
		}
	}
}