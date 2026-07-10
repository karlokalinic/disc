using PixelCrushers.DialogueSystem;

public static class KimSwitchNode
{
	private const string KIM_SWITCH_ID = "kim_watch";

	private const string KIM_BOOLEAN_ONLY = "boolean_only";

	public static bool IsKimSwitchNode(DialogueEntry entry)
	{
		return false;
	}

	private static bool IsBoolanOnly(DialogueEntry entry)
	{
		return false;
	}

	public static bool IsAvailable(DialogueEntry entry)
	{
		return false;
	}

	public static void HandleEntry(DialogueEntry entry, bool isLocalizationTrigger)
	{
	}
}
