using System.Collections.Generic;

public static class InventoryItemPersister
{
	public class ItemState
	{
		public string itemName;

		public bool isFresh;

		public int substanceUses;

		public int substanceTimeLeft;

		public List<string> StackItems;
	}

	public static List<ItemState> SerializeItemProperties()
	{
		return null;
	}

	public static void DeserializeItemProperties(List<ItemState> itemStateList)
	{
	}
}
