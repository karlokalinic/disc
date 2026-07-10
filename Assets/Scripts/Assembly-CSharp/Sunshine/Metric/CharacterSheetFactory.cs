using UnityEngine;
using Voidforge;

namespace Sunshine.Metric
{
	public class CharacterSheetFactory : SingletonComponent<CharacterSheetFactory>
	{
		public SunshineCharacterTemplate testArchetype;

		public ThoughtCabinetProject thcProject;

		protected CharacterSheet lastSheet;

		public CharacterSheet CreateCharacter(SunshineCharacterTemplate prototype, GameObject target)
		{
			return null;
		}

		public static CharacterSheet GetOrCreateComponent(GameObject target)
		{
			return null;
		}

		protected void TextCharacter()
		{
		}

		protected void TestTHCAdd()
		{
		}

		protected void TestTHCRemove()
		{
		}

		protected void TestTHCFix()
		{
		}

		public static void RollAbilities(CharacterSheet targetSheet, int allowedTotal)
		{
		}

		public static void CleanAbilities(CharacterSheet targetSheet)
		{
		}

		protected void TransferRolledAbilities(SunshineCharacterTemplate prototype, CharacterSheet targetSheet)
		{
		}

		protected static void TransferRolledAbility(int baseAbility, Ability ability)
		{
		}

		protected void TransferLeveledSkills(SunshineCharacterTemplate p, CharacterSheet targetSheet)
		{
		}

		public static void TransferLeveledSkill(int baseSkill, Skill skill)
		{
		}

		public static void SetSignatureSkill(CharacterSheet character, SkillType skill)
		{
		}

		public static void RemoveSignatureSkill(CharacterSheet character, SkillType skill)
		{
		}
	}
}
