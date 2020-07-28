using UnityEngine;

namespace CQ.LeagueOfLegends.UI
{
	public class UIBootstrap : MonoBehaviour
	{
		public string prefabName;

		[ContextMenu("Open")]
		void Open()
		{
			UIManager.Instance.Open(prefabName);
		}

		
		[ContextMenu("Close")]
		void Close()
		{
			UIManager.Instance.Close(prefabName);
		}
	}
}