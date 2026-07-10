using System.Collections.Generic;
using Sunshine.Metric;

public class InventoryItemList : TabbedSlottableList<ItemTabGroup, InventoryItem, InventoryItemList>
{
	private const string DISPLAY_NAME_FIELD = "DisplayName";

	private const string DESCRIPTION_FIELD = "Description";

	private const string TOOLTIP_FIELD = "Tooltip";

	private const string REPUTATION_BONUS_FIELD = "ReputationBonus";

	public InventoryItemListComponent[] items;

	private Dictionary<string, InventoryItem> string2item;

	private Dictionary<InventoryItem, string> item2string;

	public List<InventoryItem> Substances { get; private set; }

	protected override void Awake()
	{
	}

	private void RefreshCache()
	{
	}

	public override InventoryItem GetByName(string name)
	{
		return null;
	}

	public override string GetName(InventoryItem item)
	{
		return null;
	}

	private void TestCache()
	{
	}

	public void ResetInventoryItems()
	{
	}
}
