using UnityEngine;

public class SunshinePersistenceAutosave : MonoBehaviour
{
	private float secondsFromLastUpdate;

	private bool autosavePending;

	private const int autoSaveIntervalInSeconds = 1800;

	public const int MAX_NR_OF_AUTOSAVES = 6;

	private void Update()
	{
	}

	private void DoAutosave()
	{
	}
}
