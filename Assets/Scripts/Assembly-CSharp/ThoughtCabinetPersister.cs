using System.Collections.Generic;

public static class ThoughtCabinetPersister
{
	public class ThoughtCabinetState
	{
		public List<ThoughtCabinetProjectPersister.THCPState> thoughtListState;

		public ThoughtCabinetViewPersister.ThoughtCabinetViewState thoughtCabinetViewState;
	}

	public static ThoughtCabinetState Serialize()
	{
		return null;
	}

	public static void Deserialize(ThoughtCabinetState thoughtCabinetState)
	{
	}
}
