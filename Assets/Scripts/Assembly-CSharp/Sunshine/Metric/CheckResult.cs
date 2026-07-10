using System.Collections.Generic;
using UnityEngine;

namespace Sunshine.Metric
{
	public class CheckResult
	{
		public string explanation;

		public CheckType checkType;

		public SkillType skillType;

		public int abilityBase;

		public int skillBase;

		public List<CheckBonus> rollBonuses;

		public int die1;

		public int die2;

		public int baseTarget;

		public bool IsSuccess;

		public bool isLocked;

		public CheckForced forced;

		public bool IsPassiveType => false;

		public string difficulty => null;

		public List<CheckModifier> applicableTargetModifiers { get; private set; }

		public List<CheckModifier> allTargetModifiers { get; private set; }

		public int Total()
		{
			return 0;
		}

		public bool HasRoll()
		{
			return false;
		}

		public bool SixSix()
		{
			return false;
		}

		public bool Snakeyes()
		{
			return false;
		}

		public bool HasExplanation()
		{
			return false;
		}

		public string SkillName()
		{
			return null;
		}

		public string SkillNameToUpper()
		{
			return null;
		}

		public int SkillValue()
		{
			return 0;
		}

		public int CalcCheckBonus()
		{
			return 0;
		}

		public int SkillRank()
		{
			return 0;
		}

		public Color SkillColor()
		{
			return default(Color);
		}

		public static int CalcCheckBonusTotal(List<CheckBonus> list)
		{
			return 0;
		}

		public static int CalcCheckModifierTotal(List<CheckModifier> list)
		{
			return 0;
		}

		public AbilityType AbilityType()
		{
			return default(AbilityType);
		}

		public string AbilityName()
		{
			return null;
		}

		public float Probability()
		{
			return 0f;
		}

		public int TargetNumber()
		{
			return 0;
		}

		public string CheckText()
		{
			return null;
		}

		public CheckResult(CheckType type)
		{
		}

		public CheckResult(CheckType type, int firstDie, int secondDie)
		{
		}

		public void SetTargetModifiers(List<CheckModifier> checkModifiers)
		{
		}
	}
}
