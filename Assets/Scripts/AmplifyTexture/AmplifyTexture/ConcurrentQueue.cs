using System.Collections.Generic;

namespace AmplifyTexture
{
	public class ConcurrentQueue<T> : Queue<T>
	{
		public object m_lock;

		public ConcurrentQueue(int capacity)
		{
		}

		public new void Enqueue(T x)
		{
		}

		public bool TryDequeue(out T value)
		{
			value = default(T);
			return false;
		}
	}
}
