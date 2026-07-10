using LocalizationCustomSystem;
using UnityEngine;

namespace Sunshine.Metric
{
	public class CharacterEffect : MonoBehaviour
	{
		public EffectType effect;

		public bool intrinsic;

		public AbilityType abilityType;

		public SkillType skillType;

		public int parameter;

		private static EffectType[] instantaneousEffects;

		public string stringParameter;

		public TranslationString stringParameterTerm;

		public string quipLine;

		public TranslationString quipLineTerm;

		private string Sign => null;

		public Modifier GetModifier(ModifierType type, IModifierCause modifierCause)
		{
			return null;
		}

		public static bool IsInstantaneous(EffectType type)
		{
			return false;
		}

		public bool Apply(CharacterSheet ch, ModifierType type, IModifierCause modifierCause)
		{
			return false;
		}

		public void Remove(CharacterSheet ch, ModifierType type, IModifierCause modifierCause)
		{
		}

		public string EffectFullName()
		{
			return null;
		}

		public string EffectName(bool editor = false, bool withColor = false, bool revertTagsForRTL = false, bool revertFormatForRTL = true)
		{
			return null;
		}

		private static string ReverseRTLFormat(string format)
		{
			return null;
		}

		private static string GetColorFormat(bool revertTagsForRTL = false)
		{
			return null;
		}

		private void OnValidate()
		{
		}
	}
}
