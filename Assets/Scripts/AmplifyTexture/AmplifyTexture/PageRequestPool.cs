using System.Collections.Generic;

namespace AmplifyTexture
{
	public class PageRequestPool
	{
		private bool m_compressed;

		private List<PageRequest> m_pageRequestPool;

		public PageRequestPool(int poolSize, bool compressed)
		{
		}

		public void Reset()
		{
		}

		public void Clear()
		{
		}

		public PageRequest Alloc(Page page)
		{
			return null;
		}
	}
}
