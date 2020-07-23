using UnityEngine;

namespace CQ
{
	public class MonoSingleton<T> : MonoBehaviour, IResetable where T : MonoBehaviour
	{
		protected static T instance;
		public static T Instance
		{
			get
			{
				if (instance == null)
				{
					instance = FindObjectOfType(typeof(T)) as T;
					if (instance == null)
					{
						instance = new GameObject($"[{typeof(T)}]", typeof(T)).GetComponent<T>();
					}
				}
				return instance;
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		static void ResetDomain()
		{
			instance = null; 
			Debug.Log("Mono Reset Domain");
		}

		void OnApplicationQuit()
		{
			Debug.Log("Quit");
			Reset();
		}

		public virtual void Reset()
		{
			
		}
	}
}