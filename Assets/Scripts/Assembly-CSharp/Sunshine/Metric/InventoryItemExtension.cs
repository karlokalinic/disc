using System.Collections.Generic;

namespace Sunshine.Metric
{
	public static class InventoryItemExtension
	{
		private static List<ItemGroup> nonConsumableGroups;

		public static int ItemsUses(this InventoryItem heldItem)
		{
			return 0;
		}

		public static bool IsConsumableGroup(this InventoryItem item)
		{
			return false;
		}
	}
}
