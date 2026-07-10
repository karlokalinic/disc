using System.Collections.Generic;
using System.Text;
using Sunshine.Unseen;

public static class SunshinePersistenceJsonSerializer
{
	private class PreloadJsonData
	{
		public string areaId;

		public PartyPersister.PartyState partyState;

		public Dictionary<string, Zone.Status> fowUnrevealersStatusCache;
	}

	private class JsonData
	{
		public VariousItemsPersister.VariousItemsHolder variousItemsHolder;

		public SunshineClockTimePersister.SunshineClockTimeHolder sunshineClockTimeHolder;

		public CharacterSheetPersister.CharacterSheetState characterSheet;

		public PlayerCharacterPersister.PlayerCharacterState playerCharacter;

		public HudStatePersister.HudState hudState;

		public JournalPersister.JournalAquisitionTimes aquiredJournalTasks;

		public FailedWhiteChecksPersister.FailedWhiteChecksHolder failedWhiteChecksHolder;

		public WeatherPersister.WeatherState weatherState;

		public InventoryPersister.InventoryState inventoryState;

		public ThoughtCabinetPersister.ThoughtCabinetState thoughtCabinetState;

		public ContainerSourcePersister.ContainerSourceState containerSourceState;

		public KubujussPersister.KubujussState kubujussState;

		public GameModePersister.GameModeState gameModeState;
	}

	public static void Serialize(string fileNamePrefix)
	{
	}

	public static void Serialize(ref StringBuilder data1, ref StringBuilder data2)
	{
	}

	public static string PreloadDeserialize(string fileNamePrefix)
	{
		return null;
	}

	public static string PreloadDeserializeFromMemory(string dataString)
	{
		return null;
	}

	public static void Deserialize(string fileNamePrefix)
	{
	}

	public static void DeserializeFromMemory(string dataString)
	{
	}
}
