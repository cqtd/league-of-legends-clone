using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace CQ.LeagueOfLegends.Game
{
	public class SpellInputHandler : InputHandlerBase, Rift.ISpellActions
	{
		protected override void Awake()
		{
			base.Awake();
			
			rift.Spell.SetCallbacks(this);
		}

		void OnEnable()
		{
			rift.Spell.Enable();
		}

		void OnDisable()
		{
			rift.Spell.Disable();
		}

		void DebugContext(InputAction.CallbackContext context, string msg)
		{
			if (context.started)
			{
				Debug.Log($"{msg}::Started".Green());
			}

			if (context.canceled)
			{
				Debug.Log($"{msg}::Canceled".Yellow());
			}
		}

		public void OnSpell1(InputAction.CallbackContext context)
		{
			DebugContext(context, "OnSpell::1");
		}

		public void OnSpell2(InputAction.CallbackContext context)
		{
			DebugContext(context, "OnSpell::2");
		}

		public void OnSpell3(InputAction.CallbackContext context)
		{
			DebugContext(context, "OnSpell::3");
		}

		public void OnSpell4(InputAction.CallbackContext context)
		{
			DebugContext(context, "OnSpell::4");
		}

		public void OnSpellSummoner1(InputAction.CallbackContext context)
		{
			DebugContext(context, "OnSpell::Summoner::1");
		}

		public void OnSpellSummoner2(InputAction.CallbackContext context)
		{
			DebugContext(context, "OnSpell::Summoner::2");
		}

		public void OnSpellRecall(InputAction.CallbackContext context)
		{
			DebugContext(context, "OnSpell::Recall");
		}

		public void OnSpellEmote(InputAction.CallbackContext context)
		{
			DebugContext(context, "OnSpell::Emote");
		}
	}
}