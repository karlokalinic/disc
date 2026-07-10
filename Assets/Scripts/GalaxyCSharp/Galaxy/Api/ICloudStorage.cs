using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class ICloudStorage : IDisposable
	{
		public enum ReadPhase
		{
			CHECKSUM_CALCULATING = 0,
			UPLOADING = 1
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public static readonly uint MIN_HASH_BUFFER_SIZE;

		internal ICloudStorage(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(ICloudStorage obj)
		{
			return default(HandleRef);
		}

		~ICloudStorage()
		{
		}

		public virtual void Dispose()
		{
		}

		public virtual void GetFileList(string container, ICloudStorageGetFileListListener listener)
		{
		}

		public virtual string GetFileNameByIndex(uint index)
		{
			return null;
		}

		public virtual uint GetFileSizeByIndex(uint index)
		{
			return 0u;
		}

		public virtual uint GetFileTimestampByIndex(uint index)
		{
			return 0u;
		}

		public virtual string GetFileHashByIndex(uint index)
		{
			return null;
		}

		public virtual void GetFile(string container, string name, IntPtr userParam, SWIGTYPE_p_f_p_void_p_q_const__char_int__int writeFunc, ICloudStorageGetFileListener listener)
		{
		}

		public virtual void GetFile(string container, string name, byte[] dataBuffer, uint bufferLength, ICloudStorageGetFileListener listener)
		{
		}

		public virtual void GetFileMetadata(string container, string name, ICloudStorageGetFileListener listener)
		{
		}

		public virtual void PutFile(string container, string name, IntPtr userParam, SWIGTYPE_p_f_p_void_p_char_int__int readFunc, SWIGTYPE_p_f_p_void_enum_galaxy__api__ICloudStorage__ReadPhase__int rewindFunc, ICloudStoragePutFileListener listener, SavegameType savegameType, uint timeStamp, string hash)
		{
		}

		public virtual void PutFile(string container, string name, IntPtr userParam, SWIGTYPE_p_f_p_void_p_char_int__int readFunc, SWIGTYPE_p_f_p_void_enum_galaxy__api__ICloudStorage__ReadPhase__int rewindFunc, ICloudStoragePutFileListener listener, SavegameType savegameType, uint timeStamp)
		{
		}

		public virtual void PutFile(string container, string name, IntPtr userParam, SWIGTYPE_p_f_p_void_p_char_int__int readFunc, SWIGTYPE_p_f_p_void_enum_galaxy__api__ICloudStorage__ReadPhase__int rewindFunc, ICloudStoragePutFileListener listener, SavegameType savegameType)
		{
		}

		public virtual void PutFile(string container, string name, IntPtr userParam, SWIGTYPE_p_f_p_void_p_char_int__int readFunc, SWIGTYPE_p_f_p_void_enum_galaxy__api__ICloudStorage__ReadPhase__int rewindFunc, ICloudStoragePutFileListener listener)
		{
		}

		public virtual void PutFile(string container, string name, byte[] buffer, uint bufferLength, ICloudStoragePutFileListener listener, SavegameType savegameType, uint timeStamp, string hash)
		{
		}

		public virtual void PutFile(string container, string name, byte[] buffer, uint bufferLength, ICloudStoragePutFileListener listener, SavegameType savegameType, uint timeStamp)
		{
		}

		public virtual void PutFile(string container, string name, byte[] buffer, uint bufferLength, ICloudStoragePutFileListener listener, SavegameType savegameType)
		{
		}

		public virtual void PutFile(string container, string name, byte[] buffer, uint bufferLength, ICloudStoragePutFileListener listener)
		{
		}

		public virtual void CalculateHash(IntPtr userParam, SWIGTYPE_p_f_p_void_p_char_int__int readFunc, SWIGTYPE_p_f_p_void_enum_galaxy__api__ICloudStorage__ReadPhase__int rewindFunc, ref byte[] hashBuffer, uint hashBufferSize)
		{
		}

		public virtual void CalculateHash(byte[] buffer, uint bufferLength, ref byte[] hashBuffer, uint hashBufferSize)
		{
		}

		public virtual void DeleteFile(string container, string name, ICloudStorageDeleteFileListener listener, string expectedHash)
		{
		}

		public virtual void DeleteFile(string container, string name, ICloudStorageDeleteFileListener listener)
		{
		}

		public virtual void OpenSavegame()
		{
		}

		public virtual void CloseSavegame()
		{
		}
	}
}
