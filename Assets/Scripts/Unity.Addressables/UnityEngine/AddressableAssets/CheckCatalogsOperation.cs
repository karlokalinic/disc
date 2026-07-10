using System.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.AddressableAssets
{
	internal class CheckCatalogsOperation : AsyncOperationBase<List<string>>
	{
		private AddressablesImpl m_Addressables;

		private List<string> m_LocalHashes;

		private List<AddressablesImpl.ResourceLocatorInfo> m_LocatorInfos;

		private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp;

		public CheckCatalogsOperation(AddressablesImpl aa)
		{
		}

		public AsyncOperationHandle<List<string>> Start(List<AddressablesImpl.ResourceLocatorInfo> locatorInfos)
		{
			return default(AsyncOperationHandle<List<string>>);
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
