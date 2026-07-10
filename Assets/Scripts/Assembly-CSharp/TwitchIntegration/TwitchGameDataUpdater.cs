using System.Collections;
using System.Collections.Generic;
using Sunshine.Metric;
using TwitchIntegration.JSON.UpdateGameData;
using TwitchIntegration.Results;
using UnityEngine;

namespace TwitchIntegration
{
	public class TwitchGameDataUpdater : MonoBehaviour
	{
		private static TwitchGameDataUpdater _instance;

		private const float DATA_UPDATE_INTERVAL = 5f;

		private Coroutine dataUploadCoroutine;

		private bool initialized;

		private static UpdateGameData lastSendUpdateGameData;

		public static TwitchGameDataUpdater Instance => null;

		public static void Initialize()
		{
		}

		private static void TwitchManager_OnEnableStateChanged(bool twitchIntegrationEnabled)
		{
		}

		public static void StartDataUpdate()
		{
		}

		public static void StopDataUpdate()
		{
		}

		private static IEnumerator UploadData()
		{
			return null;
		}

		private static void SendDataUpdateToTwitchPlugin()
		{
		}

		private static void PerceptionSpecialBehaviour(Modifiable modifiable, List<Modifier> modifiersToDisplay)
		{
		}

		private static Task[] GetTaskList()
		{
			return null;
		}

		private static void OnRequestResultRecieved(RequestResult obj)
		{
		}
	}
}
