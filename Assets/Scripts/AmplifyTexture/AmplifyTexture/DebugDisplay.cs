using System;

namespace AmplifyTexture
{
	[Serializable]
	public struct DebugDisplay
	{
		public bool cache;

		public int cacheSize;

		public bool table;

		public int tableSize;

		public bool prePass;

		public int prePassSize;

		public DebugDisplay(bool cache, int cacheSize, bool table, int tableSize, bool prePass, int prePassSize)
		{
			this.cache = false;
			this.cacheSize = 0;
			this.table = false;
			this.tableSize = 0;
			this.prePass = false;
			this.prePassSize = 0;
		}
	}
}
