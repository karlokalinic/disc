using UnityEngine;

namespace Voidforge
{
	public abstract class SingletonScriptable<T> : SingletonScriptableBase where T : ScriptableObject
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

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}
	}
}
