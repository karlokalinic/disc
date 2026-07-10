namespace AmplifyTexture
{
	public sealed class LockFreeQueueRef<T> where T : class
	{
		public NodeRef<T> m_head;

		public NodeRef<T> m_tail;

		public void Enqueue(T x)
		{
		}

		public bool TryDequeue(out T value)
		{
			value = null;
			return false;
		}
	}
}
