namespace TwitchIntegration
{
	public class TwitchMeditationCooldown
	{
		internal float TimeToMeditateAgain;

		internal float TimeToEndMeditate;

		internal float BuffDuration;

		private float meditationPollEndTime;

		private float startPollTime;

		private float endMeditationBuffTime;

		private float cooldownEndTime;

		public float GetTimeToUnlockMeditation()
		{
			return 0f;
		}

		public float GetMeditationCurrentDuration()
		{
			return 0f;
		}

		public float GetTimeToEndPoll()
		{
			return 0f;
		}

		public bool CanStartMeditate()
		{
			return false;
		}

		public bool IsOnlyWaitingForCooldownToEnd()
		{
			return false;
		}

		public float GetTimeToEndBuff()
		{
			return 0f;
		}

		public void OnMeditationPollStarted()
		{
		}

		public void OnMeditationBuffStart()
		{
		}
	}
}
