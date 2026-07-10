using System.Collections.Generic;

namespace UnityEngine.ResourceManagement.Util
{
	public class LinkedListNodeCache<T>
	{
		private int m_NodesCreated;

		private LinkedList<T> m_NodeCache;

		internal int CreatedNodeCount => 0;

		internal int CachedNodeCount => 0;

		public LinkedListNode<T> Acquire(T val)
		{
			return null;
		}

		public void Release(LinkedListNode<T> node)
		{
		}
	}
}
