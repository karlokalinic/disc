using System;
using System.Collections;
using TwitchIntegration.Results;

namespace TwitchIntegration.Request
{
	public abstract class SendGetRequest<T> where T : RequestResult
	{
		protected virtual string GetMethod()
		{
			return null;
		}

		public virtual IEnumerator Send(string endpoint, string secret, Action<T> onRequestResult)
		{
			return null;
		}

		public virtual IEnumerator SendPost(string endpoint, string secret, string data, Action<T> onRequestResult)
		{
			return null;
		}
	}
}
