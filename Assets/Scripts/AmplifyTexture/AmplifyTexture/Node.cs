namespace AmplifyTexture
{
	public sealed class Node<T> where T : struct
	{
		public T m_value;

		public Node<T> m_next;

		public Node(T value)
		{
		}
	}
}
