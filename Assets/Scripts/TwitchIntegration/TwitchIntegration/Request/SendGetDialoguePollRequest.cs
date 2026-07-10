using System;
using System.Collections;
using TwitchIntegration.Results;

namespace TwitchIntegration.Request
{
	public class SendGetDialoguePollRequest : SendGetRequest<DialoguePollRequestResult>
	{
		protected override string GetMethod()
		{
			return null;
		}

		public override IEnumerator Send(string endpoint, string secret, Action<DialoguePollRequestResult> onRequestResult)
		{
			return null;
		}
	}
}
