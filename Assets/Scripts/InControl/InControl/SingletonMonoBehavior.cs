using UnityEngine;

namespace InControl
{
	public abstract class SingletonMonoBehavior<TComponent> : MonoBehaviour where TComponent : MonoBehaviour
	{
		private static TComponent instance;

		private static bool hasInstance;

		private static int instanceId;

		private static readonly object lockObject;

		public static TComponent Instance => null;

		protected bool EnforceSingleton => false;

		protected bool IsTheSingleton => false;

		protected bool IsNotTheSingleton => false;

		private static TComponent[] FindInstances()
		{
			return null;
		}

		private static TComponent FindFirstInstance()
		{
			return null;
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}
	}
}
