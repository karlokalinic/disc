using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using Sunshine.Metric;

public static class CostOptionNode
{
	public const string identityFieldName = "ClickCost";

	public const string hiddenFieldName = "HiddenNotEnough";

	public const string costOnceName = "CostOnce";

	private const string GAIN_ITEM_ENTRY = "GainItem";

	private static HashSet<string> healingItems;

	private static HashSet<string> drugItems;

	public static bool IsCostOptionNode(DialogueEntry entry)
	{
		return false;
	}

	public static int GetCost(DialogueEntry entry)
	{
		return 0;
	}

	public static bool HaveMoney(DialogueEntry entry)
	{
		return false;
	}

	public static bool IsHiddenNotEnough(DialogueEntry entry)
	{
		return false;
	}

	public static bool IsHidden(DialogueEntry entry)
	{
		return false;
	}

	public static bool IsCostOnce(DialogueEntry entry)
	{
		return false;
	}

	public static void PayCost(DialogueEntry entry, int cost)
	{
	}

	public static FinalEntry HandleEntry(DialogueEntry entry, bool isLocalizationTrigger)
	{
		return null;
	}

	public static FinalResponseText HandleResponseText(Response response)
	{
		return null;
	}

	public static string GetResponseText(Response response)
	{
		return null;
	}

	private static InventoryItem FindItemInResponse(DialogueEntry entry)
	{
		return null;
	}

	private static string GetItemFromString(string gainItemString)
	{
		return null;
	}

	private static bool IsHealingItem(string name)
	{
		return false;
	}

	private static bool IsDrugItem(string name)
	{
		return false;
	}
}
