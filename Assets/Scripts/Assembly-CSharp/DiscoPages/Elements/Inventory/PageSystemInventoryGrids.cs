using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DiscoPages.Elements.Inventory
{
	public class PageSystemInventoryGrids : MonoBehaviour
	{
		private const int INITIAL_GRID_ROWS = 3;

		private const float animationDuration = 0.4f;

		[SerializeField]
		private ScrollRect inventoryGridPrefab;

		[SerializeField]
		private InventoryItemSlot cellPrefab;

		[Space]
		[SerializeField]
		private ScrollRect gridsScrollView;

		[SerializeField]
		private Transform gridsParent;

		private int groupsQuatity;

		private List<ScrollRect> grids;

		private Dictionary<ItemTabGroup, List<InventoryItemSlot>> itemSlots;

		public void ChangeGrid(int currentGroupId, bool immediate = false)
		{
		}

		public void ResetGrids()
		{
		}

		public void GenerateEquipmentGrid(ItemTabGroup group, Dictionary<int, string> items, PageSystemInventoryTabPanel tabPanel)
		{
		}

		private void GenerateEquipmentGridCells(ItemTabGroup group, GridLayoutGroup grid, Dictionary<int, string> items)
		{
		}

		public void RefreshSlotAt(ItemTabGroup group, int index)
		{
		}
	}
}
