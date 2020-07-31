using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace CQ.LeagueOfLegends.Editor
{
	[CreateAssetMenu(fileName = "Workspace", menuName = "Editor/Work space", order = int.MaxValue)]
	public class Workspace : ScriptableObject
	{
		public SceneAsset mainScene;
		public List<SceneAsset> subscenes = new List<SceneAsset>();

		[ContextMenu("Open")]
		public void Open()
		{
			EditorSceneManager.OpenScene(AssetDatabase.GetAssetPath(mainScene));

			foreach (SceneAsset subscene in subscenes)
			{
				EditorSceneManager.OpenScene(AssetDatabase.GetAssetPath(subscene), OpenSceneMode.Additive);
			}
		}
	}
}