using System.Collections.Generic;
using UnityEngine.Networking;

namespace UnityEngine.ResourceManagement
{
	internal static class WebRequestQueue
	{
		internal static int s_MaxRequest;

		internal static Queue<WebRequestQueueOperation> s_QueuedOperations;

		internal static List<UnityWebRequestAsyncOperation> s_ActiveRequests;

		public static void SetMaxConcurrentRequests(int maxRequests)
		{
		}

		public static WebRequestQueueOperation QueueRequest(UnityWebRequest request)
		{
			return null;
		}

		private static void OnWebAsyncOpComplete(AsyncOperation operation)
		{
		}
	}
}
