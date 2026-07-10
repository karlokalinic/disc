using System;
using System.Collections.Generic;

namespace Sunshine.Metric
{
	public class InventoryViewData : TabbedSlotData<ItemTabGroup, InventoryItem, InventoryItemList>
	{
		public static InventoryViewData Singleton;

		public Action<string, EquipmentSlotType, bool> OnItemEquiped;

		private Dictionary<EquipmentSlotType, string> equipment;

		public int Bullets { get; set; }

		public List<InventoryItem> Keys { get; set; }

		public string LastSelectedItem { get; set; }

		private InventoryViewData()
		{
		}

		public bool IsEquipped(EquipmentSlotType slotType)
		{
			return false;
		}

		public bool IsEquipped(string itemName)
		{
			return false;
		}

		public bool IsGroupEquipped(string groupName)
		{
			return false;
		}

		public bool IsGroupHeld(string groupName)
		{
			return false;
		}

		public bool IsGroupHeldLeft(string groupName)
		{
			return false;
		}

		public bool IsGroupHeldRight(string groupName)
		{
			return false;
		}

		public string GetEquipped(ItemType itemType)
		{
			return null;
		}

		public string GetEquipped(string itemTypeValue)
		{
			return null;
		}

		public string GetEquipped(EquipmentSlotType slotType)
		{
			return null;
		}

		public InventoryItem GetItemInSlot(EquipmentSlotType slot)
		{
			return null;
		}

		public int CountValueInTab(ItemTabGroup tab)
		{
			return 0;
		}

		public string FindFirstItem()
		{
			return null;
		}

		public string FindFirstInventoryItem()
		{
			return null;
		}

		public string FindFirstEquippedItem()
		{
			return null;
		}

		public bool HasAnyItems()
		{
			return false;
		}

		public void Equip(string name, bool firstEquipInstant = false)
		{
		}

		public void Hold(string itemName, string slotName)
		{
		}

		public bool ReplaceEquipped(ItemType itemType, string oldName, string newName)
		{
			return false;
		}

		private EquipmentSlotType GetConvertedTypeForHeld(string name)
		{
			return default(EquipmentSlotType);
		}

		public void Unequip(string slotName)
		{
		}

		private void Unequip(EquipmentSlotType convertedType, bool isFirstUnequip = false)
		{
		}

		private void Unequip(string itemName, EquipmentSlotType convertedType, bool isFirstUnequip = false)
		{
		}

		public void UnequipAll()
		{
		}

		public override InventoryItemList GetLibrary()
		{
			return null;
		}

		protected override void CountAllEquippedFresh()
		{
		}

		public static void GiveObsession(string item)
		{
		}

		private static void RemoveObsession(string item)
		{
		}

		public override void ClearDataOnNewGame()
		{
		}

		public Dictionary<EquipmentSlotType, string> GetEquipmentForPeristence()
		{
			return null;
		}

		public void SetEquipmentFromPersistence(Dictionary<EquipmentSlotType, string> equipment)
		{
		}
	}
}
