using System;
using System.Collections.Generic;
using Voidforge;

namespace Sunshine.Metric
{
	public class PlayerCharacterHealingPools
	{
		public const string LESS_HEALTH_ITEM = "nosaphed";

		public const string MORE_HEALTH_ITEM = "drouamine";

		public const string LESS_MORALE_ITEM = "magnesium";

		public const string MORE_MORALE_ITEM = "hypnogamma";

		public static readonly Dictionary<string, Voidforge.Tuple<SkillType, int>> HEALING_ITEMS;

		public Dictionary<SkillType, Action> onNrOfChargesChangeActions;

		private readonly Dictionary<SkillType, int> healingCharges;

		public static string GetHealingItemTooltipDescription(string name, bool revertTagsForRTL = false)
		{
			return null;
		}

		public bool PickUpHealingItem(string name)
		{
			return false;
		}

		private void OnChargesChanged(SkillType healingType)
		{
		}

		public bool HasHealingChargesForSkill(SkillType skillType)
		{
			return false;
		}

		public int GetHealingChargetsForSkill(SkillType skillType)
		{
			return 0;
		}

		public void UseHealingCharge(SkillType skillType)
		{
		}

		public void RestoreHealingPoolsFromPersistence(int endurancePool, int volitionPool)
		{
		}
	}
}
