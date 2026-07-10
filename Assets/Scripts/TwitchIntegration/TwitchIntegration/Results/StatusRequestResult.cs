using TwitchIntegration.JSON.Status;
using UnityEngine.Networking;

namespace TwitchIntegration.Results
{
	public class StatusRequestResult : RequestResult
	{
		public bool IsEndPointRunning;

		public StatusResponse Response;

		public StatusRequestResult()
		{
		}

		public StatusRequestResult(UnityWebRequest webRequest)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
