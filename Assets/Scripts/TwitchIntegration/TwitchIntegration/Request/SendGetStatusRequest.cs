using System;
using System.Collections;
using TwitchIntegration.Results;

namespace TwitchIntegration.Request
{
	public class SendGetStatusRequest : SendGetRequest<StatusRequestResult>
	{
		protected override string GetMethod()
		{
			return null;
		}

		public override IEnumerator Send(string endpoint, string secret, Action<StatusRequestResult> onRequestResult)
		{
			return null;
		}
	}
}
