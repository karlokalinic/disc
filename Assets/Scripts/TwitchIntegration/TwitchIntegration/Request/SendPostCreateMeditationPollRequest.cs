using System;
using System.Collections;
using TwitchIntegration.Results;

namespace TwitchIntegration.Request
{
	public class SendPostCreateMeditationPollRequest : SendGetRequest<RequestResult>
	{
		protected override string GetMethod()
		{
			return null;
		}

		public override IEnumerator Send(string endpoint, string secret, Action<RequestResult> onRequestResult)
		{
			return null;
		}
	}
}
