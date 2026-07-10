using System.Collections.Generic;
using UnityEngine;
using Voidforge;

public class AsyncAssetLoader : SingletonComponent<AsyncAssetLoader>
{
	public List<AsyncAssetLoaderOperation> operations;

	public List<int> removableOperations;

	public Dictionary<string, AssetBundle> loadedBundles;

	private void Update()
	{
	}

	public static void Load(string bundle, string asset, AsyncAssetDelegate del)
	{
	}

	public static void RemoveOperation(AsyncAssetLoaderOperation op)
	{
	}

	public static void AddBundle(AssetBundle bundle)
	{
	}

	public static void ReleaseBundle(string bundleName)
	{
	}

	public void PrintOperations()
	{
	}
}
