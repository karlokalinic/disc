using System.Collections.Generic;

public static class JournalPersister
{
	public class JournalAquisitionTimes
	{
		public Dictionary<string, SunshineClockTimePersister.PersistenceClockTime> TaskAquisitions;

		public Dictionary<string, SunshineClockTimePersister.PersistenceClockTime> TaskResolutions;

		public Dictionary<string, Dictionary<string, SunshineClockTimePersister.PersistenceClockTime>> SubtaskAquisitions;

		public Dictionary<string, bool> TaskNewStates;

		public HashSet<string> ChecksWithNotifications;

		public string LastActiveTask;

		public string LastDoneTask;

		public bool TasksTabNotifyIcon;

		public bool ChecksTabNotifyIcon;

		public bool ActiveTasksTabNotifyIcon;

		public bool DoneTasksTabNotifyIcon;

		public bool HudNotifyIcon;

		public bool wasChurchVisited;

		public bool wasFishingVillageVisited;

		public bool wasQuicktravelChurchDiscovered;

		public bool wasQuicktravelFishingVillageDiscovered;
	}

	public static JournalAquisitionTimes Serialize()
	{
		return null;
	}

	public static void Deserialize(JournalAquisitionTimes journalSavedData)
	{
	}
}
