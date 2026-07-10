using UnityEngine;

namespace Voidforge
{
	public abstract class SingletonComponent<T> : VoidElement where T : MonoBehaviour
	{
		protected static T singleton;

		protected static bool isReadonly;

		public static T Singleton
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void OnApplicationQuit()
		{
		}
	}
}
