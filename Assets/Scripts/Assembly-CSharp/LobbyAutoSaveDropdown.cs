using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LobbyAutoSaveDropdown : MonoBehaviour
{
	private const string AutoSaveSettingsName = "AutoSaveSettings";

	[SerializeField]
	private Dropdown dropdown;

	[SerializeField]
	private int[] minutesIntervals;

	private bool isAutoSaveEnabled;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void UpdateAutoSaveInterval(int index)
	{
	}

	private void LoadAutoSaveValue()
	{
	}

	private int GetAutoSaveValue()
	{
		return 0;
	}

	private void SaveAutoSaveValue(int value)
	{
	}

	private void StopAutoSave()
	{
	}

	private void StartAutoSave()
	{
	}

	private IEnumerator AutoSaveInvoke(int minutesInterval)
	{
		return null;
	}
}
