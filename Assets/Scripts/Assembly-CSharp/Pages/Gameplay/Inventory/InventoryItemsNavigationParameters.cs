using System.Collections.Generic;
using PagesSystem;

namespace Pages.Gameplay.Inventory
{
	public class InventoryItemsNavigationParameters : NavigationParameters
	{
		public Dictionary<ItemTabGroup, Dictionary<int, string>> tabContents;

		public InventoryItemsNavigationParameters(Dictionary<ItemTabGroup, Dictionary<int, string>> tabContents)
		{
		}
	}
}
