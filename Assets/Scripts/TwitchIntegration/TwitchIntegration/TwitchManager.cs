using System;
using System.Collections;
using TwitchIntegration.Data;
using TwitchIntegration.JSON.Poll;
using TwitchIntegration.JSON.Status;
using TwitchIntegration.JSON.UpdateGameData;
using TwitchIntegration.Results;
using UnityEngine;
using UnityEngine.Events;

namespace TwitchIntegration
{
	public static class TwitchManager
	{
		private const string ENDPOINT_DEV = "https://disco-elysium-ebs-production.onrender.com/";

		private const string ENDPOINT_PROD = "https://disco-elysium-ebs-production.onrender.com/";

		private static TwitchDataStorage _DataStorage;

		private static TwitchDialogPollData _dialogPollData;

		public static TwitchMeditationPollData _meditationPollData;

		private static string ENDPOINT => null;

		private static TwitchDataStorage DataStorage => null;

		public static TwitchDialogPollData DialogPollData => null;

		public static TwitchMeditationPollData MeditationPollData => null;

		public static UnityEvent<bool> OnEnableStateChanged => null;

		public static bool IsEnabled => false;

		public static void RegisterSecretKey(string secret)
		{
		}

		public static void EnableTwitchIntegration()
		{
		}

		public static void DisableTwitchIntegration()
		{
		}

		public static void SendTestRequest()
		{
		}

		private static IEnumerator SendTestRequestCo()
		{
			return null;
		}

		public static void SendGetStatusRequest(Action<StatusRequestResult> onRequestResult, string secret)
		{
		}

		private static IEnumerator SendGetStatusRequestCo(Action<StatusRequestResult> onRequestResult, string secret)
		{
			return null;
		}

		public static void SendPostUpdateGameDataRequest(UpdateGameData gameData, Action<RequestResult> onRequestResult)
		{
		}

		private static IEnumerator SendPostUpdateGameDataRequestCo(UpdateGameData gameData, Action<RequestResult> onRequestResult)
		{
			return null;
		}

		public static void SetTimers(TimingValues timing_values)
		{
		}

		public static void SendGetDialoguePollRequest(Action<DialoguePollRequestResult> onRequestResult)
		{
		}

		private static IEnumerator SendGetDialoguePollRequestCo(Action<DialoguePollRequestResult> onRequestResult)
		{
			return null;
		}

		public static void SendPostCreateDialoguePollRequest(CreateDialoguePoll pollData, Action<RequestResult> onRequestResult)
		{
		}

		private static IEnumerator SendPostCreateDialoguePollRequestCo(CreateDialoguePoll pollData, Action<RequestResult> onRequestResult)
		{
			return null;
		}

		public static void SendDeleteCloseDialoguePollRequest(Action<DialoguePollRequestResult> onRequestResult)
		{
		}

		private static IEnumerator SendDeleteCloseDialoguePollRequestCo(Action<DialoguePollRequestResult> onRequestResult)
		{
			return null;
		}

		public static void SendPostCreateMeditationPollRequest(Action<RequestResult> onRequestResult)
		{
		}

		private static IEnumerator SendPostCreateMeditationPollRequestCo(Action<RequestResult> onRequestResult)
		{
			return null;
		}

		public static void SendDeleteCloseMeditationPollRequest(Action<MeditationPollRequestResult> onRequestResult)
		{
		}

		private static IEnumerator SendDeleteMeditationPollRequestCo(Action<MeditationPollRequestResult> onRequestResult)
		{
			return null;
		}

		private static IEnumerator PollDataUpdater()
		{
			return null;
		}

		public static void ForceClosePoll()
		{
		}

		public static void ForceCloseMeditationPoll()
		{
		}

		public static bool HaveAnyActivePoll()
		{
			return false;
		}

		public static void ToggleDebugUseProdFlag()
		{
		}

		public static string GetTargetServerToString()
		{
			return null;
		}

		public static Color GetTargetServerToColor()
		{
			return default(Color);
		}
	}
}
