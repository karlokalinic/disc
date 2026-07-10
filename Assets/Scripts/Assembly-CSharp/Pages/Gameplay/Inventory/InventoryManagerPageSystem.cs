using System.Collections.Generic;
using Sunshine;
using Sunshine.Metric;
using Sunshine.Views;
using UnityEngine;

namespace Pages.Gameplay.Inventory
{
	public class InventoryManagerPageSystem : MonoBehaviour
	{
		public static InventoryManagerPageSystem Singleton;

		public List<ItemType> equippableItemTypes;

		private int CurrentTab;

		private const int SLOTS_IN_SINGLE_ROW = 6;

		private const int NR_OF_INITIAL_SLOTS = 18;

		private EquipmentSlotType lastAssistedHeldSlot;

		private static readonly int interrupt;

		protected void Awake()
		{
		}

		public void NotifyActivation(ViewType inventoryViewType)
		{
		}

		public void NotifyDeactivation(ViewType nextView)
		{
		}

		public void ResetView()
		{
		}

		protected void OnUnequip(InventoryItem slottable)
		{
		}

		protected InventoryViewData GetData()
		{
			return null;
		}

		private bool IsEquippableItemType(ItemType itemType)
		{
			return false;
		}

		public void ChangeSlot(UIDragDock slot, SlotState state)
		{
		}

		public void ChangeOtherSlots(UIDragDock exceptionSlot, SlotState state)
		{
		}

		public void ChangeAllSlotStates(SlotState state)
		{
		}

		private void SetAnimatorInterruptTrigger(bool set)
		{
		}
	}
}
