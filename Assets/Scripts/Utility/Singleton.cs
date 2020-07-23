using UnityEngine;

namespace CQ
{
	public interface IResetable
	{
		void Reset();
	}
	
	[System.Serializable]
	public abstract class Singleton<T> : IResetable where T : IResetable, new()
	{
		static T instance;
		public static T Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new T();
					SingletonManager.Instance.Register(instance);
				}

				return instance;
			}
		}
		
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void DomainReset()
		{
			instance = default;
			Debug.Log("DomainReset");
		}

		public void Reset()
		{
			instance = default;
			Debug.Log($"{typeof(T)}::Reset");
		}
	}
}