using System.Collections.Generic;
using Sunshine.Metric;
using UnityEngine;

namespace Sunshine
{
	public static class Inventory
	{
		public const string BulletsStackName = "bullets";

		public const string KeysStackName = "key_ring";

		public static HashSet<InventoryItem> SubstanceItems;

		public static void OnPickupItem(string itemName)
		{
		}

		private static void HandlePickedUpItem(string itemName)
		{
		}

		public static void ShowHealingItemNotification(string itemName, string displayNameTerm)
		{
		}

		public static void OnEmptyContainer(List<string> items)
		{
		}

		public static void OnPickupThought(string thoughtName, GameObject itemButton)
		{
		}

		public static void OnPickupMoney(int value)
		{
		}

		public static bool CanBeGained(string thought)
		{
			return false;
		}

		public static bool CheckItemGroup(string group)
		{
			return false;
		}

		public static void SellItemGroup(string group, double modifier = 1.0)
		{
		}

		public static void SellItem(InventoryItem item)
		{
		}

		public static bool OnPickupSpecialStackable(InventoryItem newItem)
		{
			return false;
		}

		public static bool OnPickupStackable(InventoryItem newItem)
		{
			return false;
		}

		public static bool OnLoseSpecialStackable(InventoryItem lostItem)
		{
			return false;
		}

		public static bool OnLoseStackable(InventoryItem lostItem)
		{
			return false;
		}

		public static void ConvertItemsToStack(InventoryItem existingItem, InventoryItem newItem, InventoryItem stack)
		{
		}

		public static void ConvertStackToItem(InventoryItem lostItem, InventoryItem stack)
		{
		}

		private static bool ChangeInventoryItem(InventoryItem oldItem, InventoryItem newItem)
		{
			return false;
		}

		private static bool ChangeEquippedItem(InventoryItem oldItem, InventoryItem newItem)
		{
			return false;
		}

		public static void DeleteItem(string what)
		{
		}

		public static void DeleteThought(string what)
		{
		}

		public static void TakeOffAndLooseTequilaClothes()
		{
		}
	}
}
