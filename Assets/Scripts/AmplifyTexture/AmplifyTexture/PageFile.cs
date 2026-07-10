using System;
using System.IO;
using UnityEngine;

namespace AmplifyTexture
{
	[Serializable]
	public sealed class PageFile
	{
		public static string DefaultCacheFolder;

		private const int BufferSize = 131072;

		private const int HeapAllocStepCount = 10;

		private const int SignatureSize = 16;

		private static readonly byte[] m_invalidSignature;

		[SerializeField]
		private string m_fileName;

		[SerializeField]
		private VirtualTexture m_asset;

		[SerializeField]
		private int m_totalPageCount;

		[SerializeField]
		private int m_headerLength;

		private FileAccess m_fileAccess;

		private byte[] m_emptyData;

		private Stream m_stream;

		private BinaryWriter m_writer;

		private BinaryReader m_reader;

		private FileStream m_heapStream;

		private StorageHeap m_heap;

		private RedirectionTable m_redirectTable;

		public string FileName => null;

		public FileAccess FileAccess => default(FileAccess);

		public int TotalPageCount => 0;

		public int HeaderLength => 0;

		internal Stream Stream => null;

		public StorageHeap Heap => null;

		public RedirectionTable RedirectTable => null;

		public PageFile(VirtualTexture asset)
		{
		}

		public string GetFileNameWithExtension()
		{
			return null;
		}

		public string GetFullPath()
		{
			return null;
		}

		public bool IsOpen()
		{
			return false;
		}

		public bool IsCreated()
		{
			return false;
		}

		public long ComputeRawLength(VirtualTexture asset)
		{
			return 0L;
		}

		public long Length()
		{
			return 0L;
		}

		public void InvalidateSignature()
		{
		}

		public byte[] ReadSignature()
		{
			return null;
		}

		public string ReadSignatureString()
		{
			return null;
		}

		public void WriteSignature(byte[] signature)
		{
		}

		public void Destroy()
		{
		}

		public void ImportRedirectTable()
		{
		}

		public void ExportRedirectTable()
		{
		}

		public void Open(VirtualTexture asset, FileAccess fileAccess)
		{
		}

		public void Close(bool save)
		{
		}

		public void ErasePage(int index)
		{
		}

		public long GetPageAddress(int index)
		{
			return 0L;
		}

		public uint ReadPage(PageDecoder decoder, int index, ref bool linear, ref byte[] data)
		{
			return 0u;
		}

		public uint RawReadPage(int index, byte[] data, ref bool linear)
		{
			return 0u;
		}
	}
}
