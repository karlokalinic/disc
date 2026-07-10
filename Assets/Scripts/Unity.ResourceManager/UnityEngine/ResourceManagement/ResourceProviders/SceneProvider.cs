using System.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.SceneManagement;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	public class SceneProvider : ISceneProvider
	{
		private class SceneOp : AsyncOperationBase<SceneInstance>, IUpdateReceiver
		{
			private bool m_ActivateOnLoad;

			private SceneInstance m_Inst;

			private IResourceLocation m_Location;

			private LoadSceneMode m_LoadMode;

			private int m_Priority;

			private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp;

			private ResourceManager m_ResourceManager;

			protected override string DebugName => null;

			protected override float Progress => 0f;

			public SceneOp(ResourceManager rm)
			{
			}

			internal override DownloadStatus GetDownloadStatus(HashSet<object> visited)
			{
				return default(DownloadStatus);
			}

			public void Init(IResourceLocation location, LoadSceneMode loadMode, bool activateOnLoad, int priority, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp)
			{
			}

			protected override bool InvokeWaitForCompletion()
			{
				return false;
			}

			protected override void GetDependencies(List<AsyncOperationHandle> deps)
			{
			}

			protected override void Execute()
			{
			}

			internal SceneInstance InternalLoadScene(IResourceLocation location, bool loadingFromBundle, LoadSceneMode loadMode, bool activateOnLoad, int priority)
			{
				return default(SceneInstance);
			}

			private AsyncOperation InternalLoad(string path, bool loadingFromBundle, LoadSceneMode mode)
			{
				return null;
			}

			protected override void Destroy()
			{
			}

			void IUpdateReceiver.Update(float unscaledDeltaTime)
			{
			}
		}

		private class UnloadSceneOp : AsyncOperationBase<SceneInstance>
		{
			private SceneInstance m_Instance;

			private AsyncOperationHandle<SceneInstance> m_sceneLoadHandle;

			protected override float Progress => 0f;

			public void Init(AsyncOperationHandle<SceneInstance> sceneLoadHandle)
			{
			}

			protected override void Execute()
			{
			}

			protected override bool InvokeWaitForCompletion()
			{
				return false;
			}

			private void UnloadSceneCompleted(AsyncOperation obj)
			{
			}

			private void UnloadSceneCompletedNoRelease(AsyncOperation obj)
			{
			}
		}

		public AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneMode loadMode, bool activateOnLoad, int priority)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public AsyncOperationHandle<SceneInstance> ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}
	}
}
