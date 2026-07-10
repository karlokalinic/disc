using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public static class TequilaClothingHeadwear
{
	public static Dictionary<string, AsyncOperationHandle<GameObject>> HeadhwearHandles;

	public static void EquipHeadWear(string itemName, Action loadedAction = null)
	{
	}

	private static void OnEquipHeadwearLoaded(AsyncOperationHandle<GameObject> itemHandle)
	{
	}

	public static void UnequipHeadWear(string itemName)
	{
	}

	public static void ShowHeadwear(string itemName)
	{
	}

	public static void HideHeadwear(string itemName)
	{
	}
}
