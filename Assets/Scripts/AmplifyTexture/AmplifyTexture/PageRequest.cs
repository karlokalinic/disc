namespace AmplifyTexture
{
	public class PageRequest
	{
		public Page page;

		public byte[] diff;

		public byte[] norm;

		public byte[] spec;

		public byte[] diff0;

		public byte[] norm0;

		public byte[] norm1;

		public byte[] spec0;

		public byte[] spec1;

		public bool free;

		public PageRequest(bool compressed)
		{
		}

		public void Reserve(Page page)
		{
		}

		public void Release()
		{
		}
	}
}
