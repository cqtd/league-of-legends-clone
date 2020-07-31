using System;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.UI;

namespace CQ.LeagueOfLegends
{
	public class NativeScreen : MonoBehaviour
	{
		public static Action<Vector2> OnScreenSizeChangeCallback;
		public int throttleFrameCount = 5;
		public CanvasScaler canvasScaler;

		IDisposable screenSizeChangeCallback;

		Vector2 screenSize; 
		Vector2 ratio;

		const float tolerance = 0.1f;

		bool IsScreenSizeChanged
		{
			get
			{
				return Math.Abs(screenSize.x - Screen.width) > tolerance ||
				       Math.Abs(screenSize.y - Screen.height) > tolerance;
			}
		}

		void Start()
		{
			RegisterScreenSizeChangeCallback();
		}
		
		void RegisterScreenSizeChangeCallback()
		{
			if (screenSizeChangeCallback == null) {
				screenSizeChangeCallback = this.FixedUpdateAsObservable()
					.Select(_ => IsScreenSizeChanged)
					.DistinctUntilChanged()
					.ThrottleFrame(throttleFrameCount)
					.Where(x => x)
					.Subscribe(x => OnScreenSizeChanged()).AddTo(this);
			}
		}
		
		void OnScreenSizeChanged()
		{
			screenSize = new Vector2(Screen.width, Screen.height);
			ratio = new Vector2(canvasScaler.referenceResolution.x / screenSize.x, canvasScaler.referenceResolution.y / screenSize.y);
			OnScreenSizeChangeCallback?.Invoke(screenSize);

#if UNITY_EDITOR
			Debug.Log($"<color=yellow>Screen size changed! : {screenSize.x}x{screenSize.y}</color>");
#endif
		}
	}
}