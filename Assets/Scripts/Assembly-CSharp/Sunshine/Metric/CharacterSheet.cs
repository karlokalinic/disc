using UnityEngine;

namespace Sunshine.Metric
{
	public class CharacterSheet : MonoBehaviour
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

		public CharacterThoughts thoughts;

		public CharacterItems items;

		public bool dirty;

		private static string CHARSHEET_ROLLED_THIS_EXPLANATION => null;

		public bool IsPlayer => false;

		public Ability[] abilities { get; private set; }

		public Skill[] skills { get; private set; }

		public void Awake()
		{
		}

		private void Initialize(bool force = false)
		{
		}

		public void RepopulateLists()
		{
		}

		private void MakeStats()
		{
		}

		private void MakeSkills()
		{
		}

		private void MakeChar()
		{
		}

		public void Clean()
		{
		}

		public void Recalc()
		{
		}

		private void RecalcLazy()
		{
		}

		protected void Update()
		{
		}

		public Ability GetAbility(SkillType skillType)
		{
			return null;
		}

		public Ability GetAbility(AbilityType abilityType)
		{
			return null;
		}

		public int GetAbilityValue(AbilityType abilityType)
		{
			return 0;
		}

		public int GetAbilityValue(SkillType skillType)
		{
			return 0;
		}

		public bool HaveSignatureSkill()
		{
			return false;
		}

		public Skill GetSignatureSkill()
		{
			return null;
		}

		public Skill GetSkill(SkillType type)
		{
			return null;
		}

		public int GetSkillValue(SkillType skillType)
		{
			return 0;
		}

		public int GetSkillBonus(SkillType skillType)
		{
			return 0;
		}

		private string GetStatDisplay(AbilityType abilityType)
		{
			return null;
		}

		private string GetSkillDisplay(SkillType skillType)
		{
			return null;
		}
	}
}
