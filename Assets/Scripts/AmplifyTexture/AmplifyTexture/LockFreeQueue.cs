namespace AmplifyTexture
{
	public sealed class LockFreeQueue<T> where T : struct
	{
		public Node<T> m_head;

		public Node<T> m_tail;

		public void Enqueue(T x)
		{
		}

		public bool TryDequeue(out T value)
		{
			value = default(T);
			return false;
		}
	}
}
