using UnityEngine;

namespace Sunshine.Metric
{
	public class CharacterBuff : MonoBehaviour
	{
		public ModifierType cause;

		public CharacterEffect[] effects;

		public Duration duration;

		public void ApplyBuff(CharacterSheet ch, IModifierCause causeObject)
		{
		}

		public void RemoveBuff(CharacterSheet ch, IModifierCause causeObject)
		{
		}
	}
}
