using System;

namespace Sunshine.Metric
{
	[Serializable]
	public class Modifier
	{
		public ModifierType type;

		public SkillType skillType;

		private int _amount;

		public Func<string> explanation;

		public IModifierCause modifierCause;

		public static string AMOUNT_STRING_FORMAT => null;

		public static string DISPLAY_LABLE_ITEM => null;

		public static string DISPLAY_LABLE_THOUGHTS => null;

		public static string DISPLAY_BASE_FOR_ABILITY => null;

		private static string BASE_ABILITY_EXPLANATION => null;

		private static string DAMAGE_EXPLANATION => null;

		private static string SKILL_POINTS_EXPLANATION => null;

		private static string RANK_FROM_CHARACTER_CREATION_EXPLANATION => null;

		private static string RANK_FORMAT_CHARACTER_CREATION_EXPLANATION => null;

		private static string SIGNATURE_SKILL_EXPLANATION => null;

		public int Amount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool Intrinsic => false;

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool Equals(Modifier m)
		{
			return false;
		}

		public Modifier(ModifierType type, int amount, Func<string> explanation, IModifierCause modifierCause = null, SkillType skillType = SkillType.NONE)
		{
		}

		public Modifier(ModifierType type, int amount, IModifierCause modifierCause = null, SkillType skillType = SkillType.NONE)
		{
		}

		private void InitializeExplanation(Func<string> explanation)
		{
		}

		private int GetAmount()
		{
			return 0;
		}

		public int GetAmountForPersistence()
		{
			return 0;
		}

		public string GetDisplayValueForModifier()
		{
			return null;
		}

		public string GetDisplayLabel()
		{
			return null;
		}

		public string GetDisplayLabelWithBase()
		{
			return null;
		}
	}
}
