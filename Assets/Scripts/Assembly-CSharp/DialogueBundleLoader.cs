using System.Collections;
using PixelCrushers.DialogueSystem;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;
using Voidforge;

public class DialogueBundleLoader : SingletonComponent<DialogueBundleLoader>
{
	private const string ASSET_ADDRESS = "Assets/Dialogue Databases/Disco Elysium.asset";

	private const string ASSET_LOCAL_ADDRESS = "Assets/Dialogue Databases/Disco Elysium Local.asset";

	public DialogueDatabase localDatabaseCache;

	public static BundleMode bundleMode;

	public static bool isReady;

	public static UnityEvent bundleWasLoaded;

	public static UnityEvent bundleWasUnloaded;

	public static AsyncOperationHandle<DialogueDatabase> databaseHandle;

	private static BundleMode previousBundleMode;

	protected void Initialize()
	{
	}

	public IEnumerator Start()
	{
		return null;
	}

	protected override void OnDestroy()
	{
	}

	public static void Load()
	{
	}

	public static bool CheckLocalXMLBundleExists()
	{
		return false;
	}

	public static bool CheckLocalFeldBundleExists()
	{
		return false;
	}

	private void LoadBuildBundle()
	{
	}

	private void LoadLocalBundle()
	{
	}

	private void UpdateLocalDatabaseCache()
	{
	}

	private bool CheckCacheNeedsUpdate()
	{
		return false;
	}

	private string GetLocalDatabaseXMLPath()
	{
		return null;
	}

	private string GetLocalDatabaseFeldProjectPath()
	{
		return null;
	}

	protected void LoadDone(AsyncOperationHandle<DialogueDatabase> databaseHandle)
	{
	}

	protected void LoadDatabase(DialogueDatabase db)
	{
	}

	public static string TimestampToVersion(string timestamp)
	{
		return null;
	}

	public static string TimestampToDate(string timestamp)
	{
		return null;
	}
}
