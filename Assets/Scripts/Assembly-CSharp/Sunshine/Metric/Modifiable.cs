using System;
using System.Collections.Generic;
using UnityEngine;

namespace Sunshine.Metric
{
	[Serializable]
	public class Modifiable
	{
		public bool dirty;

		public int value;

		public int valueWithoutPerceptionsSubSkills;

		[NonSerialized]
		public Dictionary<ModifierType, int> bonusOnlyValues;

		public int damageValue;

		public int maximumValue;

		public int calculatedAbility;

		public int rankValue;

		public bool hasAdvancement;

		public bool isSignature;

		[SerializeField]
		private List<Modifier> modifiers;

		private CharacterSheet characterSheet;

		public int bonusTotal => 0;

		public void Add(Modifier m)
		{
		}

		public void Remove(Modifier m)
		{
		}

		public Modifiable(CharacterSheet characterSheet)
		{
		}

		public virtual void Recalc(CharacterSheet ch)
		{
		}

		private void AddNonIntrinsicBonus(ModifierType modifierType, int amount)
		{
		}

		public virtual void DamageValue(int amount)
		{
		}

		public virtual int HealValue(int amount)
		{
			return 0;
		}

		public List<Modifier> GetModifierList()
		{
			return null;
		}

		public Modifier GetModifierOfType(ModifierType type)
		{
			return null;
		}

		public void SetModifiersFromPersistence(List<Modifier> persistedModifiers)
		{
		}

		public void ClearModifiersForPersistence()
		{
		}

		public void SetCharacterSheetFromPersistence(CharacterSheet characterSheet)
		{
		}

		public int GetSkillBonusFromModifiers(SkillType perceptionSubskill, ModifierType modifierType)
		{
			return 0;
		}
	}
}
