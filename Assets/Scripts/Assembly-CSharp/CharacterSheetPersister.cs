using System;
using System.Collections.Generic;
using System.Reflection;
using Sunshine.Metric;

public static class CharacterSheetPersister
{
	public class CharacterSheetState
	{
		public Ability intellect;

		public Ability psyche;

		public Ability fysique;

		public Ability motorics;

		public Skill logic;

		public Skill encyclopedia;

		public Skill rhetoric;

		public Skill drama;

		public Skill conceptualization;

		public Skill visualCalculus;

		public Skill volition;

		public Skill inlandEmpire;

		public Skill empathy;

		public Skill authority;

		public Skill suggestion;

		public Skill espritDeCorps;

		public Skill physicalInstrument;

		public Skill electrochemistry;

		public Skill endurance;

		public Skill halfLight;

		public Skill painThreshold;

		public Skill shivers;

		public Skill handEyeCoordination;

		public Skill perception;

		public Skill reaction;

		public Skill savoirFaire;

		public Skill interfacing;

		public Skill composure;

		public List<string> gainedThoughts;

		public List<string> forgottenThoughts;

		public List<string> cookingThoughts;

		public List<string> fixedThoughts;

		public List<string> gainedItems;

		public List<string> equippedItems;

		public Dictionary<SkillType, List<ModifierState>> SkillModifierCauseMap;

		public Dictionary<AbilityType, List<ModifierState>> AbilityModifierCauseMap;

		public string selectedPanelName;
	}

	public class ModifierState
	{
		public ModifierType type;

		public int amount;

		public string explanation;

		public SkillType skillType;

		public ModifierCauseHolder modifierCause;

		public ModifierState(ModifierType type, int amount, string explanation, SkillType skillType, ModifierCauseHolder modifierCause)
		{
		}
	}

	public static CharacterSheetState Serialize()
	{
		return null;
	}

	private static void ConvertSkillsAndAbilities(CharacterSheetState state)
	{
	}

	private static void CloneSkillOrAbilityAndClearModifierCause(CharacterSheetState state, FieldInfo charsheetField, FieldInfo persistenceField)
	{
	}

	private static ModifierState ConvertModifierToModifierState(Modifier modifier)
	{
		return null;
	}

	private static void AddThoughtsAndItems(CharacterSheetState state)
	{
	}

	public static void Deserialize(CharacterSheetState state)
	{
	}

	public static void DeserializeSelectedObject(CharacterSheetState state)
	{
	}

	private static void DeserializeCharacterSheet(CharacterSheetState state)
	{
	}

	private static void DeserializeModifiers(CharacterSheetState state, Modifiable modifiable)
	{
	}

	private static void DeserializeItemsAndThoughts(CharacterSheetState state)
	{
	}

	private static void ApplyEffects(CharacterEffect[] effects, ModifierType type, IModifierCause cause)
	{
	}

	private static void AddItemOrThoughtToListByName<T>(string name, ICollection<T> list, Func<string, T> getByName)
	{
	}

	private static bool ThoughtEffectShouldPersist(CharacterEffect effect)
	{
		return false;
	}
}
