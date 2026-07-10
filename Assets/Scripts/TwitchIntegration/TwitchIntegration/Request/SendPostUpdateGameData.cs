using System;
using System.Collections;
using TwitchIntegration.Results;

namespace TwitchIntegration.Request
{
	public class SendPostUpdateGameData : SendGetRequest<RequestResult>
	{
		protected override string GetMethod()
		{
			return null;
		}

		public override IEnumerator SendPost(string endpoint, string data, string secret, Action<RequestResult> onRequestResult)
		{
			return null;
		}
	}
}
