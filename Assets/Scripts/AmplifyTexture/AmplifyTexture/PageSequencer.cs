namespace AmplifyTexture
{
	public sealed class PageSequencer
	{
		private int m_physicalTableSize;

		private int[] m_offsets;

		private int m_totalPageCount;

		public int[] Offsets => null;

		public int TotalPageCount => 0;

		public PageSequencer(VirtualTexture asset)
		{
		}

		public void Reset(VirtualTexture asset)
		{
		}

		public void Destroy()
		{
		}

		public static int ComputePageCount(VirtualTexture asset)
		{
			return 0;
		}

		public int GetOffset(int mip)
		{
			return 0;
		}

		public int ComputeIndex(int x, int y, int mip)
		{
			return 0;
		}
	}
}
