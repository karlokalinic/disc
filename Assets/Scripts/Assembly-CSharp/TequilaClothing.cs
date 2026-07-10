using System;
using System.Collections.Generic;
using Sunshine.Metric;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public static class TequilaClothing
{
	private const string SEPARATOR = "_";

	private const string PANTS_BELLBOTTOM = "pants_bellbottom";

	private const string JACKET_SUEDE = "jacket_suede";

	private const string NECK_TIE = "neck_tie";

	private const string SHIRT_DRESS_DISCO = "shirt_dress_disco";

	private const string SHOES_SNAKESKIN = "shoes_snakeskin";

	private static readonly List<string> TEQUILA_STANDARD_WARDROBE;

	public static Dictionary<string, AsyncOperationHandle<GameObject>> ClothingHandles;

	public static HashSet<ItemType> HIDDEN_ITEM_TYPES;

	public static int ClothesOnTequillaToLoad;

	public static Action<string, EquipmentSlotType, bool> OnItemEquiped;

	public static void WearDefaultClothing()
	{
	}

	public static void VisualPutOnTequilaClothesAfterLoad()
	{
	}

	public static void Equip(string itemName, Action loadedAction = null)
	{
	}

	private static void OnEquipItemLoaded(AsyncOperationHandle<GameObject> itemHandle)
	{
	}

	public static void EquipAndBlend(string itemName, Action loadedAction = null)
	{
	}

	private static void OnEquipAndBlendItemLoaded(AsyncOperationHandle<GameObject> itemHandle)
	{
	}

	public static void VisualHideRequiredSlots(InventoryItem item)
	{
	}

	public static void Unequip(string itemName)
	{
	}

	public static void Show(string itemName)
	{
	}

	public static void Hide(string itemName)
	{
	}

	public static void VisualRevealRequiredSlots(string itemName)
	{
	}

	public static bool LeftHeldEquipped()
	{
		return false;
	}

	public static bool RightHeldEquipped()
	{
		return false;
	}

	public static bool HatEquipped()
	{
		return false;
	}

	public static bool GlassesEquipped()
	{
		return false;
	}

	public static bool NeckEquipped()
	{
		return false;
	}

	public static bool ShirtEquipped()
	{
		return false;
	}

	public static bool JacketEquipped()
	{
		return false;
	}

	public static bool PantsEquipped()
	{
		return false;
	}

	public static bool ShoesEquipped()
	{
		return false;
	}

	public static bool GlovesEquipped()
	{
		return false;
	}
}
