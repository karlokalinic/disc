using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using Sunshine.Metric;

public static class SituationalCheckModifiers
{
	public const string CHECK_TARGET_FIELD = "check_target";

	private const string IS_FEMALE_FIELD = "IsFemale";

	private const string IS_NON_WHITE_FIELD = "IsNonwhite";

	private const string FEMINIST_THCP_NAME = "radical_feminist_agenda";

	private const string RACE_THEORY_THCP_NAME = "advanced_race_theory";

	public static List<CheckBonus> AddConditionalModifiers(DialogueEntry entry, SkillType skillType)
	{
		return null;
	}

	public static List<CheckBonus> AddConditionalModifiers(string checkTargetId, SkillType skillType)
	{
		return null;
	}

	private static void Nonwhite(Asset asset, SkillType skillType, List<CheckBonus> list)
	{
	}

	private static void MaleTargetBonuses(Asset asset, SkillType skillType, List<CheckBonus> list)
	{
	}

	private static void Kim(Asset asset, SkillType skillType, List<CheckBonus> list)
	{
	}

	public static void Shirtless(SkillType skillType, List<CheckBonus> list)
	{
	}

	public static void Unarmed(SkillType skillType, List<CheckBonus> list)
	{
	}
}
