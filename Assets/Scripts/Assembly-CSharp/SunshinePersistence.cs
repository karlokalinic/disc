using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using Voidforge;

public class SunshinePersistence : SingletonComponent<SunshinePersistence>
{
	public class SaveGameLoadedData
	{
		public Dictionary<string, byte[]> data;

		public void Init()
		{
		}

		public bool HasDataWithSuffix(string suffix)
		{
			return false;
		}

		public string GetFilenameBasedOnSuffix(string suffix)
		{
			return null;
		}

		public byte[] GetData(string filename)
		{
			return null;
		}

		public string GetString(string filename)
		{
			return null;
		}

		public void Release()
		{
		}
	}

	public enum SAVE_MODE
	{
		NORMAL = 0,
		QUICKSAVE = 1,
		AUTOSAVE = 2
	}

	public enum SAVE_CONTENT_TYPE
	{
		STRING = 0,
		BYTES = 1
	}

	public enum OPERATION_TYPE
	{
		NONE = 0,
		LOADING = 1,
		SAVING = 2
	}

	public SaveGameLoadedData saveGameLoadedData;

	private SAVE_CONTENT_TYPE saveContentType;

	public bool IsLoading;

	public static bool LoadingInitialized;

	private const string TIME_NUMBER_FORMAT = "00";

	private const string SAVE_WITH_ERRORS = "The game data in your save \"{0}\" contained errors. The game state can not be verified. Continue at your own risk. Nr of errors found: {1}.";

	public static Coroutine saveCoroutine;

	public static OPERATION_TYPE CurrentActiveOp;

	private GameObject CameraSpaceCanvas;

	private static MemoryStream dialogueSystemLuaData;

	private static MemoryStream luaStatesDataBytes;

	private static MemoryStream jsonPreloadSaveGameBytes;

	private static MemoryStream jsonSaveGameBytes;

	private static MemoryStream jsonFOWSaveGameBytes;

	private static StringBuilder luaStatesData;

	private static StringBuilder jsonPreloadSaveGame;

	private static StringBuilder jsonSaveGame;

	private static StringBuilder jsonFOWSaveGame;

	private static char[] utf8CustomTempArray;

	public static event Action OnReleased
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnLoadLevel
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnSaveNormal
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public static bool IsInLobby()
	{
		return false;
	}

	public static bool IsInMenu()
	{
		return false;
	}

	public static bool CanSaveFromMainMenu()
	{
		return false;
	}

	private static bool CanSave()
	{
		return false;
	}

	public static bool CanLoad()
	{
		return false;
	}

	private static bool CanQuickLoad()
	{
		return false;
	}

	public void Reset()
	{
	}

	private IEnumerator RecordFrame()
	{
		return null;
	}

	public void TakeSaveGameScreenshot()
	{
	}

	private void SetPersistentManagerSettings()
	{
	}

	public void CloseMenu()
	{
	}

	public void Save(string fileNamePrefix)
	{
	}

	public void SaveWithScreenshot(string fileNamePrefix)
	{
	}

	public void ReplaceSave(string fileNamePrefix, string replacedFileNamePrefix)
	{
	}

	public void DoQuickSave()
	{
	}

	public IEnumerator TestQuickSaveCoR()
	{
		return null;
	}

	public void DoQuickSaveFromMenu()
	{
	}

	public void AutoSave(Action onSaveComplete, bool onExit)
	{
	}

	private static void UTF8_Custom_GetBytes(StringBuilder s, MemoryStream stream)
	{
	}

	public static string GetSaveDefaultName()
	{
		return null;
	}

	private IEnumerator SaveCoR(string fileNamePrefix, SAVE_MODE saveMode, Action onSaveComplete, string replacedFileNamePrefix = null)
	{
		return null;
	}

	public void DoQuickLoad()
	{
	}

	public void LoadAutosave()
	{
	}

	public void LoadNewest()
	{
	}

	public void Load(string fileName, bool isBundled)
	{
	}

	private IEnumerator LoadCoR(string fileNamePrefix, bool isBundled)
	{
		return null;
	}

	public static void HandleMenuButtons(bool isOverridingSaveFile = false)
	{
	}

	private string PrettifyAndCorrectMetatables(string saveData)
	{
		return null;
	}
}
