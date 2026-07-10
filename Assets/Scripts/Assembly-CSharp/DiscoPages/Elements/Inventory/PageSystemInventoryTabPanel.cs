using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DiscoPages.Elements.Inventory
{
	public class PageSystemInventoryTabPanel : LiteSingleton<PageSystemInventoryTabPanel>
	{
		[SerializeField]
		private PageSystemInventoryGrids inventoryGrids;

		[SerializeField]
		private List<PageSystemInventoryTabButton> tabs;

		[SerializeField]
		private Button nextTabButton;

		[SerializeField]
		private Button previousTabButton;

		[Space]
		[SerializeField]
		private TweenRectTransform selectedTabBackground;

		private ItemTabGroup currentItemTabGroup;

		private List<ItemTabGroup> allTabGroups;

		private int currentTabId;

		public ItemTabGroup CurrentItemTabGroup => default(ItemTabGroup);

		public int CurrentTabId => 0;

		public void Initialize(Dictionary<ItemTabGroup, Dictionary<int, string>> inventoryItems)
		{
		}

		public void RefreshSlotAt(ItemTabGroup group, int index)
		{
		}

		public void ChangeGroup(ItemTabGroup group, bool immediate = false)
		{
		}

		public void ChangeGroup(int direction)
		{
		}
	}
}
