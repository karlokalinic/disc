using System;
using System.Collections;
using TwitchIntegration.Results;

namespace TwitchIntegration.Request
{
	public class SendDeleteMeditationPollRequest : SendGetRequest<MeditationPollRequestResult>
	{
		protected override string GetMethod()
		{
			return null;
		}

		public override IEnumerator Send(string endpoint, string secret, Action<MeditationPollRequestResult> onRequestResult)
		{
			return null;
		}
	}
}
