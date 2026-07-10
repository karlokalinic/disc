using System;

namespace TwitchIntegration.JSON.Poll
{
	[Serializable]
	public class GetMeditationPoll
	{
		public bool meditation_success;

		public MeditationResult meditation_result;

		public override string ToString()
		{
			return null;
		}
	}
}
