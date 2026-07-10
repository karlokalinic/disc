using System.Collections.Generic;
using Sunshine.Metric;

public static class LevelingUtils
{
	public static Dictionary<int, int> SkillRankCost;

	public static readonly int MAX_LEVEL;

	public static Dictionary<int, int> LevelXPAggregatedCost;

	public static bool CanBuySomeSkillWithSkillPoints()
	{
		return false;
	}

	public static int GetSkillPointsForLevel(int level)
	{
		return 0;
	}

	public static bool IsSkillUpgradeable(Skill skill)
	{
		return false;
	}

	public static string GetWhySkillCantBeUpgraded(Skill skill)
	{
		return null;
	}

	public static int SkillPointsLeftOnCreation()
	{
		return 0;
	}

	private static Dictionary<int, int> CalculateRankCosts()
	{
		return null;
	}

	private static int CalculateMaxLevel()
	{
		return 0;
	}

	private static int GetCostForRank(int rank)
	{
		return 0;
	}

	private static Dictionary<int, int> CalculateAggregatedLevelXPCosts()
	{
		return null;
	}

	public static int GetCostForLevel(int level)
	{
		return 0;
	}

	public static Modifier GetLevelingSkillRank(int amount = 1)
	{
		return null;
	}

	public static Modifier GetCharCreationSkillRank()
	{
		return null;
	}

	public static bool UpgradeSkill(CharacterSheet character, SkillType skill)
	{
		return false;
	}
}
