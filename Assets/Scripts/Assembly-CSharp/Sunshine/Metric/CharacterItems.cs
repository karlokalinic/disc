using System;
using System.Collections.Generic;

namespace Sunshine.Metric
{
	public class CharacterItems
	{
		public List<InventoryItem> gainedItems;

		public Dictionary<InventoryItem, CharacterEffect[]> itemEffects;

		private readonly CharacterSheet characterSheet;

		public static Action OnInventoryChange;

		public void ClearAll()
		{
		}

		public CharacterItems(CharacterSheet characterSheet)
		{
		}

		private void Initialize()
		{
		}

		public void GainItem(InventoryItem item)
		{
		}

		public void LoseItem(InventoryItem item)
		{
		}

		public void RegisterItem(InventoryItem item)
		{
		}

		public bool UnregisterItem(InventoryItem item)
		{
			return false;
		}

		public static void FireOnInventoryChange()
		{
		}

		public static bool IsItemEquipped(string item)
		{
			return false;
		}

		public static bool IsItemGained(string itemName)
		{
			return false;
		}

		public static void BakeSubstances(int amount)
		{
		}
	}
}
