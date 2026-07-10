using System;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace AssetRipperPatches.Editor
{
	public static class MissingScriptRepairCommand
	{
		public static void ReportMissingScriptsInBuildScenes()
		{
			ProcessBuildScenes(remove: false);
		}

		public static void RemoveMissingScriptsInBuildScenes()
		{
			ProcessBuildScenes(remove: true);
		}

		private static void ProcessBuildScenes(bool remove)
		{
			string[] scenePaths = EditorBuildSettings.scenes
				.Where(scene => scene.enabled)
				.Select(scene => scene.path)
				.ToArray();

			int totalMissing = 0;
			foreach (string scenePath in scenePaths)
			{
				int sceneMissing = 0;
				var scene = EditorSceneManager.OpenScene(scenePath, OpenSceneMode.Single);
				foreach (GameObject root in scene.GetRootGameObjects())
				{
					foreach (Transform transform in root.GetComponentsInChildren<Transform>(true))
					{
						GameObject gameObject = transform.gameObject;
						int missing = GameObjectUtility.GetMonoBehavioursWithMissingScriptCount(gameObject);
						if (missing == 0)
						{
							continue;
						}

						sceneMissing += missing;
						Debug.LogWarning($"{(remove ? "Removing" : "Found")} {missing} missing script component(s): {scenePath} :: {GetPath(transform)}");
						if (remove)
						{
							GameObjectUtility.RemoveMonoBehavioursWithMissingScript(gameObject);
						}
					}
				}

				totalMissing += sceneMissing;
				if (remove && sceneMissing > 0)
				{
					EditorSceneManager.SaveScene(scene);
				}
			}

			Debug.Log($"{(remove ? "Removed" : "Found")} {totalMissing} missing script component(s) across {scenePaths.Length} enabled build scene(s).");
		}

		private static string GetPath(Transform transform)
		{
			if (transform == null)
			{
				return "<null>";
			}

			string path = transform.name;
			while (transform.parent != null)
			{
				transform = transform.parent;
				path = transform.name + "/" + path;
			}

			return path;
		}
	}
}
