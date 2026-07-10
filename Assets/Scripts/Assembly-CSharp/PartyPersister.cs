public static class PartyPersister
{
	public class PartyState
	{
		public bool isKimInParty;

		public bool isKimLeftOutside;

		public bool isKimAbandoned;

		public bool isKimAwayUpToMorning;

		public bool isKimSleepingInHisRoom;

		public bool isCunoInParty;

		public bool isCunoLeftOutside;

		public bool isCunoAbandoned;

		public bool isKimSayingGoodMorning;

		public int sleepLocation;

		public int waitLocation;

		public int cunoWaitLocation;

		public int timeSinceKimWentSleepingInHisRoom;

		public int kimLastArrivalLocation;

		public int cunoLastArrivalLocation;

		public bool hasHangover;
	}

	public static PartyState Serialize()
	{
		return null;
	}

	public static void Deserialize(PartyState partyState)
	{
	}

	public static void PlacePartyAfterLoading()
	{
	}
}
