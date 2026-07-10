using System.Collections.Generic;
using Sunshine.Metric;

public static class FailedWhiteChecks
{
	private static string IS_KIM_HERE_FUNCTION;

	private static string CHECK_EQUIPED_FUNCTION;

	public static string CHECK_ITEM_FUNCTION;

	private static string IS_THC_COOKING_OR_FIXED_FUNCTION;

	private static string IS_THC_FIXED_FUNCTION;

	private static string IS_THC_PRESENT_FUNCTION;

	private static string IS_EVENING_FUNCTION;

	public static List<string> RegisteredLuaFunctions;

	private static bool listenersRegistered;

	public static Dictionary<string, Dictionary<string, List<WhiteCheck>>> ReopenedWhiteChecksByActorName;

	public static Dictionary<string, WhiteCheck> WhiteCheckCache;

	public static Dictionary<string, WhiteCheck> SeenWhiteCheckCache;

	public static Dictionary<SkillType, List<string>> ChecksBySkill;

	public static Dictionary<string, List<string>> ChecksByVariable;

	public static void ResetForNewGame()
	{
	}

	public static void RemoveFromAllCaches(string flagName, string actorName)
	{
	}

	private static void RemoveFromCache<T>(T firstLevelKey, string secondLevelKey, Dictionary<T, List<string>> dictionary)
	{
	}

	private static void RemoveFromReopened(string actorName, string flagName)
	{
	}

	public static void AddToCaches(WhiteCheck whiteCheck)
	{
	}

	private static void RemoveFromSeenCache(string whiteCheckFlagName)
	{
	}

	public static void AddToSeenCache(WhiteCheck whiteCheck)
	{
	}

	private static void RegisterListeners()
	{
	}

	private static void OnSkillValueChanged()
	{
	}

	public static void OnModifiableConditionChanged(string variableName)
	{
	}

	private static void CheckChecksForReDoability(List<string> whiteCheckList)
	{
	}

	private static void AddWhiteCheckToRetryCache(WhiteCheck whiteCheck)
	{
	}

	public static bool IsFailedWhiteCheckPossible(WhiteCheck whiteCheck)
	{
		return false;
	}

	public static void ReopenAll()
	{
	}

	public static void ForceReopenBySkill(SkillType skill)
	{
	}

	public static void ReopenBySkill(SkillType skill)
	{
	}

	public static void ReopenByAbility(AbilityType ability)
	{
	}
}
