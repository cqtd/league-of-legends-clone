using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

namespace CQ.LeagueOfLegends.Editor
{
	[CreateAssetMenu(fileName = "Workspace", menuName = "Editor/Work space", order = int.MaxValue)]
	public class Workspace : ScriptableObject
	{
		/// <summary>
		/// Active Scene
		/// </summary>
		public SceneAsset mainScene;
		
		/// <summary>
		/// Sub scenes
		/// </summary>
		public List<SceneAsset> subscenes = new List<SceneAsset>();

		/// <summary>
		/// 워크 스페이스를 열기
		/// </summary>
		[ContextMenu("Open Workspace")]
		public void Open()
		{
			// save current scene if user wants to
			int sceneCount = SceneManager.sceneCount;
			for (int i = 0; i < sceneCount; i++)
			{
				Scene scene = SceneManager.GetSceneAt(i);
				if (scene.isDirty)
				{
					EditorSceneManager.SaveModifiedScenesIfUserWantsTo(new[] {scene});
				}
			}
			
			// open main scene
			EditorSceneManager.OpenScene(AssetDatabase.GetAssetPath(mainScene));

			// open sub scenes
			foreach (SceneAsset subscene in subscenes)
			{
				EditorSceneManager.OpenScene(AssetDatabase.GetAssetPath(subscene), OpenSceneMode.Additive);
			}
		}

		/// <summary>
		/// 현재 워크스페이스를 에셋형태로 저장
		/// </summary>
		[MenuItem("Tools/Workspace/Save Current workspace")]
		static void Save()
		{
			Workspace workspaceProfile = CreateInstance<Workspace>();
			
			int sceneCount = SceneManager.sceneCount;
			for (int i = 0; i < sceneCount; i++)
			{
				Scene scene = SceneManager.GetSceneAt(i);
				SceneAsset sceneAsset = AssetDatabase.LoadAssetAtPath<SceneAsset>(scene.path);

				if (Equals(scene, SceneManager.GetActiveScene()))
				{
					// main scene
					workspaceProfile.mainScene = sceneAsset;
				}
				else
				{
					// sub scene
					workspaceProfile.subscenes.Add(sceneAsset);
				}
			}

			string directory =
				EditorUtility.SaveFilePanelInProject(
					"Save Workspace",
					$"WS_{workspaceProfile.mainScene.name}",
					"asset",
					"Select directory");
			
			AssetDatabase.CreateAsset(workspaceProfile, directory);
		}

		/// <summary>
		/// Workspace 타입 오브젝트를 실행할 때 호출되는 콜백
		/// </summary>
		/// <param name="instanceID">인스턴스 ID</param>
		/// <param name="line"></param>
		/// <returns></returns>
		/// <exception cref="Exception"></exception>
		[OnOpenAsset(1)]
		static bool OnOpenWorkspaceCallback(int instanceID, int line)
		{
			Object o = EditorUtility.InstanceIDToObject(instanceID);
			if (o is Workspace ws)
			{
				ws.Open();
			}
			else
			{
				throw new Exception("Something is wrong");
			}
			
			return true;
		}
	}
}