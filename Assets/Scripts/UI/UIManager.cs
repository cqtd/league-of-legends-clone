using System.Collections.Generic;
using UnityEngine;

namespace CQ.LeagueOfLegends.UI
{
	public class UIManager : MonoSingleton<UIManager>
	{
		Dictionary<string, UIWindow> windows;

		void Awake()
		{
			var canvas = GetComponent<Canvas>();
			
			canvas.worldCamera = Camera.main;
			canvas.planeDistance = 1;
		}

		void Start()
		{
			windows = new Dictionary<string, UIWindow>();
		}

		public T Open<T>(string windowName) where T : UIWindow
		{
			if (windows.TryGetValue(windowName, out UIWindow window))
			{
				if (window is T typedWindow)
				{
					typedWindow.Show();
					
					return typedWindow;
				}
				
				return null;
			}

			T prefab = Resources.Load<T>(windowName);
			window = Instantiate(prefab, this.transform); 
			window.name = windowName;
			window.Show();
			
			windows[windowName] = window;

			return (T) window;
		}
		
		public UIWindow Open(string windowName)
		{
			if (windows.TryGetValue(windowName, out var window))
			{
				window.Show();
				
				return window;
			}

			UIWindow prefab = Resources.Load<UIWindow>(windowName);
			window = Instantiate(prefab, this.transform);
			window.name = windowName;
			window.Show();
			
			windows[windowName] = window;
			
			return window;
		}

		public bool Close(string windowName)
		{
			if (windows.TryGetValue(windowName, out var window))
			{
				if (window.IsVisible)
				{
					window.Hide();
					return true;
				}
				
				return false;
			}

			return false;
		}
	}
}