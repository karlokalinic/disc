using System;
using UnityEngine;

namespace Sunshine.Metric
{
	[Serializable]
	public class Ability : Modifiable, IModifierCause
	{
		public AbilityType abilityType;

		public static string[] actorAbilityName;

		public Ability(AbilityType type, CharacterSheet characterSheet)
			: base(null)
		{
		}

		public static Color GetAbilityColor(AbilityType abilityType)
		{
			return default(Color);
		}

		public static string GetAbilityColorTaggedString(string inputString)
		{
			return null;
		}

		public static string GetAbilityName(AbilityType abilityType, bool fixForRTL = true)
		{
			return null;
		}

		public static string GetAbilityNameToUpper(AbilityType abilityType)
		{
			return null;
		}

		public static string GetAbilityShortcutName(AbilityType abilityType)
		{
			return null;
		}

		public static string GetActorAbilityName(AbilityType abilityType)
		{
			return null;
		}

		public string GetDisplayName()
		{
			return null;
		}
	}
}
