using System;
using UnityEngine.Networking;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	internal class AssetBundleResource : IAssetBundleResource
	{
		internal enum LoadType
		{
			None = 0,
			Local = 1,
			Web = 2
		}

		private AssetBundle m_AssetBundle;

		private DownloadHandlerAssetBundle m_downloadHandler;

		private AsyncOperation m_RequestOperation;

		private WebRequestQueueOperation m_WebRequestQueueOperation;

		internal ProvideHandle m_ProvideHandle;

		internal AssetBundleRequestOptions m_Options;

		[NonSerialized]
		private bool m_WebRequestCompletedCallbackCalled;

		private int m_Retries;

		private long m_BytesToDownload;

		private long m_DownloadedBytes;

		private bool m_Completed;

		private const int k_WaitForWebRequestMainThreadSleep = 1;

		private string m_TransformedInternalId;

		private AssetBundleRequest m_PreloadRequest;

		private bool m_PreloadCompleted;

		internal long BytesToDownload => 0L;

		internal UnityWebRequest CreateWebRequest(IResourceLocation loc)
		{
			return null;
		}

		internal UnityWebRequest CreateWebRequest(string url)
		{
			return null;
		}

		internal AssetBundleRequest GetAssetPreloadRequest()
		{
			return null;
		}

		private float PercentComplete()
		{
			return 0f;
		}

		private DownloadStatus GetDownloadStatus()
		{
			return default(DownloadStatus);
		}

		public AssetBundle GetAssetBundle()
		{
			return null;
		}

		internal void Start(ProvideHandle provideHandle)
		{
		}

		private bool WaitForCompletionHandler()
		{
			return false;
		}

		private void AddCallbackInvokeIfDone(AsyncOperation operation, Action<AsyncOperation> callback)
		{
		}

		internal static void GetLoadInfo(ProvideHandle handle, out LoadType loadType, out string path)
		{
			loadType = default(LoadType);
			path = null;
		}

		private void BeginOperation()
		{
		}

		private void LocalRequestOperationCompleted(AsyncOperation op)
		{
		}

		private void CompleteBundleLoad(AssetBundle bundle)
		{
		}

		private void WebRequestOperationCompleted(AsyncOperation op)
		{
		}

		public void Unload()
		{
		}
	}
}
