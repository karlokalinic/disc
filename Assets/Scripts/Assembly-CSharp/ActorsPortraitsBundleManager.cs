using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public static class ActorsPortraitsBundleManager
{
	public const string PortraitsAddressablesGroup = "portraits";

	public const string PortraitsPath = "Assets/Addressables Resources/NPC_portraits";

	public static Dictionary<string, int> PortraitsCacheCounter;

	public static Dictionary<string, AsyncOperationHandle<Sprite>> PortraitsCacheHandles;

	public static AsyncOperationHandle<Sprite> LoadPortraitSpriteAsync(string textureName, Action<AsyncOperationHandle<Sprite>> del)
	{
		return default(AsyncOperationHandle<Sprite>);
	}

	public static AsyncOperationHandle<Sprite> LoadSpriteByPath(string addressablePath, Action<AsyncOperationHandle<Sprite>> del)
	{
		return default(AsyncOperationHandle<Sprite>);
	}

	public static void AddToCacheSpriteAsync(string textureName)
	{
	}

	public static void RemoveFromCacheSpriteAsync(string textureName)
	{
	}

	public static bool CheckInCache(string textureName)
	{
		return false;
	}

	public static bool CheckPortraitIsAddressable(string textureName)
	{
		return false;
	}
}
