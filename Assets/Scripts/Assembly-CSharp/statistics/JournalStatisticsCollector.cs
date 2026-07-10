using System.Collections.Generic;
using PixelCrushers.DialogueSystem;

namespace statistics
{
	public class JournalStatisticsCollector
	{
		private class Task
		{
			public string title;

			public string displayCondition;

			public string doneCondition;

			public List<string> gainedInDialogue;

			public List<string> endedInDialogue;

			public Task(string title, string displayCondition, string doneCondition)
			{
			}
		}

		private const string FILE_NAME_PREFIX = "Journal";

		private const string CONFLUENCE_FILE_NAME = "JournalStats";

		private static List<Task> tasks;

		private static Dictionary<string, List<string>> gainedTasks;

		private static Dictionary<string, List<string>> finishedTasks;

		private static List<string> notGainableTasks;

		private static List<string> notCompletableTasks;

		public static void CollectStatistics(DialogueDatabase ntwtfDD)
		{
		}

		private static void ClearAndInit(DialogueDatabase ntwtfDD)
		{
		}

		private static void CollectReferences(DialogueDatabase ntwtfDD)
		{
		}

		private static void ConnectData()
		{
		}

		private static void PrintJournalErrors()
		{
		}
	}
}
