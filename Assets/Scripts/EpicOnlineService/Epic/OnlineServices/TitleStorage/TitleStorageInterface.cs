using System;

namespace Epic.OnlineServices.TitleStorage
{
	public sealed class TitleStorageInterface : Handle
	{
		public const int CopyfilemetadataatindexoptionsApiLatest = 1;

		public const int CopyfilemetadatabyfilenameoptionsApiLatest = 1;

		public const int DeletecacheoptionsApiLatest = 1;

		public const int FilemetadataApiLatest = 2;

		public const int FilenameMaxLengthBytes = 64;

		public const int GetfilemetadatacountoptionsApiLatest = 1;

		public const int QueryfilelistoptionsApiLatest = 1;

		public const int QueryfileoptionsApiLatest = 1;

		public const int ReadfileoptionsApiLatest = 1;

		public TitleStorageInterface()
		{
		}

		public TitleStorageInterface(IntPtr innerHandle)
		{
		}

		public Result CopyFileMetadataAtIndex(CopyFileMetadataAtIndexOptions options, out FileMetadata outMetadata)
		{
			outMetadata = null;
			return default(Result);
		}

		public Result CopyFileMetadataByFilename(CopyFileMetadataByFilenameOptions options, out FileMetadata outMetadata)
		{
			outMetadata = null;
			return default(Result);
		}

		public Result DeleteCache(DeleteCacheOptions options, object clientData, OnDeleteCacheCompleteCallback completionCallback)
		{
			return default(Result);
		}

		public uint GetFileMetadataCount(GetFileMetadataCountOptions options)
		{
			return 0u;
		}

		public void QueryFile(QueryFileOptions options, object clientData, OnQueryFileCompleteCallback completionCallback)
		{
		}

		public void QueryFileList(QueryFileListOptions options, object clientData, OnQueryFileListCompleteCallback completionCallback)
		{
		}

		public TitleStorageFileTransferRequest ReadFile(ReadFileOptions options, object clientData, OnReadFileCompleteCallback completionCallback)
		{
			return null;
		}

		internal static void OnDeleteCacheCompleteCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnFileTransferProgressCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnQueryFileCompleteCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnQueryFileListCompleteCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnReadFileCompleteCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static ReadResult OnReadFileDataCallbackInternalImplementation(IntPtr data)
		{
			return default(ReadResult);
		}
	}
}
