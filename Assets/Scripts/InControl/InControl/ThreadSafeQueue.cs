using System.Collections.Generic;

namespace InControl
{
	internal class ThreadSafeQueue<T>
	{
		private object sync;

		private Queue<T> data;

		public ThreadSafeQueue()
		{
		}

		public ThreadSafeQueue(int capacity)
		{
		}

		public void Enqueue(T item)
		{
		}

		public bool Dequeue(out T item)
		{
			item = default(T);
			return false;
		}

		public T Dequeue()
		{
			return default(T);
		}

		public int Dequeue(ref IList<T> list)
		{
			return 0;
		}
	}
}
