using PixelCrushers.DialogueSystem;
using Sunshine.Metric;

public static class WhiteCheckNode
{
	public const string identityFieldName = "DifficultyWhite";

	private const string difficultyFieldName = "DifficultyWhite";

	public static CheckResult GetCheck(DialogueEntry entry)
	{
		return null;
	}

	public static bool IsWhiteCheckNode(DialogueEntry entry)
	{
		return false;
	}

	public static bool IsWhiteCheckPassed(DialogueEntry entry)
	{
		return false;
	}

	public static bool IsWhiteCheckPossible(DialogueEntry entry)
	{
		return false;
	}

	public static CheckResult CheckSuccess(DialogueEntry entry)
	{
		return null;
	}

	private static WhiteCheck ConstructAWhiteCheck(string flagName, DialogueEntry entry, CheckResult checkResult, Actor actor)
	{
		return null;
	}

	public static FinalResponseText HandleResponseText(Response response)
	{
		return null;
	}

	public static void AddCheckToSeen(DialogueEntry entry)
	{
	}
}
