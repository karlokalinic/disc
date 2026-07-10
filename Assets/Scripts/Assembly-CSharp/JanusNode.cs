using PixelCrushers.DialogueSystem;

public static class JanusNode
{
	public const string identityFieldName = "Condition1";

	public static string[] keys;

	public static string[] texts;

	public static bool IsJanusNode(DialogueEntry entry)
	{
		return false;
	}

	private static bool IsTrue(DialogueEntry entry, string key)
	{
		return false;
	}

	public static int GetIDOfConditionMet(DialogueEntry entry)
	{
		return 0;
	}

	public static string ChooseText(DialogueEntry entry)
	{
		return null;
	}

	public static FinalEntry HandleEntry(Subtitle subtitle)
	{
		return null;
	}

	public static FinalEntry HandleEntry(DialogueEntry entry)
	{
		return null;
	}

	public static FinalResponseText HandleResponseText(Response response)
	{
		return null;
	}
}
