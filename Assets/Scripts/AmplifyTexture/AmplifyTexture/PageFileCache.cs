using System.Collections.Generic;

namespace AmplifyTexture
{
	public class PageFileCache
	{
		public class BlockCache
		{
			public uint lengthInBytes;

			public List<byte[]> track;

			public Queue<byte[]> free;

			public MruDictionary<uint, byte[]> mru;

			public int Capacity => 0;

			public int AllocatedCount => 0;

			public BlockCache(uint lengthInKB, int capacity)
			{
			}

			public void Reset()
			{
			}

			public byte[] Alloc()
			{
				return null;
			}

			public void Free(byte[] data)
			{
			}
		}

		public struct BlockPoolInfo
		{
			public int Length;

			public int Capacity;

			public int AllocatedCount;
		}

		private enum CacheBudget
		{
			_None = 0,
			_8MB = 1,
			_16MB = 2,
			_32MB = 3,
			_64MB = 4,
			_128MB = 5
		}

		private static readonly object Mutex;

		private static List<BlockCache> BlockCaches;

		private const int MinPow2Log2 = 14;

		private const int MaxPow2Log2 = 20;

		private const int CacheCount = 7;

		private static readonly uint[] pow2log2lut;

		private static CacheBudget CurrentCacheBudget;

		private static int CurrentScreenWidth;

		private static int CurrentScreenHeight;

		private static readonly uint[] SizesInKB;

		private static readonly int[] CountPerSize_8MB;

		private static readonly int[] CountPerSize_16MB;

		private static readonly int[] CountPerSize_32MB;

		private static readonly int[] CountPerSize_64MB;

		private static readonly int[] CountPerSize_128MB;

		private static uint NextPow2(uint value)
		{
			return 0u;
		}

		private static uint Pow2Log2(uint value)
		{
			return 0u;
		}

		public static List<BlockPoolInfo> GetBlockPoolInfo()
		{
			return null;
		}

		private static CacheBudget CalculateBlockCacheBudget(out int[] countPerSize)
		{
			countPerSize = null;
			return default(CacheBudget);
		}

		public static void Reset()
		{
		}

		public static bool FetchBlockData(VirtualTexture asset, uint blockIndex, uint blockLength, out byte[] blockData)
		{
			blockData = null;
			return false;
		}
	}
}
