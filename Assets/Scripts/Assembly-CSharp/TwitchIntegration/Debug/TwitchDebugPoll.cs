using TwitchIntegration.JSON.Poll;
using TwitchIntegration.Results;
using UnityEngine;
using UnityEngine.UI;

namespace TwitchIntegration.Debug
{
	public class TwitchDebugPoll : TwitchDebug
	{
		[SerializeField]
		protected Text stateLabel;

		[SerializeField]
		protected Text pollResultLabel;

		private void Start()
		{
		}

		private string GetStateText(bool state)
		{
			return null;
		}

		public void SendCreateDialoguePoll()
		{
		}

		public void SendCloseDialoguePoll()
		{
		}

		private bool BreakIfTwitchManagerDoesNotWork()
		{
			return false;
		}

		public void SendDialoguePollStateRequest()
		{
		}

		private void OnDialoguePollClosedResultRecieved(DialoguePollRequestResult dialoguePollResult)
		{
		}

		private void OnDialoguePollResultRecieved(DialoguePollRequestResult dialoguePollResult)
		{
		}

		private string GetVoteList(GetDialoguePoll dialogPollData)
		{
			return null;
		}

		private void OnCreatePollRequestResultRecieved(RequestResult requestResult)
		{
		}

		private void OnRequestResultRecieved(RequestResult requestResult)
		{
		}
	}
}
