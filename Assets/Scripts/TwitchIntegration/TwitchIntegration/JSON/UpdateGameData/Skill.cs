using System;

namespace TwitchIntegration.JSON.UpdateGameData
{
	[Serializable]
	public class Skill
	{
		public string typeName;

		public int totalValue;

		public int baseValue;

		public int maximumValue;

		public int learnedSkill;

		public int bonusFromItems;

		public int bonusFromThoughts;

		public int bonusFromDamage;

		public bool isSignatureSkill;

		public int signatureSkillBonus;

		internal static Skill GetExample()
		{
			return null;
		}

		public bool Equals(Skill obj)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}
	}
}
