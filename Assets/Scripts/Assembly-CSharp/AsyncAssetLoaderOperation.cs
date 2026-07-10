using UnityEngine;

public class AsyncAssetLoaderOperation
{
	public AsyncLoaderState state;

	public string bundleName;

	public string bundlePath;

	public AssetBundle bundle;

	public AssetBundleCreateRequest bundleLoader;

	public string assetName;

	public Object asset;

	public AssetBundleRequest assetLoader;

	public AsyncAssetDelegate del;

	public AsyncAssetLoaderOperation(string bundleIn, string assetIn, AsyncAssetDelegate delIn)
	{
	}

	public void Tick()
	{
	}
}
