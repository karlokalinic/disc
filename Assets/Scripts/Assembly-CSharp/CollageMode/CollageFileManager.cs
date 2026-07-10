using System;
using System.Collections;
using System.Collections.Generic;

namespace CollageMode
{
	public static class CollageFileManager
	{
		public const string SAVE_COLLAGE_DIRECTORY = "SaveCollages";

		public const string SAVE_SUFFIX = ".collage.json";

		public const string SCREENSHOT_SUFFIX = ".jpg";

		private const int SCREENSHOT_QUALITY = 20;

		public const int ZIP_FILE_BUFFER_CAPACITY = 2097152;

		public const int THUMBNAIL_BUFFER_CAPACITY = 524288;

		public static List<CollageSaveData> CachedSaves;

		public static string[] SaveGameFilesArray;

		public static List<KeyValuePair<string, string>> ListOfSaves { get; private set; }

		public static void GetSaves(Action<List<CollageSaveData>> onComplete)
		{
		}

		private static IEnumerator GetSaves()
		{
			return null;
		}

		public static string GetSaveCollageDirectoryPath()
		{
			return null;
		}

		public static IEnumerator LoadFile(string uniqueName, Action<CollageSaveData> callback)
		{
			return null;
		}

		public static void SaveToFile(CollageSaveData save)
		{
		}

		public static string GenerateSaveFileName(CollageSaveData save)
		{
			return null;
		}

		public static IEnumerator RemoveFile(CollageSaveData save, Action<List<CollageSaveData>> callback)
		{
			return null;
		}

		private static void Execute(FileOpCommandBuffer commandBuffer)
		{
		}

		public static void CreateSaveGameDirIfNotExists()
		{
		}

		public static void CleanTempAndInvalidFiles()
		{
		}

		public static bool DoesSaveGameDirExist()
		{
			return false;
		}

		public static void GetSaveGameFiles()
		{
		}

		public static IEnumerator CacheSaveCollagesInit()
		{
			return null;
		}

		public static IEnumerator CacheSaveCollagesInit2()
		{
			return null;
		}

		public static void PopulateListOfSaves()
		{
		}
	}
}
