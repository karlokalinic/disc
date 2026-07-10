using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.Networking;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.ResourceManagement.Util;
using UnityEngine.SceneManagement;

namespace UnityEngine.AddressableAssets
{
	internal class AddressablesImpl : IEqualityComparer<IResourceLocation>
	{
		public class ResourceLocatorInfo
		{
			public IResourceLocator Locator { get; private set; }

			public string LocalHash { get; private set; }

			public IResourceLocation CatalogLocation { get; private set; }

			public bool ContentUpdateAvailable { get; internal set; }

			public IResourceLocation HashLocation => null;

			public bool CanUpdateContent => false;

			public ResourceLocatorInfo(IResourceLocator loc, string localHash, IResourceLocation remoteCatalogLocation)
			{
			}

			internal void UpdateContent(IResourceLocator locator, string hash, IResourceLocation loc)
			{
			}
		}

		private class LoadResourceLocationKeyOp : AsyncOperationBase<IList<IResourceLocation>>
		{
			private object m_Keys;

			private IList<IResourceLocation> m_locations;

			private AddressablesImpl m_Addressables;

			private Type m_ResourceType;

			protected override string DebugName => null;

			public void Init(AddressablesImpl aa, Type t, object keys)
			{
			}

			protected override bool InvokeWaitForCompletion()
			{
				return false;
			}

			protected override void Execute()
			{
			}
		}

		private class LoadResourceLocationKeysOp : AsyncOperationBase<IList<IResourceLocation>>
		{
			private IEnumerable m_Key;

			private Addressables.MergeMode m_MergeMode;

			private IList<IResourceLocation> m_locations;

			private AddressablesImpl m_Addressables;

			private Type m_ResourceType;

			protected override string DebugName => null;

			public void Init(AddressablesImpl aa, Type t, IEnumerable key, Addressables.MergeMode mergeMode)
			{
			}

			protected override void Execute()
			{
			}

			protected override bool InvokeWaitForCompletion()
			{
				return false;
			}
		}

		private ResourceManager m_ResourceManager;

		private IInstanceProvider m_InstanceProvider;

		private int m_CatalogRequestsTimeout;

		internal const string kCacheDataFolder = "{UnityEngine.Application.persistentDataPath}/com.unity.addressables/";

		public ISceneProvider SceneProvider;

		internal List<ResourceLocatorInfo> m_ResourceLocators;

		private AsyncOperationHandle<IResourceLocator> m_InitializationOperation;

		private AsyncOperationHandle<List<string>> m_ActiveCheckUpdateOperation;

		internal AsyncOperationHandle<List<IResourceLocator>> m_ActiveUpdateOperation;

		private Action<AsyncOperationHandle> m_OnHandleCompleteAction;

		private Action<AsyncOperationHandle> m_OnSceneHandleCompleteAction;

		private Action<AsyncOperationHandle> m_OnHandleDestroyedAction;

		private Dictionary<object, AsyncOperationHandle> m_resultToHandle;

		internal HashSet<AsyncOperationHandle> m_SceneInstances;

		internal bool hasStartedInitialization;

		public IInstanceProvider InstanceProvider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ResourceManager ResourceManager => null;

		public int CatalogRequestsTimeout
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal int SceneOperationCount => 0;

		internal int TrackedHandleCount => 0;

		public Func<IResourceLocation, string> InternalIdTransformFunc
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Action<UnityWebRequest> WebRequestOverride
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AsyncOperationHandle ChainOperation => default(AsyncOperationHandle);

		internal bool ShouldChainRequest => false;

		public string StreamingAssetsSubFolder => null;

		public string BuildPath => null;

		public string PlayerBuildDataPath => null;

		public string RuntimePath => null;

		public IEnumerable<IResourceLocator> ResourceLocators => null;

		internal IEnumerable<string> CatalogsWithAvailableUpdates => null;

		public AddressablesImpl(IAllocationStrategy alloc)
		{
		}

		internal void ReleaseSceneManagerOperation()
		{
		}

		internal void OnSceneUnloaded(Scene scene)
		{
		}

		public void Log(string msg)
		{
		}

		public void LogFormat(string format, params object[] args)
		{
		}

		public void LogWarning(string msg)
		{
		}

		public void LogWarningFormat(string format, params object[] args)
		{
		}

		public void LogError(string msg)
		{
		}

		public void LogException(AsyncOperationHandle op, Exception ex)
		{
		}

		public void LogErrorFormat(string format, params object[] args)
		{
		}

		public string ResolveInternalId(string id)
		{
			return null;
		}

		public void AddResourceLocator(IResourceLocator loc, string localCatalogHash = null, IResourceLocation remoteCatalogLocation = null)
		{
		}

		public void RemoveResourceLocator(IResourceLocator loc)
		{
		}

		public void ClearResourceLocators()
		{
		}

		internal bool GetResourceLocations(object key, Type type, out IList<IResourceLocation> locations)
		{
			locations = null;
			return false;
		}

		internal bool GetResourceLocations(IEnumerable keys, Type type, Addressables.MergeMode merge, out IList<IResourceLocation> locations)
		{
			locations = null;
			return false;
		}

		public AsyncOperationHandle<IResourceLocator> InitializeAsync(string runtimeDataPath, string providerSuffix = null, bool autoReleaseHandle = true)
		{
			return default(AsyncOperationHandle<IResourceLocator>);
		}

		public AsyncOperationHandle<IResourceLocator> InitializeAsync()
		{
			return default(AsyncOperationHandle<IResourceLocator>);
		}

		internal ResourceLocationBase CreateCatalogLocationWithHashDependencies(string catalogPath, string hashFilePath)
		{
			return null;
		}

		public AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle = true, string providerSuffix = null)
		{
			return default(AsyncOperationHandle<IResourceLocator>);
		}

		private AsyncOperationHandle<SceneInstance> TrackHandle(AsyncOperationHandle<SceneInstance> handle)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		private AsyncOperationHandle<TObject> TrackHandle<TObject>(AsyncOperationHandle<TObject> handle)
		{
			return default(AsyncOperationHandle<TObject>);
		}

		private AsyncOperationHandle TrackHandle(AsyncOperationHandle handle)
		{
			return default(AsyncOperationHandle);
		}

		internal void ClearTrackHandles()
		{
		}

		public AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(IResourceLocation location)
		{
			return default(AsyncOperationHandle<TObject>);
		}

		private AsyncOperationHandle<TObject> LoadAssetWithChain<TObject>(AsyncOperationHandle dep, object key)
		{
			return default(AsyncOperationHandle<TObject>);
		}

		public AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key)
		{
			return default(AsyncOperationHandle<TObject>);
		}

		public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsWithChain(AsyncOperationHandle dep, IEnumerable keys, Addressables.MergeMode mode, Type type)
		{
			return default(AsyncOperationHandle<IList<IResourceLocation>>);
		}

		public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IEnumerable keys, Addressables.MergeMode mode, Type type = null)
		{
			return default(AsyncOperationHandle<IList<IResourceLocation>>);
		}

		public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsWithChain(AsyncOperationHandle dep, object key, Type type)
		{
			return default(AsyncOperationHandle<IList<IResourceLocation>>);
		}

		public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(object key, Type type = null)
		{
			return default(AsyncOperationHandle<IList<IResourceLocation>>);
		}

		public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure)
		{
			return default(AsyncOperationHandle<IList<TObject>>);
		}

		private AsyncOperationHandle<IList<TObject>> LoadAssetsWithChain<TObject>(AsyncOperationHandle dep, IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure)
		{
			return default(AsyncOperationHandle<IList<TObject>>);
		}

		public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure)
		{
			return default(AsyncOperationHandle<IList<TObject>>);
		}

		private AsyncOperationHandle<IList<TObject>> LoadAssetsWithChain<TObject>(AsyncOperationHandle dep, object key, Action<TObject> callback, bool releaseDependenciesOnFailure)
		{
			return default(AsyncOperationHandle<IList<TObject>>);
		}

		public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback, bool releaseDependenciesOnFailure)
		{
			return default(AsyncOperationHandle<IList<TObject>>);
		}

		private void OnHandleDestroyed(AsyncOperationHandle handle)
		{
		}

		private void OnSceneHandleCompleted(AsyncOperationHandle handle)
		{
		}

		private void OnHandleCompleted(AsyncOperationHandle handle)
		{
		}

		public void Release<TObject>(TObject obj)
		{
		}

		public void Release<TObject>(AsyncOperationHandle<TObject> handle)
		{
		}

		public void Release(AsyncOperationHandle handle)
		{
		}

		private AsyncOperationHandle<long> GetDownloadSizeWithChain(AsyncOperationHandle dep, object key)
		{
			return default(AsyncOperationHandle<long>);
		}

		private AsyncOperationHandle<long> GetDownloadSizeWithChain(AsyncOperationHandle dep, IEnumerable keys)
		{
			return default(AsyncOperationHandle<long>);
		}

		public AsyncOperationHandle<long> GetDownloadSizeAsync(object key)
		{
			return default(AsyncOperationHandle<long>);
		}

		public AsyncOperationHandle<long> GetDownloadSizeAsync(IEnumerable keys)
		{
			return default(AsyncOperationHandle<long>);
		}

		private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, object key, bool autoReleaseHandle)
		{
			return default(AsyncOperationHandle);
		}

		internal static void WrapAsDownloadLocations(List<IResourceLocation> locations)
		{
		}

		private static List<IResourceLocation> GatherDependenciesFromLocations(IList<IResourceLocation> locations)
		{
			return null;
		}

		public AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle = false)
		{
			return default(AsyncOperationHandle);
		}

		private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, IList<IResourceLocation> locations, bool autoReleaseHandle)
		{
			return default(AsyncOperationHandle);
		}

		public AsyncOperationHandle DownloadDependenciesAsync(IList<IResourceLocation> locations, bool autoReleaseHandle = false)
		{
			return default(AsyncOperationHandle);
		}

		private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, IEnumerable keys, Addressables.MergeMode mode, bool autoReleaseHandle)
		{
			return default(AsyncOperationHandle);
		}

		public AsyncOperationHandle DownloadDependenciesAsync(IEnumerable keys, Addressables.MergeMode mode, bool autoReleaseHandle = false)
		{
			return default(AsyncOperationHandle);
		}

		internal bool ClearDependencyCacheForKey(object key)
		{
			return false;
		}

		internal void AutoReleaseHandleOnCompletion(AsyncOperationHandle handle)
		{
		}

		internal void AutoReleaseHandleOnCompletion<TObject>(AsyncOperationHandle<TObject> handle)
		{
		}

		internal void AutoReleaseHandleOnCompletion<TObject>(AsyncOperationHandle<TObject> handle, bool unloadSceneOpExcludeReleaseCallback)
		{
		}

		internal void AutoReleaseHandleOnTypelessCompletion<TObject>(AsyncOperationHandle<TObject> handle)
		{
		}

		public AsyncOperationHandle<bool> ClearDependencyCacheAsync(object key, bool autoReleaseHandle)
		{
			return default(AsyncOperationHandle<bool>);
		}

		public AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<IResourceLocation> locations, bool autoReleaseHandle)
		{
			return default(AsyncOperationHandle<bool>);
		}

		public AsyncOperationHandle<bool> ClearDependencyCacheAsync(IEnumerable keys, bool autoReleaseHandle)
		{
			return default(AsyncOperationHandle<bool>);
		}

		public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Transform parent = null, bool instantiateInWorldSpace = false, bool trackHandle = true)
		{
			return default(AsyncOperationHandle<GameObject>);
		}

		public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent = null, bool trackHandle = true)
		{
			return default(AsyncOperationHandle<GameObject>);
		}

		public AsyncOperationHandle<GameObject> InstantiateAsync(object key, Transform parent = null, bool instantiateInWorldSpace = false, bool trackHandle = true)
		{
			return default(AsyncOperationHandle<GameObject>);
		}

		public AsyncOperationHandle<GameObject> InstantiateAsync(object key, Vector3 position, Quaternion rotation, Transform parent = null, bool trackHandle = true)
		{
			return default(AsyncOperationHandle<GameObject>);
		}

		private AsyncOperationHandle<GameObject> InstantiateWithChain(AsyncOperationHandle dep, object key, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			return default(AsyncOperationHandle<GameObject>);
		}

		public AsyncOperationHandle<GameObject> InstantiateAsync(object key, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			return default(AsyncOperationHandle<GameObject>);
		}

		private AsyncOperationHandle<GameObject> InstantiateWithChain(AsyncOperationHandle dep, IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			return default(AsyncOperationHandle<GameObject>);
		}

		public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			return default(AsyncOperationHandle<GameObject>);
		}

		public bool ReleaseInstance(GameObject instance)
		{
			return false;
		}

		internal AsyncOperationHandle<SceneInstance> LoadSceneWithChain(AsyncOperationHandle dep, object key, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100, bool trackHandle = true)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100, bool trackHandle = true)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, bool autoReleaseHandle = true)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, bool autoReleaseHandle = true)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle = true)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		internal AsyncOperationHandle<SceneInstance> CreateUnloadSceneWithChain(AsyncOperationHandle handle, bool autoReleaseHandle)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		internal AsyncOperationHandle<SceneInstance> CreateUnloadSceneWithChain(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		internal AsyncOperationHandle<SceneInstance> InternalUnloadScene(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		private object EvaluateKey(object obj)
		{
			return null;
		}

		internal AsyncOperationHandle<List<string>> CheckForCatalogUpdates(bool autoReleaseHandle = true)
		{
			return default(AsyncOperationHandle<List<string>>);
		}

		internal ResourceLocatorInfo GetLocatorInfo(string c)
		{
			return null;
		}

		internal AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(IEnumerable<string> catalogIds = null, bool autoReleaseHandle = true)
		{
			return default(AsyncOperationHandle<List<IResourceLocator>>);
		}

		public bool Equals(IResourceLocation x, IResourceLocation y)
		{
			return false;
		}

		public int GetHashCode(IResourceLocation loc)
		{
			return 0;
		}
	}
}
