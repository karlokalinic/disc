using UnityEngine;

namespace Voidforge
{
	public abstract class SingletonClass<T> : Object where T : new()
	{
		protected static T singleton;

		public static T Singleton => default(T);
	}
}
