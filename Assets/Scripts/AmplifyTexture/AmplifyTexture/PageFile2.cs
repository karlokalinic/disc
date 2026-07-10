using System;
using System.IO;

namespace AmplifyTexture
{
	[Serializable]
	public sealed class PageFile2
	{
		private const int BufferSize = 131072;

		private const int HeapAllocStepCount = 10;

		private VirtualTexture m_asset;

		private long m_headerLength;

		private Stream m_stream;

		private BinaryReader m_reader;

		private RedirectionTable2 m_redirectTable;

		public string FileName => null;

		public long HeaderLength => 0L;

		internal Stream Stream => null;

		internal RedirectionTable2 RedirectTable => null;

		public PageFile2(VirtualTexture asset)
		{
		}

		public static string GetFileNameWithExtension(VirtualTexture asset)
		{
			return null;
		}

		public static string GetFullPath(VirtualTexture asset)
		{
			return null;
		}

		public static bool IsCreated(VirtualTexture asset)
		{
			return false;
		}

		public bool IsOpen()
		{
			return false;
		}

		public void ImportRedirectTable()
		{
		}

		public bool OpenRead()
		{
			return false;
		}

		public void Close()
		{
		}

		public bool ReadPage(PageDecoder decoder, int index, PageRequest pageReq)
		{
			return false;
		}
	}
}
