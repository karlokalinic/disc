using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using Sunshine.Metric;
using UnityEngine;

public static class ArticyBridge
{
	public const string ARTICY_ID_FIELD = "Articy Id";

	public const string ARTICY_NPC_COLOR_FIELD = "color";

	public const string EMPTY_ARTICY_REFERENCE_ID = "0x0000000000000000";

	public const string BRANCH_MARKER_NAME = "BRANCH MARKER";

	public const string DAMAGED_LEDGER = "ledger_damaged";

	public const string MAP_OF_MARTINAISE = "map_of_martinaise";

	public static readonly List<string> LEDGER_NAMES;

	public static string[] COR;

	public static string[] INT;

	public static string[] MOT;

	public static string[] FYS;

	public static Difficulty[] ArticyDifficultyIdToDifficulty;

	public static SkillType[] articyOrbSkillToSunshineOrbSkill;

	public static Dictionary<string, string> ARTICY_ID_TO_SKILL_NAME;

	public static Dictionary<string, SkillType> ARTICY_ID_TO_SKILL_TYPE;

	private static Dictionary<string, Asset> articyIdToAssetCache;

	private static bool isAssetCacheInitialized;

	private static Dictionary<string, string> InitializeArticyIdToSkillName()
	{
		return null;
	}

	private static Dictionary<string, SkillType> InitializeArticyIdToSkillType()
	{
		return null;
	}

	public static bool IsPaperwork(string id)
	{
		return false;
	}

	public static bool IsYou(string id)
	{
		return false;
	}

	public static bool IsYou(int id)
	{
		return false;
	}

	public static string GetBranchId(DialogueDatabase db)
	{
		return null;
	}

	public static string SkillIdToName(string id)
	{
		return null;
	}

	public static string SkillIdToNameLocalized(string id)
	{
		return null;
	}

	public static SkillType ActorIdToSkillType(int ActorID)
	{
		return default(SkillType);
	}

	public static SkillType SkillIdToSkillType(string articyId)
	{
		return default(SkillType);
	}

	public static SkillType ArticyOrbSkillToSunshineOrbSkill(int id)
	{
		return default(SkillType);
	}

	public static SkillType GetSkillTypeFromConversation(Conversation converstaion)
	{
		return default(SkillType);
	}

	public static int DifficultyIdToThreshold(int id)
	{
		return 0;
	}

	public static Color ColorDropDownToColor(ArticyColorDropdown id)
	{
		return default(Color);
	}

	public static Actor GetActor(string actorName)
	{
		return null;
	}

	public static Asset GetAssetByArticyId(string articyKey)
	{
		return null;
	}

	private static void InitializeArticyIdToAsset()
	{
	}

	public static string GetVariableFromLuaExpression(string variable)
	{
		return null;
	}
}
