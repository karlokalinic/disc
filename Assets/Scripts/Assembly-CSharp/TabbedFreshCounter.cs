using System;
using System.Collections.Generic;

public class TabbedFreshCounter<TabType> where TabType : struct, IConvertible
{
	private int equippedFresh;

	private Dictionary<TabType, int> freshByTab;

	private readonly Action onFreshCountChanged;

	private TabPanel<TabType> tabPanel;

	public int EquippedFresh
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool WasOpenedSinceLastUpdate { get; set; }

	public int FreshCount => 0;

	public int Item
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public TabbedFreshCounter(Action onFreshCountChanged, TabPanel<TabType> tabPanel)
	{
	}

	public bool ShowFreshCountOnButton()
	{
		return false;
	}

	public void OnUIOpened()
	{
	}

	public void Reset()
	{
	}

	private void ClearTabCounters()
	{
	}
}
