using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public static class InventoryItemsBundleManager
{
	public const string InventoryIconsAddressablesGroup = "invetory_icons";

	public const string InventoryIconsPath = "Assets/Addressables Resources/inventory_icons";

	public static Dictionary<string, int> InventoryIconsCacheCounter;

	public static Dictionary<string, AsyncOperationHandle<Sprite>> InventoryIconsCacheHandles;

	public static AsyncOperationHandle<Sprite> LoadItemSpriteAsync(string itemName, Action<AsyncOperationHandle<Sprite>> del)
	{
		return default(AsyncOperationHandle<Sprite>);
	}

	public static AsyncOperationHandle<Sprite> LoadItemSprite(string itemName, Action<Sprite> del)
	{
		return default(AsyncOperationHandle<Sprite>);
	}

	public static AsyncOperationHandle<Sprite> LoadSpriteByPath(string addressablePath, Action<AsyncOperationHandle<Sprite>> del)
	{
		return default(AsyncOperationHandle<Sprite>);
	}

	public static void AddToCacheSpriteAsync(string itemName)
	{
	}

	public static void RemoveFromCacheSpriteAsync(string itemName)
	{
	}

	public static bool CheckInCache(string itemName)
	{
		return false;
	}

	public static bool ItemIconExists(string itemName)
	{
		return false;
	}
}
