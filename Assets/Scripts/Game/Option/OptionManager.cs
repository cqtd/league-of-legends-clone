using UnityEngine;

namespace CQ.LeagueOfLegends
{
	public class OptionManager : MonoSingleton<OptionManager>
	{
		public int targetFrame = 60;
		
		void Start()
		{
			Application.targetFrameRate = this.targetFrame;
		}
	}
}