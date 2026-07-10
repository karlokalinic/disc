using System;

namespace Epic.OnlineServices.PlayerDataStorage
{
	public sealed class PlayerDataStorageInterface : Handle
	{
		public const int CopyfilemetadataatindexoptionsApiLatest = 1;

		public const int CopyfilemetadatabyfilenameoptionsApiLatest = 1;

		public const int DeletecacheoptionsApiLatest = 1;

		public const int DeletefileoptionsApiLatest = 1;

		public const int DuplicatefileoptionsApiLatest = 1;

		public const int FileMaxSizeBytes = 67108864;

		public const int FilemetadataApiLatest = 3;

		public const int FilenameMaxLengthBytes = 64;

		public const int GetfilemetadatacountoptionsApiLatest = 1;

		public const int QueryfilelistoptionsApiLatest = 1;

		public const int QueryfileoptionsApiLatest = 1;

		public const int ReadfileoptionsApiLatest = 1;

		public const int WritefileoptionsApiLatest = 1;

		public PlayerDataStorageInterface()
		{
		}

		public PlayerDataStorageInterface(IntPtr innerHandle)
		{
		}

		public Result CopyFileMetadataAtIndex(CopyFileMetadataAtIndexOptions copyFileMetadataOptions, out FileMetadata outMetadata)
		{
			outMetadata = null;
			return default(Result);
		}

		public Result CopyFileMetadataByFilename(CopyFileMetadataByFilenameOptions copyFileMetadataOptions, out FileMetadata outMetadata)
		{
			outMetadata = null;
			return default(Result);
		}

		public Result DeleteCache(DeleteCacheOptions options, object clientData, OnDeleteCacheCompleteCallback completionCallback)
		{
			return default(Result);
		}

		public void DeleteFile(DeleteFileOptions deleteOptions, object clientData, OnDeleteFileCompleteCallback completionCallback)
		{
		}

		public void DuplicateFile(DuplicateFileOptions duplicateOptions, object clientData, OnDuplicateFileCompleteCallback completionCallback)
		{
		}

		public Result GetFileMetadataCount(GetFileMetadataCountOptions getFileMetadataCountOptions, out int outFileMetadataCount)
		{
			outFileMetadataCount = default(int);
			return default(Result);
		}

		public void QueryFile(QueryFileOptions queryFileOptions, object clientData, OnQueryFileCompleteCallback completionCallback)
		{
		}

		public void QueryFileList(QueryFileListOptions queryFileListOptions, object clientData, OnQueryFileListCompleteCallback completionCallback)
		{
		}

		public PlayerDataStorageFileTransferRequest ReadFile(ReadFileOptions readOptions, object clientData, OnReadFileCompleteCallback completionCallback)
		{
			return null;
		}

		public PlayerDataStorageFileTransferRequest WriteFile(WriteFileOptions writeOptions, object clientData, OnWriteFileCompleteCallback completionCallback)
		{
			return null;
		}

		internal static void OnDeleteCacheCompleteCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnDeleteFileCompleteCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnDuplicateFileCompleteCallbackInternalImplementation(IntPtr data)
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

		internal static void OnWriteFileCompleteCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static WriteResult OnWriteFileDataCallbackInternalImplementation(IntPtr data, IntPtr outDataBuffer, ref uint outDataWritten)
		{
			return default(WriteResult);
		}
	}
}
