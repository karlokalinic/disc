using System.Collections.Generic;
using PagesSystem;

namespace Pages.Gameplay.Inventory
{
	public class InventoryNavigationParameters : NavigationParameters
	{
		public Dictionary<EquipmentSlotType, string> equipment;

		public InventoryNavigationParameters(Dictionary<EquipmentSlotType, string> equipment)
		{
		}
	}
}
