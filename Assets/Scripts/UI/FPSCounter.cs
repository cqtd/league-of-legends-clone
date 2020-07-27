using System.Collections;
using TMPro;
using UnityEngine;

namespace CQ.LeagueOfLegends.UI
{
	public class FPSCounter : MonoBehaviour
	{
		public TextMeshProUGUI fps;

		float deltaTime = 0f;
		bool fpsCounter = true;
		
		void Start()
		{
			StartCoroutine(RenewFPSCounterLoop());
		}

		void Update()
		{
			deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
		}

		void RenewFPSCounter()
		{
			fps?.SetText($"FPS:{1/deltaTime:N0}");
		}

		IEnumerator RenewFPSCounterLoop()
		{
			while (fpsCounter)
			{
				yield return new WaitForSeconds(1.0f);
				RenewFPSCounter();		
			}
			
			yield break;
		}

		void OnDestroy()
		{
			fpsCounter = false;
		}
	}
}