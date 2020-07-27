using System;
using UnityEngine.InputSystem;

namespace CQ.LeagueOfLegends.Game
{
	public class MouseInputHandler : InputHandlerBase, Rift.IMouseActions
	{
		protected override void Awake()
		{
			base.Awake();
			
			rift.Mouse.SetCallbacks(this);
		}

		void OnEnable()
		{
			rift.Mouse.Enable();
		}

		void OnDisable()
		{
			rift.Mouse.Disable();
		}
		
		public void OnLeft(InputAction.CallbackContext context)
		{
			DebugContext(context, "OnLeft");
		}

		public void OnRight(InputAction.CallbackContext context)
		{
			DebugContext(context, "OnRight");
		}
	}
}