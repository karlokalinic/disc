using System;
using FortressOccident;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaStatePersistence : MonoBehaviour
{
	[NonSerialized]
	public string persistenceName;

	private Scene sourceScene;

	private CharacterScheduleManager scheduleManager;

	private Character character;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnSceneActivated()
	{
	}

	private bool IsSpawnedInSchedule()
	{
		return false;
	}
}
