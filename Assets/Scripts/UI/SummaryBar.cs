using System;
using System.Diagnostics;
using TMPro;
using UnityEngine;

namespace CQ.LeagueOfLegends.UI
{
	public class SummaryBar : MonoBehaviour
	{
		public TextMeshProUGUI gameTime;
		public TextMeshProUGUI fps;

		float previous;
		Stopwatch sw;
		
		void Awake()
		{
			sw = new Stopwatch();
		}

		void Start()
		{
			sw.Start();
			previous = sw.ElapsedMilliseconds;
		}

		void Update()
		{
			float current = sw.ElapsedMilliseconds;
			float tick = current - previous;
			previous = current;
			
			gameTime?.SetText($"{tick:N0}");
		}
	}
}