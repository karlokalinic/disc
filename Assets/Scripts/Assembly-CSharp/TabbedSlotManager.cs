using System;
using System.Collections;
using System.Collections.Generic;
using Sunshine;
using UnityEngine;
using UnityEngine.UI;
using Voidforge;

public abstract class TabbedSlotManager<TabType, Slottable, ViewDataType, LibraryType> : VoidElement where TabType : struct, IConvertible where Slottable : ITabbedSlottable<TabType, Slottable> where ViewDataType : TabbedSlotData<TabType, Slottable, LibraryType> where LibraryType : TabbedSlottableList<TabType, Slottable, LibraryType>
{
	[SerializeField]
	private Selectable leftSelectable;

	[SerializeField]
	private Selectable rightSelectable;

	[SerializeField]
	private Selectable upSelectable;

	[SerializeField]
	private Selectable downSelectable;

	public Transform slotTemplate;

	public Transform tabTemplate;

	public Transform tabParent;

	public Transform endPadding;

	private TabType currentlyActiveTab;

	protected Dictionary<TabType, Transform> tabSlots;

	private Dictionary<TabType, int> slotAmounts;

	public Dictionary<TabType, List<Button>> tabSlotButtons;

	protected virtual int NumOfColumns => 0;

	public TabbedFreshCounter<TabType> FreshCounter { get; private set; }

	public TabType CurrentlyActiveTab
	{
		get
		{
			return default(TabType);
		}
		protected set
		{
		}
	}

	public Dictionary<TabType, int> SlotAmounts => null;

	protected abstract void InstantiateSlottable(Transform slot, string slottableName);

	protected abstract ViewDataType GetData();

	protected abstract TabPanel<TabType> GetTabPanel();

	protected abstract void OnUnequip(Slottable slottable);

	protected abstract void OnFreshCountChange();

	protected abstract int GetNrOfSlotsInARow();

	protected abstract int GetDefaultNrOfSlots();

	protected override void Awake()
	{
	}

	protected void Start()
	{
	}

	public void UpdateFreshCounts()
	{
	}

	public void AddToFirstAvailableSlot(Slottable slottable, string name)
	{
	}

	public int FindFirstEmptySlot(TabType tab)
	{
		return 0;
	}

	public bool TryGetDockWithIndex(int index, out UIDragDock dockWithIndex, TabType tabType)
	{
		dockWithIndex = null;
		return false;
	}

	public void AddARowOfSlots(TabType tab)
	{
	}

	public void SlotAndAddRowIfNecessary(TabType tabType, int index, string newSlottable, bool doReplace, string oldSlottableName, ref UIDragDock dock)
	{
	}

	public void AddSlotsToShowAllTabIfNecessary()
	{
	}

	private void CreateNrOfSlots(TabType tab, int count)
	{
	}

	private void InitNewTabIfNeeded(TabType tab)
	{
	}

	private IEnumerator UpdateTabScrollView()
	{
		return null;
	}

	protected void CheckCurrentActiveTabSlotStatus()
	{
	}

	protected void CheckAllTabSlotStatuses()
	{
	}

	protected bool TryGetTabsFirstOpenDock(TabType tab, out UIDragDock uiDragDock)
	{
		uiDragDock = null;
		return false;
	}

	private void CheckTabSlotStatuses(TabType tab, Transform tabTransform)
	{
	}

	protected void ResetSlottables()
	{
	}

	private void ResetSlottableTab(TabType tab, Transform tabTransform)
	{
	}

	public void ResetTab(TabType tab)
	{
	}

	public void SortCurrentTab()
	{
	}

	public void SelectTab(TabType tab, bool forceInitial)
	{
	}

	public void OnTabSwitch(bool initializing = false)
	{
	}

	protected void AddDraggableToDragDock(string slottableName, UIDraggable draggable, Transform parent)
	{
	}

	public void ClearAndReset(TabType defaultTab)
	{
	}

	public void SetTabsFromPersistence(Dictionary<TabType, Dictionary<int, string>> tabContents)
	{
	}

	private int GetMaxIndex(Dictionary<int, string>.KeyCollection indexes)
	{
		return 0;
	}

	private int GetRoundUpFullRowSlotsAmount(int value)
	{
		return 0;
	}
}
