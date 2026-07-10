using System.Collections.Generic;

namespace PixelCrushers
{
	public class Pool<T> where T : new()
	{
		private List<T> m_free;

		private List<T> m_used;

		public T Get()
		{
			return default(T);
		}

		public void Release(T item)
		{
		}

		public void Allocate(int initialSize)
		{
		}

		public void Trim(int max)
		{
		}
	}
}
