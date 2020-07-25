using UnityEngine;

namespace CQ.LeagueOfLegends.Game
{
	public abstract class InputHandlerBase : MonoBehaviour
	{
		protected Rift rift;

		protected virtual void Awake()
		{
			rift = new Rift();
		}
	}
}