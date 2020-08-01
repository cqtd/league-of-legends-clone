using UnityEditor;

namespace CQ.LeagueOfLegends.Editor
{
	[CustomEditor(typeof(UnitManager))]
	public class UnitManagerEditor : UnityEditor.Editor
	{
		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();

			// EditorGUILayout.ObjectField("LocalPlayer", ((UnitManager) target).GetLoaclPlayer(), typeof(AIHeroClient), true);
		}
	}
}