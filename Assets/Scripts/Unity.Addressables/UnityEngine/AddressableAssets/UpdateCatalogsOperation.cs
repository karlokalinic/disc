using System.Collections.Generic;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.AddressableAssets
{
	internal class UpdateCatalogsOperation : AsyncOperationBase<List<IResourceLocator>>
	{
		private AddressablesImpl m_Addressables;

		private List<AddressablesImpl.ResourceLocatorInfo> m_LocatorInfos;

		private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp;

		public UpdateCatalogsOperation(AddressablesImpl aa)
		{
		}

		public AsyncOperationHandle<List<IResourceLocator>> Start(IEnumerable<string> catalogIds)
		{
			return default(AsyncOperationHandle<List<IResourceLocator>>);
		}

		protected override bool InvokeWaitForCompletion()
		{
			return false;
		}

		protected override void Destroy()
		{
		}

		protected override void GetDependencies(List<AsyncOperationHandle> dependencies)
		{
		}

		protected override void Execute()
		{
		}
	}
}
