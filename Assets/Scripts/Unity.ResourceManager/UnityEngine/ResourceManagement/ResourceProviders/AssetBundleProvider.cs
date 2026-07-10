using System;
using System.ComponentModel;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[DisplayName]
	public class AssetBundleProvider : ResourceProviderBase
	{
		public override void Provide(ProvideHandle providerInterface)
		{
		}

		public override Type GetDefaultType(IResourceLocation location)
		{
			return null;
		}

		public override void Release(IResourceLocation location, object asset)
		{
		}
	}
}
