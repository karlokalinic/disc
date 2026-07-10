using System.Collections;
using System.Collections.Generic;
using Sunshine.Metric;
using Sunshine.Views;
using UnityEngine;
using UnityEngine.UI;

namespace Sunshine
{
	public class InventoryManager : TabbedSlotManager<ItemTabGroup, InventoryItem, InventoryViewData, InventoryItemList>
	{
		public static InventoryManager Singleton;

		public Transform itemTemplate;

		public Transform equipmentSlots;

		public Transform equipmentCenter;

		public Transform conceptualEquipmentAssistPoint;

		public UIDragDock[] equipmentDocks;

		public Dictionary<EquipmentSlotType, UIDragDock> equipmentDocksOfType;

		public BulletsSlot bulletsSlot;

		public InventoryTabPanel tabPanel;

		public List<ItemType> equippableItemTypes;

		private int CurrentTab;

		public const int SLOTS_IN_SINGLE_ROW = 6;

		private const int NR_OF_INITIAL_SLOTS = 18;

		private EquipmentSlotType lastAssistedHeldSlot;

		[SerializeField]
		private VerticalStepScrollView verticalStep;

		private static readonly int interrupt;

		protected override int NumOfColumns => 0;

		public VerticalStepScrollView VerticalStep => null;

		public void OnInputKey()
		{
		}

		private void Update()
		{
		}

		private void OnControllerTabButtonsPressed()
		{
		}

		private void UpdateCurrentlySelectedTab()
		{
		}

		protected override void Awake()
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		protected void OnLanguageChanged()
		{
		}

		protected IEnumerator DelayedLanguageChange()
		{
			return null;
		}

		public void NotifyActivation(ViewType inventoryViewType)
		{
		}

		public void GetFirstActiveTabItem()
		{
		}

		public string FirstActiveTabItemName()
		{
			return null;
		}

		public UIDraggable GetFirstActiveTabItemDraggable(string currentActiveName)
		{
			return null;
		}

		public int TrySelectNextPawnableItem(int lastDraggableIndex)
		{
			return 0;
		}

		public void NotifyDeactivation(ViewType nextView)
		{
		}

		public void ResetView()
		{
		}

		public void CheckSlotStatuses()
		{
		}

		public void CheckCurrentActiveSlotStatus()
		{
		}

		public bool WillBeDockAssisted(UIDraggable uiDraggable, bool doubleClicked = false)
		{
			return false;
		}

		private UIDragDock GetHeldSlotForAssist()
		{
			return null;
		}

		protected override void OnUnequip(InventoryItem slottable)
		{
		}

		protected override InventoryViewData GetData()
		{
			return null;
		}

		protected override void OnFreshCountChange()
		{
		}

		public Transform GetTabTransform(ItemTabGroup group)
		{
			return null;
		}

		protected override TabPanel<ItemTabGroup> GetTabPanel()
		{
			return null;
		}

		protected override int GetNrOfSlotsInARow()
		{
			return 0;
		}

		protected override int GetDefaultNrOfSlots()
		{
			return 0;
		}

		protected override void InstantiateSlottable(Transform slot, string itemName)
		{
		}

		private void ResetEquippedItems()
		{
		}

		private void CheckEquipmentSlotStatuses()
		{
		}

		private bool CanAssistToEquipmentDock()
		{
			return false;
		}

		private bool CanAssistToInventoryDock()
		{
			return false;
		}

		private bool IsEquippableItemType(ItemType itemType)
		{
			return false;
		}

		private UIDragDock GetMouseClosestHeldSlot()
		{
			return null;
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

		private void SwitchToItemTab(string item)
		{
		}

		private ItemTabGroup GetNextItemTabToShow(string item)
		{
			return default(ItemTabGroup);
		}

		private ItemTabGroup GetNextActiveItemTabToShow()
		{
			return default(ItemTabGroup);
		}

		private void ChangeNavigationGroupInUse()
		{
		}

		private Button GetFirstButtonFromInventoryTab()
		{
			return null;
		}

		private Button ChooseNextSelectionBasedOnDock(UIDragDock dock)
		{
			return null;
		}

		public void SetFirstItemFromCurrentTabAsSelected()
		{
		}

		public void SelectFirst()
		{
		}

		public void OnExitView()
		{
		}

		public void RegisterEvents()
		{
		}

		public void UnregisterEvents()
		{
		}
	}
}
