using UnityEngine;
using UnityEngine.InputSystem;

namespace CQ.LeagueOfLegends.Game
{
	public abstract class InputHandlerBase : MonoBehaviour
	{
		protected Rift rift;
		[SerializeField] protected bool debugContext = true;

		public static bool globalDebugContext = true;

		protected virtual void Awake()
		{
			rift = new Rift();
		}
		
		protected void DebugContext(InputAction.CallbackContext context, string msg)
		{
			if (!debugContext) return;
			if (!globalDebugContext) return;
			
			if (context.started)
			{
				Debug.Log($"{msg}::Started".Green());
			}

			if (context.canceled)
			{
				Debug.Log($"{msg}::Canceled".Yellow());
			}
		}
		
	}
}