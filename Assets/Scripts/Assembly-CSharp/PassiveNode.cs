using PixelCrushers.DialogueSystem;
using Sunshine.Metric;

public static class PassiveNode
{
	public const string identityFieldName = "DifficultyPass";

	public const string difficultyFieldName = "DifficultyPass";

	public const string antipassiveIdentity = "Antipassive";

	private static DialogueEntry lastBonusedPassiveEntry;

	public static void ResetPassiveNodes()
	{
	}

	public static bool IsPassiveNode(DialogueEntry entry)
	{
		return false;
	}

	public static bool IsAlsoAntipassive(DialogueEntry entry)
	{
		return false;
	}

	public static bool IsAntiPassiveNode(DialogueEntry entry)
	{
		return false;
	}

	public static bool CheckSuccess(DialogueEntry entry)
	{
		return false;
	}

	private static int GetMinSkillValue(DialogueEntry entry, SkillType skillType)
	{
		return 0;
	}

	public static FinalEntry HandleEntry(Subtitle subtitle)
	{
		return null;
	}

	public static FinalEntry HandleEntry(DialogueEntry entry, bool applyPassiveSuccessBonus = false)
	{
		return null;
	}

	public static CheckResult GetCheckInfo(Subtitle subtitle)
	{
		return null;
	}

	public static CheckResult GetCheckInfo(DialogueEntry entry)
	{
		return null;
	}

	public static FinalResponseText HandleResponseText(Response response)
	{
		return null;
	}
}
