using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Ionic.Zip;
using UnityEngine;

public static class SunshinePersistenceFileManager
{
	public static bool SavesAsSlots;

	public static bool EncodeSaveGameNames;

	public const string SAVE_GAME_DIRECTORY = "SaveGames";

	public const string SAVE_SLOT_DIRECTORY = "SaveSlots";

	public const string SAVE_SLOT_CACHE_DIRECTORY = "SaveSlotCache";

	public const string ANALYTICS_GAME_DIRECTORY = "AnalyticsPersistence";

	public const string COLLAGE_SLOT_DIRECTORY = "CollageSlots";

	public const string COLLAGE_SLOT_CACHE_DIRECTORY = "CollageSlotCache";

	private const int READ_WRITE_BUFFER_SIZE = 4096;

	public const string ENCODED_QUICK_SAVE_SLOT_NAME = "qs";

	public const string ORIGINAL_QUICK_SAVE_SLOT_NAME = "QuickSave";

	public const string SAVE_NAME_DATE_SEPARATOR = "x";

	public const char SAVE_NAME_DATE_CHAR_SEPARATOR = 'x';

	public const string SAVE_NAME_SEPARATOR = "-";

	public const char SAVE_NAME_CHAR_SEPARATOR = '-';

	public const string ENCODED_AUTO_SAVE_SLOT_NAME = "as";

	public const string ORIGINAL_AUTO_SAVE_SLOT_NAME = "AutoSave";

	public const string ENCODED_QUICK_SAVE_BACKUP_SLOT_NAME = "qs-backup";

	public const string ORIGINAL_QUICK_SAVE_BACKUP_SLOT_NAME = "Quick Save (Backup)";

	public const string DATE_FORMAT_LONG = "dd-MM-yyyy HH-mm";

	public const string LUA_SAVE_GAME_FILE_SUFFIX = ".ntwtf.lua";

	public const string LUA_STATES_FILE_SUFFIX = ".states.lua";

	public const string JSON_PRELOAD_SAVE_GAME_FILE_SUFFIX = ".1st.ntwtf.json";

	public const string JSON_SAVE_GAME_FILE_SUFFIX = ".2nd.ntwtf.json";

	public const string FOW_SAVE_GAME_FILE_SUFFIX = ".FOW.json";

	public const string THUMBNAIL_SUFFIX = ".jpg";

	public const string OLD_THUMBNAIL_SUFFIX = ".png";

	public const string JSON_SUFFIX = ".json";

	public const string SAVE_SLOT_CACHE_FILENAME = "cache.json";

	public static string SLOT_ZIP_FILE_SUFFIX;

	public static string ORIGINAL_ZIP_FILE_SUFFIX;

	public static string ENCODED_ZIP_FILE_SUFFIX;

	private static List<string> TEXT_FILE_EXTENSIONS;

	public const int ZIP_FILE_BUFFER_CAPACITY = 2097152;

	public const int THUMBNAIL_BUFFER_CAPACITY = 65536;

	public const int SLOT_META_BUFFER_CAPACITY = 2048;

	public const int SLOT_CACHE_BUFFER_CAPACITY = 65536;

	public static string[] SaveGameFilesArray;

	public const int MaxSaveGames = -1;

	private static bool CacheSaveGamesComplete;

	private static char[] allowedSlashes;

	private static MemoryStream stream;

	public static string QUICK_SAVE_SLOT_NAME => null;

	public static string AUTO_SAVE_SLOT_NAME => null;

	public static string QUICK_SAVE_BACKUP_SLOT_NAME => null;

	public static string ZIP_FILE_SUFFIX => null;

	public static List<KeyValuePair<string, string>> ListOfSaves { get; private set; }

	public static void AllocCacheSaveGames()
	{
	}

	public static IEnumerator CacheSaveGamesInit()
	{
		return null;
	}

	public static IEnumerator CacheSaveGamesInit2()
	{
		return null;
	}

	public static bool HasSaveGames()
	{
		return false;
	}

	public static bool HasSaveFilename(string filename)
	{
		return false;
	}

	public static IEnumerator FileExists(string fullpath, Action<bool> methodCall)
	{
		return null;
	}

	public static void CleanTempAndInvalidFiles()
	{
	}

	public static bool DoesSaveGameDirExist()
	{
		return false;
	}

	public static void CreateSaveGameDirIfNotExists()
	{
	}

	public static string GetSaveGameDirectoryPath()
	{
		return null;
	}

	public static string GetAnalyticsDirectoryPath()
	{
		return null;
	}

	public static string GetLastSaveWithNamePart(string namePart)
	{
		return null;
	}

	public static string GetLastSave()
	{
		return null;
	}

	public static void GetSaveGameFiles()
	{
	}

	public static void PopulateListOfSaves()
	{
	}

	public static bool CheckIfSaveIsLast()
	{
		return false;
	}

	public static bool SplitDateFromSaveFilename(string filename, out string saveName, out string saveDateTime)
	{
		saveName = null;
		saveDateTime = null;
		return false;
	}

	public static bool IsThisAAutoSave(string filename)
	{
		return false;
	}

	public static bool IsThisAQuickSave(string filename)
	{
		return false;
	}

	public static bool IsThisAQuickSaveBackup(string filename)
	{
		return false;
	}

	public static string GetNameWithoutDate(string saveName)
	{
		return null;
	}

	public static string DecodeSaveGameName(string filename, bool decodeDatePart = true)
	{
		return null;
	}

	public static string EncodeSaveGameName(string decodedName, bool encodeDataPart = true)
	{
		return null;
	}

	public static bool IsSaveEncoded(string filename)
	{
		return false;
	}

	public static string ReplaceInvalidFileNameChars(string name)
	{
		return null;
	}

	public static string PutDateSuffixOnPath(string path, out DateTime date)
	{
		date = default(DateTime);
		return null;
	}

	public static bool TryGetDateSuffixFromPath(string path, out string dateSuffix)
	{
		dateSuffix = null;
		return false;
	}

	public static bool TryGetDateFromPath(string path, out DateTime dateTime)
	{
		dateTime = default(DateTime);
		return false;
	}

	public static string GetFilenamePrefix(string path)
	{
		return null;
	}

	private static string GetSaveGamePathOnSave(string fileNamePrefix, string prefix)
	{
		return null;
	}

	private static string GetSaveGamePathOnLoad(string fileNamePrefix, string suffix, bool withPath)
	{
		return null;
	}

	public static string GetZipSaveGamePath(string fileNamePrefix)
	{
		return null;
	}

	public static string GetJpegSaveGamePath(string fileNamePrefix)
	{
		return null;
	}

	public static string GetJsonSaveGamePath(string path)
	{
		return null;
	}

	public static void CreateSaveGame(string fileNamePrefix, byte[] zipBytes, int zipBytesLength, byte[] thumbnailBytes, FileOpCommandBuffer fileCmd)
	{
	}

	public static void DeleteSaveGame(string fileNamePrefix, FileOpCommandBuffer fileCmd)
	{
	}

	public static void DeleteExcessAutosavesOps(int nrOfFilesToKeep, FileOpCommandBuffer fileCmd)
	{
	}

	public static IEnumerator DeleteExcessAutosavesSlots(int nrOfFilesToKeep)
	{
		return null;
	}

	public static bool ListDirectories(string mountPath, out string[] list, bool removePaths = true)
	{
		list = null;
		return false;
	}

	public static IEnumerator HandleQuickSavesSlots()
	{
		return null;
	}

	public static void HandleQuickSavesOps(FileOpCommandBuffer fileCmd)
	{
	}

	public static IEnumerator DeleteMultipleSaveGameFiles(string[] fileNamesPrefix)
	{
		return null;
	}

	public static IEnumerator DeleteMultipleFiles(string[] filepaths)
	{
		return null;
	}

	public static Dictionary<string, Color[]> GetFOWData(string fileNamePrefix)
	{
		return null;
	}

	public static T ReadJsonFile<T>(string fileNamePrefix, string suffix)
	{
		return default(T);
	}

	public static void ZipItFromMemory(ZipFile zip, MemoryStream dialogueSystemLuaData, MemoryStream luaStatesData, MemoryStream jsonPreloadSaveGameData, MemoryStream jsonSaveGameData, MemoryStream jsonFOWSaveGameData, string dialogueSystemLuaName, string luaStatesName, string jsonPreloadSaveGameName, string jsonSaveGameName, string jsonFOWSaveGameName)
	{
	}

	public static void GetZipBytes(ZipFile zip, out byte[] zipBytes, out int zipByteLength)
	{
		zipBytes = null;
		zipByteLength = default(int);
	}

	public static void UnzipBytesToMemory(SunshinePersistence.SaveGameLoadedData saveGameLoadedData, string fileNamePrefix, bool isBundled, FileOpReadData zipData)
	{
	}
}
