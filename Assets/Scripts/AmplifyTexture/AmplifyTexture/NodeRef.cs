namespace AmplifyTexture
{
	public sealed class NodeRef<T> where T : class
	{
		public T m_value;

		public NodeRef<T> m_next;

		public NodeRef(T value)
		{
		}
	}
}
