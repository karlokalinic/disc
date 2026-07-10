using System;
using System.Collections.Generic;

public abstract class TabbedSlotData<TabType, Slottable, LibraryType> where TabType : struct, IConvertible where Slottable : ITabbedSlottable<TabType, Slottable> where LibraryType : TabbedSlottableList<TabType, Slottable, LibraryType>
{
	protected Dictionary<TabType, Dictionary<int, string>> tabContents;

	public abstract LibraryType GetLibrary();

	public abstract void ClearDataOnNewGame();

	protected abstract void CountAllEquippedFresh();

	public string GetFromTab(TabType tab, string index)
	{
		return null;
	}

	public string GetFromTab(TabType tab, int index)
	{
		return null;
	}

	public List<string> GetFlattenedAllTabs()
	{
		return null;
	}

	public void CountAllFresh(TabbedFreshCounter<TabType> freshCounter)
	{
	}

	public bool IsTabEmpty(TabType tabType)
	{
		return false;
	}

	public int AddToFirstEmpty(string name)
	{
		return 0;
	}

	public int FindFirstEmptySlot(TabType tabType)
	{
		return 0;
	}

	public void Remove(TabType tab, int index)
	{
	}

	public void SetToSlot(TabType tabType, int index, string newSlottable, bool doReplace, string oldSlottableName, ref int verifiedIndex)
	{
	}

	public bool ReplaceIfExists(TabType tab, string oldSlottable, string newSlottable)
	{
		return false;
	}

	public void SortTab(TabType tab, LibraryType library)
	{
	}

	private static Dictionary<TabType, Dictionary<int, string>> InitTabs()
	{
		return null;
	}

	protected void ClearTabData()
	{
	}

	public Dictionary<TabType, Dictionary<int, string>> GetTabsForPeristence()
	{
		return null;
	}

	public void SetTabsFromPersistence(Dictionary<TabType, Dictionary<int, string>> tabContents)
	{
	}
}
