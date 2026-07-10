using System;
using System.Collections;
using UnityEngine.Networking;

namespace TwitchIntegration.Utilities
{
	internal static class TwitchUtilities
	{
		internal static IEnumerator SendDeleteRequest(string url, string secret, Action<UnityWebRequest> onOperationFinished)
		{
			return null;
		}

		internal static IEnumerator SendPostRequest(string url, string secret, Action<UnityWebRequest> onOperationFinished)
		{
			return null;
		}

		internal static IEnumerator SendPostJsonRequest(string url, string jsonData, string secret, Action<UnityWebRequest> pnOperationFinished)
		{
			return null;
		}

		internal static IEnumerator SendGetRequest(string url, string secret, Action<UnityWebRequest> OnOperationFinished)
		{
			return null;
		}

		private static IEnumerator SendGetRequest(string url, bool addSecret = false, string secret = "", Action<UnityWebRequest> onOperationFinished = null)
		{
			return null;
		}

		private static void PrintDebugInformationAboutRequest(UnityWebRequest request)
		{
		}

		private static string GetErrorMessageSendGetRequestFinishedButResultIsInProgress(string url)
		{
			return null;
		}

		internal static IEnumerator TestRequest()
		{
			return null;
		}
	}
}
