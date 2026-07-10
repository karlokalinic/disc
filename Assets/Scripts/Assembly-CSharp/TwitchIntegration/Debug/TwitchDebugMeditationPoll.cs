using TwitchIntegration.JSON.Poll;
using TwitchIntegration.Results;
using UnityEngine;
using UnityEngine.UI;

namespace TwitchIntegration.Debug
{
	public class TwitchDebugMeditationPoll : TwitchDebug
	{
		[SerializeField]
		protected Text stateLabel;

		private void Start()
		{
		}

		private string GetStateText(bool state)
		{
			return null;
		}

		public void SendCreateMeditationPoll()
		{
		}

		private bool BreakIfTwitchManagerDoesNotWork()
		{
			return false;
		}

		public void SendCloseMeditationPoll()
		{
		}

		private void OnMeditationPollResultRecieved(MeditationPollRequestResult meditationPollResult)
		{
		}

		private string GetMeditiationResult(GetMeditationPoll pollData)
		{
			return null;
		}

		private void OnRequestResultRecieved(RequestResult requestResult)
		{
		}

		public void AddDebugMeditationBonusINT_MOT()
		{
		}

		public void AddDebugMeditationBonusFYS_PSY()
		{
		}

		public void ClearDebugMeditationBonus()
		{
		}
	}
}
