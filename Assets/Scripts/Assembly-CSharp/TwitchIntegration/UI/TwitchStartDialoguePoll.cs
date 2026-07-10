using System.Collections;
using Sunshine.Views;
using TMPro;
using TwitchIntegration.Results;
using UnityEngine;
using UnityEngine.UI;

namespace TwitchIntegration.UI
{
	public class TwitchStartDialoguePoll : MonoBehaviour
	{
		[SerializeField]
		private Button startPoll;

		[SerializeField]
		private Image pollInProgress;

		[SerializeField]
		private TextMeshProUGUI timer;

		[SerializeField]
		private CanvasGroup canvasGroup;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnTwitchEnableStateChanged(bool arg0)
		{
		}

		private void OnDialogPollStarted()
		{
		}

		private void SendCreateDialoguePoll()
		{
		}

		private void OnCreatePollRequestResultRecieved(RequestResult requestResult)
		{
		}

		private void RefreshStartDialogPollButtonState()
		{
		}

		private void RefreshStartDialogPollButtonState(ViewType viewType)
		{
		}

		private IEnumerator DialogPollTracker()
		{
			return null;
		}

		private void OnClosePollRequestResultRecieved(DialoguePollRequestResult requestResult)
		{
		}

		private void MakeImageRedAfterFailedStartPoll()
		{
		}
	}
}
