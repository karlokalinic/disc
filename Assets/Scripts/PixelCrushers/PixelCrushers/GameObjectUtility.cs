using UnityEngine;

namespace PixelCrushers
{
	public static class GameObjectUtility
	{
		public static bool IsPrefab(GameObject go)
		{
			return false;
		}

		public static GameObject GameObjectHardFind(string goName)
		{
			return null;
		}

		public static GameObject GameObjectHardFind(string goName, string tag)
		{
			return null;
		}

		private static GameObject GameObjectSearchHierarchy(Transform t, string goName, string tag)
		{
			return null;
		}

		public static T GetComponentAnywhere<T>(GameObject gameObject) where T : Component
		{
			return null;
		}

		public static float GetGameObjectHeight(GameObject gameObject)
		{
			return 0f;
		}
	}
}
