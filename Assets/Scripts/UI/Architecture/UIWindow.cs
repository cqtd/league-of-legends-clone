using System;
using UnityEngine;
using UnityEngine.UI;

namespace CQ.LeagueOfLegends.UI
{
	[RequireComponent(typeof(RectTransform))]
	[RequireComponent(typeof(Canvas))]
	[RequireComponent(typeof(GraphicRaycaster))]
	public abstract class UIWindow : MonoBehaviour, IDisposable
	{
		// public string windowName = default;
		bool inStartInit = false;
		
		protected bool isVisible = false;
		public bool IsVisible
		{
			get
			{
				return this.isVisible;
			}
		}
		
		RectTransform _rectTransform;
		protected RectTransform rectTransform
		{
			get
			{
				if (_rectTransform == null)
					_rectTransform = transform as RectTransform;

				return _rectTransform;
			}
		}

		bool isComponentInit = false;
		protected bool IsComponentInit
		{
			get
			{
				return isComponentInit;
			}
		}

		protected abstract void InitComponent();
		public abstract void Dispose();

		void Start()
		{
			Initialize();
			inStartInit = true;
		}

		public void OnEnable()
		{
			if (inStartInit)
			{
				Initialize();
			}
		}

		public virtual void Initialize()
		{
			if (!IsComponentInit)
			{
				InitComponent();
				isComponentInit = true;
			}
		}

		public void Show()
		{
			if (IsVisible)
			{
				Debug.LogWarning($"{this.gameObject.name}는 이미 열려 있음");
				return;
			}
			
			gameObject.SetActive(true);
			isVisible = true;
		}

		public void Hide()
		{
			if (!IsVisible)
			{
				Debug.LogWarning($"{this.gameObject.name}는 이미 숨겨져 있음");
				return;
			}

			isVisible = false;
			gameObject.SetActive(false);
		}

		public void ToggleVisibility()
		{
			if (IsVisible)
			{
				Hide();
			}
			else
			{
				Show();
			}
		}
	}
}