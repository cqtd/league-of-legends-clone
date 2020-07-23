using System.Collections.Generic;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

namespace CQ
{
	public class SingletonManager : MonoSingleton<SingletonManager>, IResetable
	{
		readonly List<IResetable> targets = new List<IResetable>();
		
		public void Register(IResetable singleton)
		{
			targets.Add(singleton);
		}

		public override void Reset()
		{
			var sw = new Stopwatch();
			sw.Start();
			Debug.Log($"{typeof(SingletonManager)}::Reset Start".Yellow());
			
			foreach (IResetable target in targets)
			{
				target?.Reset();
			}
			
			sw.Stop();
			Debug.Log($"{typeof(SingletonManager)}::Reset Complete::{sw.ElapsedMilliseconds}ms".Yellow());
		}
	}
}