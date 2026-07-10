using PixelCrushers.DialogueSystem;
using Sunshine.Metric;

public class FakeCheckNode
{
	public const string identityFieldName = "DifficultyAtmo";

	public const string difficultyFieldName = "DifficultyAtmo";

	public const string alwaysSucceedFieldName = "AlwaysSucceed";

	public static CheckResult TransformCheck(DialogueEntry entry)
	{
		return null;
	}

	public static bool IsFakeCheckNode(DialogueEntry entry)
	{
		return false;
	}

	public static bool IsFakeCheckDone(DialogueEntry entry)
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
