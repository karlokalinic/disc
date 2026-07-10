using System;
using UnityEngine;

namespace Sunshine.Metric
{
	[Serializable]
	public class Skill : Modifiable
	{
		public SkillType skillType;

		public AbilityType abilityType;

		public static string[] actorSkillNames;

		public Skill(SkillType type, CharacterSheet characterSheet)
			: base(null)
		{
		}

		public string GetBonusDisplayWithoutPerception()
		{
			return null;
		}

		public string GetBonusDisplay()
		{
			return null;
		}

		protected void ApplyType()
		{
		}

		public static string GetActorSkillName(SkillType skillType)
		{
			return null;
		}

		public static string SkillTypeToLocalizedName(SkillType type, bool fixForRTL = true)
		{
			return null;
		}

		public static string SkillTypeToLocalizedNameToUpper(SkillType type)
		{
			return null;
		}

		public static string SkillTypeToHealthName(SkillType type)
		{
			return null;
		}

		public static Color SkillTypeToHealthColor(SkillType type)
		{
			return default(Color);
		}

		public static bool IsOrbitalSkill(SkillType skillType)
		{
			return false;
		}

		public static bool IsPerceptionSkill(SkillType skillType)
		{
			return false;
		}

		public static bool IsPerceptionSubSkill(SkillType skillType)
		{
			return false;
		}

		public static bool IsEnduranceSkill(SkillType skillType)
		{
			return false;
		}

		public static bool IsINTSkill(SkillType skillType)
		{
			return false;
		}

		public static bool IsPSYSkill(SkillType skillType)
		{
			return false;
		}

		public static bool IsFYSSkill(SkillType skillType)
		{
			return false;
		}

		public static bool IsMOTSkill(SkillType skillType)
		{
			return false;
		}

		public static Color GetColor(SkillType skillType)
		{
			return default(Color);
		}

		public static AbilityType GetAbility(SkillType skillType)
		{
			return default(AbilityType);
		}

		public static string GetSkillColorTaggedString(string inputString, bool reverseTags = false)
		{
			return null;
		}

		public static string GetFirstSkillNameFromString(string inputString)
		{
			return null;
		}
	}
}
