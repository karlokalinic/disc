using System.Collections.Generic;
using System.IO;

namespace AmplifyTexture
{
	public sealed class StorageHeap
	{
		private struct BlockHeader
		{
			public long size;

			public long allocated;

			public long address;

			public int next;

			public int bucketNext;
		}

		private long m_heapSize;

		private int m_root;

		private int m_count;

		private int m_capacity;

		private int m_granularity;

		private BlockHeader[] m_pool;

		private const int BucketSize = 16;

		private int m_bucketCount;

		private int m_bucketMax;

		private int[] m_allocBuckets;

		private Stack<int> m_recycled;

		private LinkedList<int> m_free;

		private int NewBlockHeader()
		{
			return 0;
		}

		public StorageHeap(long size, int capacity, int granularity)
		{
		}

		public void Destroy()
		{
		}

		private void CheckBlockCount(string label)
		{
		}

		public void AddToBuckets(int block, ref int[] buckets)
		{
		}

		public int RemoveFromBuckets(int block, ref int[] buckets)
		{
			return 0;
		}

		public int RemoveFromBuckets(long address, ref int[] buckets)
		{
			return 0;
		}

		public long Alloc(long size)
		{
			return 0L;
		}

		public void Free(long address)
		{
		}

		public void Coalesce()
		{
		}

		public void Export(FileStream stream)
		{
		}

		public void Import(FileStream stream)
		{
		}

		public long GetSize()
		{
			return 0L;
		}

		public int GetBlockCount()
		{
			return 0;
		}

		public int ComputeAllocatedCount()
		{
			return 0;
		}

		public long ComputeAllocatedSize()
		{
			return 0L;
		}
	}
}
