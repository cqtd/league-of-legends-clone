using CQ.LeagueOfLegends;
using UnityEngine;

namespace CQ
{
	public class Foo : MonoBehaviour
	{
		void Start()
		{
			//SingletonManager.Instance.Foo();
			UnitManager.Instance.AddUnit();
			UnitManager.Instance.AddUnit();
			
			var a = UnitManager.Instance.GetMaxSize();
			
			var unit1 = UnitManager.Instance.GetUnitByIndex(1);
			
			Debug.Log(a);
		}
	}
}