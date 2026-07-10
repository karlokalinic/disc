using System.Collections.Generic;

namespace UnityEngine.ResourceManagement.Util
{
	internal static class GlobalLinkedListNodeCache<T>
	{
		private static LinkedListNodeCache<T> m_globalCache;

		public static LinkedListNode<T> Acquire(T val)
		{
			return null;
		}

		public static void Release(LinkedListNode<T> node)
		{
		}
	}
}
