using System.Collections.Generic;
using PixelCrushers.DialogueSystem;

namespace statistics
{
	public static class TaskStatisticsCollector
	{
		private const string FILE_NAME = "Tasks";

		private static readonly List<string> xpFunctions;

		private static SortedDictionary<string, SortedDictionary<string, List<string>>> tasks;

		public static void CollectStatistics(DialogueDatabase ntwtfDD)
		{
		}

		private static void ParseXPFunction(string userScript, string xpFunction, string location)
		{
		}
	}
}
