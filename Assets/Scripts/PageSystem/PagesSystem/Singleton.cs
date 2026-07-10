using UnityEngine;

namespace PagesSystem
{
	public class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		private static T _instance;

		public static T Instance => null;

		public static bool CheckIfHaveInstance()
		{
			return false;
		}

		protected virtual void Awake()
		{
		}
	}
}
