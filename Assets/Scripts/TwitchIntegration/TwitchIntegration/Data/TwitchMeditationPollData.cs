using TwitchIntegration.JSON.Poll;
using UnityEngine.Events;

namespace TwitchIntegration.Data
{
	public class TwitchMeditationPollData
	{
		private bool wasForceClosed;

		public bool IsActive { get; private set; }

		public GetMeditationPoll lastMeditationPollData { get; private set; }

		public TwitchMeditationCooldown Cooldown { get; private set; }

		public UnityEvent OnMeditationPollStarted { get; private set; }

		public UnityEvent<GetMeditationPoll> OnMeditationPollDataUpdated { get; private set; }

		public UnityEvent OnMeditationPollClosed { get; private set; }

		public UnityEvent OnMeditationPollForcedClose { get; private set; }

		internal void PollClosed(GetMeditationPoll pollData)
		{
		}

		internal void ForceClosePoll()
		{
		}

		internal void PollStarted()
		{
		}
	}
}
