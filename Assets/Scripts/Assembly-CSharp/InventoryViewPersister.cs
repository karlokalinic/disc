using System.Collections.Generic;
using Sunshine.Metric;

public static class InventoryViewPersister
{
	public class InventoryViewState
	{
		public Dictionary<EquipmentSlotType, string> equipment;

		public Dictionary<ItemTabGroup, Dictionary<int, string>> inventory;

		public int bullets;

		public List<string> keys;

		public string lastSelectedItem;
	}

	public static InventoryViewState Serialize()
	{
		return null;
	}

	public static void Deserialize(InventoryViewState inventoryViewState)
	{
	}

	private static List<InventoryItem> ConvertStringToInventoryItemsKeyList(List<string> list)
	{
		return null;
	}

	private static void ValidateInventoryContents<T>(Dictionary<T, string> inventoryContents, HashSet<InventoryItem> consumableInstances)
	{
	}

	private static List<T> ValidateList<T>(List<T> list)
	{
		return null;
	}
}
