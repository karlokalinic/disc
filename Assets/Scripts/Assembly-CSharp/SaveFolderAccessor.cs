using System;
using System.Collections;
using Voidforge;

public class SaveFolderAccessor : SingletonComponent<SaveFolderAccessor>
{
	public struct SaveGameBackupData
	{
		public byte[] thumbnail;

		public byte[] zip;
	}

	private string SavesConversionFilename;

	public static SaveSlotCache SaveSlotCache;

	public bool savesOpened;

	private int settingsCounter;

	public bool settingsOpened;

	private bool settingsSave;

	private bool settingsRunning;

	public static int GameSettingsCloseTimeout { get; set; }

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	public IEnumerator SavesAlreadyConverted(Action<bool> callback)
	{
		return null;
	}

	public IEnumerator ConvertSavesToSlots(Action<bool> callback)
	{
		return null;
	}

	public IEnumerator ReadGameSavesCoR(Action<bool> methodCall = null)
	{
		return null;
	}

	public IEnumerator OpenGameSavesCoR(SlotMountFlag flag, Action<bool> callback, bool isLoadOrSave = false)
	{
		return null;
	}

	public IEnumerator CloseGameSavesCoR(Action<bool> callback = null)
	{
		return null;
	}

	public void TouchGameSettingsWrites(int timeout)
	{
	}

	public IEnumerator OpenGameSettingsCoR(Action<bool> callback)
	{
		return null;
	}

	public IEnumerator CloseGameSettingsCoR(Action<bool> callback = null)
	{
		return null;
	}

	private void Reset()
	{
	}

	private void OpenGameSettingsAccessInternal()
	{
	}

	private bool CanCloseGameSettings()
	{
		return false;
	}

	private IEnumerator RunGameSettingsProcess()
	{
		return null;
	}

	public bool HasLegacySaveGames()
	{
		return false;
	}

	private static string SlotMountPath(string slotName = "")
	{
		return null;
	}

	public IEnumerator SlotMount(Action<SlotResult, SlotMountPoint> callback, string slotName, string slotTitle, string slotSubTitle, SlotMountFlag flag)
	{
		return null;
	}

	public IEnumerator SlotUnmount(Action<SlotResult> callback, SlotMountPoint mountPoint)
	{
		return null;
	}

	public bool SlotExists(string slotName)
	{
		return false;
	}

	public bool SlotDelete(string slotName)
	{
		return false;
	}

	public bool SlotList(out string[] list)
	{
		list = null;
		return false;
	}

	public IEnumerator LoadGameMetadata(Action<SlotResult> callback, string name, FileOpCommandBuffer fileCmdBuffer)
	{
		return null;
	}

	public IEnumerator SaveGame(Action<SlotResult> callback, SaveSlotDesc slot, FileOpCommandBuffer fileCmdBuffer)
	{
		return null;
	}

	public IEnumerator LoadGame(Action<SlotResult> callback, SaveSlotDesc slot, FileOpCommandBuffer fileCmdBuffer)
	{
		return null;
	}

	public IEnumerator DeleteGame(Action<bool> callback, SaveSlotDesc slot)
	{
		return null;
	}

	private IEnumerator SlotExecute(Action<SlotResult> callback, FileOpCommandBuffer fileCmdBuffer, string slotName, string slotTitle, string slotSubTitle, SlotMountFlag mountFlag)
	{
		return null;
	}

	public static string GenerateSaveSlotUniqueName()
	{
		return null;
	}

	private static string SlotCacheMountPath(string slotName = "")
	{
		return null;
	}

	public bool HasSaveSlotCache()
	{
		return false;
	}

	public IEnumerator ReadSaveSlotCache()
	{
		return null;
	}

	public IEnumerator WriteSaveSlotCache(Action<SlotResult> callback = null)
	{
		return null;
	}

	public IEnumerator UpdateSaveSlotCache()
	{
		return null;
	}

	public IEnumerator CheckSaveSlotCacheCoherency(Action<string[]> callback, string[] verifiedListOfSaves)
	{
		return null;
	}

	private IEnumerator SlotCacheMount(Action<SlotResult, SlotMountPoint> callback, SlotMountFlag flag)
	{
		return null;
	}

	private IEnumerator SlotCacheUnmount(Action<SlotResult> callback, SlotMountPoint mountPoint)
	{
		return null;
	}

	private IEnumerator SlotCacheExecute(Action<SlotResult> callback, FileOpCommandBuffer fileCmdBuffer, SlotMountFlag mountFlag)
	{
		return null;
	}
}
