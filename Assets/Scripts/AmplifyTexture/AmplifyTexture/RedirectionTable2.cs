using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace AmplifyTexture
{
	public class RedirectionTable2
	{
		private enum CacheBlockSize
		{
			_2x2 = 1,
			_4x4 = 2,
			_8x8 = 3
		}

		[StructLayout((LayoutKind)0, Pack = 1, Size = 12)]
		public struct BlockDesc
		{
			public ulong address;

			public uint length;

			public static BlockDesc Empty;
		}

		[StructLayout((LayoutKind)0, Pack = 1, Size = 18)]
		public struct PageDesc
		{
			public uint blockIndex;

			public uint blockOffset;

			public ushort lengthDiff0;

			public ushort lengthNorm0;

			public ushort lengthNorm1;

			public ushort lengthSpec0;

			public ushort lengthSpec1;

			public static PageDesc Empty;
		}

		private const int BlockShift = 2;

		public const int BlockSize = 4;

		public const int BlockLength = 16;

		private VirtualTexture m_asset;

		private Dictionary<uint, BlockDesc> m_blocks;

		private Dictionary<uint, PageDesc> m_pages;

		public RedirectionTable2(VirtualTexture asset)
		{
		}

		public void Clear()
		{
		}

		public static int ComputeMaxBlockCount(VirtualTexture asset)
		{
			return 0;
		}

		public static uint ComputeBlockSizeInBytes(uint blockCount)
		{
			return 0u;
		}

		public static uint ComputePageSizeInBytes(uint pageCount)
		{
			return 0u;
		}

		public static uint ComputeDiskSizeInBytes(uint blockCount, uint pageCount)
		{
			return 0u;
		}

		public uint ComputeDiskSizeInBytes()
		{
			return 0u;
		}

		public int ComputeMemorySizeInBytes()
		{
			return 0;
		}

		public BlockDesc GetBlock(uint blockIndex)
		{
			return default(BlockDesc);
		}

		public PageDesc GetPage(uint pageIndex)
		{
			return default(PageDesc);
		}

		public void SetBlock(uint blockIndex, BlockDesc block)
		{
		}

		public void SetPage(uint pageIndex, PageDesc page)
		{
		}

		public void Import(BinaryReader fileReader)
		{
		}

		public void Export(BinaryWriter fileWriter)
		{
		}
	}
}
