using PixelCrushers.DialogueSystem;
using Sunshine.Metric;

public static class RedCheckNode
{
	public const string identityFieldName = "DifficultyRed";

	private const string difficultyFieldName = "DifficultyRed";

	private const string failedVarSuffix = "_failed";

	public static CheckResult GetCheck(DialogueEntry entry)
	{
		return null;
	}

	public static string GetFailedVarName(DialogueEntry entry)
	{
		return null;
	}

	public static bool IsRedCheckNode(DialogueEntry entry)
	{
		return false;
	}

	public static bool IsRedCheckDecided(DialogueEntry entry)
	{
		return false;
	}

	public static CheckResult CheckSuccess(DialogueEntry entry)
	{
		return null;
	}

	public static FinalResponseText HandleResponseText(Response response)
	{
		return null;
	}
}
