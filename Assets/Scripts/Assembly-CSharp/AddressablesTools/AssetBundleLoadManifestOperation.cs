using System;

namespace AddressablesTools
{
	public class AssetBundleLoadManifestOperation : AssetBundleLoadAssetOperationFull
	{
		public AssetBundleLoadManifestOperation(string bundleName, string assetName, Type type)
			: base(null, null, null)
		{
		}

		public override bool Update()
		{
			return false;
		}
	}
}
