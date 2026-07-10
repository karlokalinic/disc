using UnityEngine;

namespace Sunshine
{
	[CreateAssetMenu]
	public class ThoughtSlotStateManager : ScriptableObject
	{
		[SerializeField]
		private ThoughtSlotStateObject[] _configurations;

		[SerializeField]
		private ThoughtSlotStateObject _defaultConfiguration;

		public ThoughtSlotStateObject GetConfiguration(ThoughtSlot.SlotState slotType)
		{
			return null;
		}
	}
}
