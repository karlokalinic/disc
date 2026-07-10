public static class SunshineClockTimePersister
{
	public class SunshineClockTimeHolder
	{
		public PersistenceClockTime time;

		public PersistenceClockTime timeOverride;
	}

	public class PersistenceClockTime
	{
		public int dayCounter;

		public int realDayCounter;

		public int dayMinutes;

		public int seconds;
	}

	public static SunshineClockTimeHolder Serialize()
	{
		return null;
	}

	public static PersistenceClockTime Convert(SunshineClockTime time)
	{
		return null;
	}

	public static void Deserialize(SunshineClockTimeHolder sunshineClockHolder)
	{
	}

	public static SunshineClockTime Convert(PersistenceClockTime time)
	{
		return null;
	}
}
