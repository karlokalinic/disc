using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class IStorage : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal IStorage(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(IStorage obj)
		{
			return default(HandleRef);
		}

		~IStorage()
		{
		}

		public virtual void Dispose()
		{
		}

		public virtual void FileWrite(string fileName, byte[] data, uint dataSize)
		{
		}

		public virtual uint FileRead(string fileName, byte[] data, uint dataSize)
		{
			return 0u;
		}

		public virtual void FileDelete(string fileName)
		{
		}

		public virtual bool FileExists(string fileName)
		{
			return false;
		}

		public virtual uint GetFileSize(string fileName)
		{
			return 0u;
		}

		public virtual uint GetFileTimestamp(string fileName)
		{
			return 0u;
		}

		public virtual uint GetFileCount()
		{
			return 0u;
		}

		public virtual string GetFileNameByIndex(uint index)
		{
			return null;
		}

		public virtual void GetFileNameCopyByIndex(uint index, out string buffer, uint bufferLength)
		{
			buffer = null;
		}

		public virtual void FileShare(string fileName, IFileShareListener listener)
		{
		}

		public virtual void FileShare(string fileName)
		{
		}

		public virtual void DownloadSharedFile(ulong sharedFileID, ISharedFileDownloadListener listener)
		{
		}

		public virtual void DownloadSharedFile(ulong sharedFileID)
		{
		}

		public virtual string GetSharedFileName(ulong sharedFileID)
		{
			return null;
		}

		public virtual void GetSharedFileNameCopy(ulong sharedFileID, out string buffer, uint bufferLength)
		{
			buffer = null;
		}

		public virtual uint GetSharedFileSize(ulong sharedFileID)
		{
			return 0u;
		}

		public virtual GalaxyID GetSharedFileOwner(ulong sharedFileID)
		{
			return null;
		}

		public virtual uint SharedFileRead(ulong sharedFileID, byte[] data, uint dataSize, uint offset)
		{
			return 0u;
		}

		public virtual uint SharedFileRead(ulong sharedFileID, byte[] data, uint dataSize)
		{
			return 0u;
		}

		public virtual void SharedFileClose(ulong sharedFileID)
		{
		}

		public virtual uint GetDownloadedSharedFileCount()
		{
			return 0u;
		}

		public virtual ulong GetDownloadedSharedFileByIndex(uint index)
		{
			return 0uL;
		}
	}
}
