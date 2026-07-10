using System.Collections.Generic;

namespace AmplifyTexture
{
	public sealed class PageTablePacker
	{
		private DynamicBinPacker m_rectPacker;

		private Dictionary<VirtualTexture, Point> m_locations;

		public DynamicBinPacker RectPacker => null;

		public Dictionary<VirtualTexture, Point> Locations => null;

		public int Width => 0;

		public int Height => 0;

		public bool Pack(List<VirtualTexture> assets, int maxWidth, int maxHeight)
		{
			return false;
		}
	}
}
