using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using Sunshine.Metric;

public static class ThoughtAlterant
{
	public const string HOBOCOP = "hobocop";

	public static bool OrbsGiveMoney;

	public static bool OrbsGiveXp;

	public static bool CritRangeExpand;

	public static bool RedChecksFail;

	public static bool DrugsAreBad;

	public static bool FindBetterItems;

	public static List<CharacterEffect> MaleTargetBonusList;

	public static List<CharacterEffect> FemaleTargetBonusList;

	public static List<CharacterEffect> KimTargetBonusList;

	public static List<CharacterEffect> MaxLearningCaps;

	public static List<CharacterEffect> ShirtlessBonusList;

	public static List<CharacterEffect> UnarmedBonusList;

	public static List<CharacterEffect> PassiveSuccessList;

	public static List<CharacterEffect> PassiveModifiedList;

	public static int ORB_MONEY_AMOUNT;

	public static int LIBERAL_MONEY_AMOUNT;

	public static int ORB_XP_AMOUNT;

	public static int COMMUNIST_XP_AMOUNT;

	public static int ART_COP_XP_AMOUNT;

	public static float GlobalViewRadiusMultiplier;

	public static void Reset()
	{
	}

	public static int GetSkillCapAddition(Skill skill)
	{
		return 0;
	}

	public static int GetMinimalSkillCap(Skill skill)
	{
		return 0;
	}

	public static SkillCapType GetSkillCapType(CharacterEffect e)
	{
		return default(SkillCapType);
	}

	public static void OrbsCanGiveMoney(SenseOrb orb)
	{
	}

	public static void OrbsCanGiveXp(SenseOrb orb)
	{
	}

	public static bool PassiveSuccess(bool success, DialogueEntry entry)
	{
		return false;
	}

	public static int ModifyPassiveTargetValue(int minSkill, DialogueEntry entry, SkillType skillType)
	{
		return 0;
	}
}
