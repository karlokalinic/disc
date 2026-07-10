using System.Collections.Generic;

public static class InventoryPersister
{
	public class InventoryState
	{
		public List<InventoryItemPersister.ItemState> itemListState;

		public InventoryViewPersister.InventoryViewState inventoryViewState;

		public bool wearingBodysuit;
	}

	public static InventoryState Serialize()
	{
		return null;
	}

	public static void Deserialize(InventoryState inventoryState)
	{
	}
}
