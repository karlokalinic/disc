using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using Sunshine.Metric;

public class CheckNodeUtil
{
	private static string[] variableFieldList;

	private static string[] modifierFieldList;

	private static string[] tooltipFieldList;

	public const string VARIABLE_NAME_FIELD = "FlagName";

	private const string SKILL_TYPE_NAME_FIELD = "SkillType";

	public static string GetVarName(DialogueEntry entry)
	{
		return null;
	}

	private static string GetSkillId(DialogueEntry entry)
	{
		return null;
	}

	public static int GetCheckDifficulty(DialogueEntry entry, string difficultyFieldName, CheckType checkType)
	{
		return 0;
	}

	public static string GetCheckText(Response response, string difficultyFieldName, CheckType checkType)
	{
		return null;
	}

	public static SkillType GetSkillType(DialogueEntry entry)
	{
		return default(SkillType);
	}

	public static List<CheckModifier> GetCheckModifierList(DialogueEntry entry)
	{
		return null;
	}

	private static CheckModifier GetCheckModifierAt(DialogueEntry entry, int index)
	{
		return null;
	}

	public static CheckResult GetCheck(DialogueEntry entry, CheckType checkType, string difficultyFieldName)
	{
		return null;
	}

	public static FinalEntry HandleEntry(DialogueEntry entry)
	{
		return null;
	}

	public static FinalEntry HandleEntry(DialogueEntry entry, CheckResult checkResult)
	{
		return null;
	}
}
