using Sunshine.Metric;
using UnityEngine.Events;

namespace TwitchIntegration
{
	public class TwitchMeditation
	{
		public class TwitchCause : IModifierCause
		{
			private bool isBuff;

			public TwitchCause(bool isBuff)
			{
			}

			string IModifierCause.GetDisplayName()
			{
				return null;
			}
		}

		private static TwitchMeditation _instance;

		private AbilityType buff;

		private AbilityType debuff;

		private CharacterBuff charBuff;

		private CharacterEffect charBuffEffect;

		private CharacterBuff charDebuff;

		private CharacterEffect charDebuffEffect;

		private UnityEvent onBuffStarted;

		private static TwitchMeditation Instance => null;

		public static UnityEvent OnBuffStarted => null;

		public static void SetMeditationResult(string buff, string debuff)
		{
		}

		internal static void InitializeBuffs(CharacterBuff buff, CharacterEffect buffEffect, CharacterBuff debuff, CharacterEffect debuffEffect)
		{
		}

		public static AbilityType StringToAbility(string abilityString)
		{
			return default(AbilityType);
		}

		public static void ClearMeditationEffect()
		{
		}
	}
}
