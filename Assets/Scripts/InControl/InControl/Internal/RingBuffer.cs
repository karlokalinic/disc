namespace InControl.Internal
{
	public class RingBuffer<T>
	{
		private readonly int size;

		private readonly T[] data;

		private int head;

		private int tail;

		private readonly object sync;

		public RingBuffer(int size)
		{
		}

		public void Enqueue(T value)
		{
		}

		public T Dequeue()
		{
			return default(T);
		}
	}
}
