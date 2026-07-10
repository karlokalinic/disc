using Sunshine;
using Voidforge;

public static class ThoughtCabinetViewPersister
{
	public class ThoughtCabinetViewState
	{
		public Tuple<ThoughtSlot.SlotState, string>[] slotStates;

		public string selectedProjectName;
	}

	public static ThoughtCabinetViewState Serialize()
	{
		return null;
	}

	private static Tuple<ThoughtSlot.SlotState, string>[] GetSlotStatuses()
	{
		return null;
	}

	public static void Deserialize(ThoughtCabinetViewState thoughtCabinetViewState)
	{
	}
}
