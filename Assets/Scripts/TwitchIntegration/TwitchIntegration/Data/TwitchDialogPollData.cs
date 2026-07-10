using TwitchIntegration.JSON.Poll;
using UnityEngine.Events;

namespace TwitchIntegration.Data
{
	public class TwitchDialogPollData
	{
		internal float TimePollIsActive;

		private bool wasForceClosed;

		private float timePoolWillEnd;

		public bool IsActive { get; private set; }

		public GetDialoguePoll lastDialogPollData { get; private set; }

		public UnityEvent OnDialogPollStarted { get; private set; }

		public UnityEvent<GetDialoguePoll> OnDialogPollDataUpdated { get; private set; }

		public UnityEvent OnDialogPollClosed { get; private set; }

		public UnityEvent OnDialogPollForcedClose { get; private set; }

		internal void PollClosed(GetDialoguePoll dialoguePoll)
		{
		}

		public float GetTimeToEndPool()
		{
			return 0f;
		}

		internal void ForceClosePoll()
		{
		}

		internal void PollStarted()
		{
		}

		internal void UpdatePoll(GetDialoguePoll dialoguePoll)
		{
		}
	}
}
