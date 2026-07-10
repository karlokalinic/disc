using TwitchIntegration.JSON.Poll;
using UnityEngine.Networking;

namespace TwitchIntegration.Results
{
	public class MeditationPollRequestResult : RequestResult
	{
		public string Response;

		public bool HavePoll;

		public GetMeditationPoll MeditationPoll;

		public MeditationPollRequestResult()
		{
		}

		public MeditationPollRequestResult(UnityWebRequest webRequest)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
