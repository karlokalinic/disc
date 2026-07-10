using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public static class DialogSoundBundleManager
{
	private static HashSet<AsyncOperationHandle<AudioClip>> asyncHandles;

	public static bool CheckIsInAddressable(string addressablePath)
	{
		return false;
	}

	public static void LoadAsset(string assetName, Action<AsyncOperationHandle<AudioClip>> del)
	{
	}

	public static void Unload(AsyncOperationHandle<AudioClip> handle)
	{
	}

	public static void Cleanup()
	{
	}
}
