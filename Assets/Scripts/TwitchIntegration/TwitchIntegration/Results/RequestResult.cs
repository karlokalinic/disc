using TwitchIntegration.JSON;
using UnityEngine.Networking;

namespace TwitchIntegration.Results
{
	public class RequestResult
	{
		public bool IsDone { get; private set; }

		public string WebRequestErrorMessage { get; private set; }

		public ErrorMessage ErrorInsideMessage { get; private set; }

		public bool HaveError => false;

		public RequestResult()
		{
		}

		public RequestResult(UnityWebRequest webRequest)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
