using TwitchIntegration.JSON.Poll;
using UnityEngine.Networking;

namespace TwitchIntegration.Results
{
	public class DialoguePollRequestResult : RequestResult
	{
		public string Response;

		public bool HavePoll;

		public GetDialoguePoll DialogPollData;

		public DialoguePollRequestResult()
		{
		}

		public DialoguePollRequestResult(UnityWebRequest webRequest)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
