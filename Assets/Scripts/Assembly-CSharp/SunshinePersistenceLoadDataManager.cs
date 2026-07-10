using UnityEngine.Events;
using Voidforge;

public class SunshinePersistenceLoadDataManager : SingletonComponent<SunshinePersistenceLoadDataManager>
{
	public static UnityEvent AfterDataFinishedLoading;

	private static string FILENAME_PREFIX;

	private static string jsonSaveGameString;

	public void ApplyLoadedData(string fileNamePrefix)
	{
	}

	public void ApplyLoadedDataFromMemory(string dataStringFOW, string dataStringPreload, string dataStringSaveGame)
	{
	}

	private void LoadAreaAndQueueCallbacks()
	{
	}

	private void LoadAreaAndQueueCallbacksFromMemory(string dataStringPreload)
	{
	}

	private void LoadDataAfterLoadingArea()
	{
	}

	private void ResetVariousStates()
	{
	}

	private void ResetGameStartStates()
	{
	}
}
