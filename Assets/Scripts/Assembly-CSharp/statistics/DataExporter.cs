using System;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;

namespace statistics
{
	[CreateAssetMenu]
	public class DataExporter : ScriptableObject
	{
		public enum CATEGORY_GROUP
		{
			DIALOGUE = 0,
			INTERACTABLE = 1,
			JOURNAL = 2,
			VALIDATION = 3
		}

		public class StatisticsAction
		{
			public bool IsActive;

			public Action<DialogueDatabase> Action;
		}

		public static class StatisticsCategories
		{
			public const string DIALOGUE = "Dialogue";

			public const string DIALOGUE_SANITY = "Dialogue sanity";

			public const string DIALOGUE_GRAPH = "Dialogue graph";

			public const string WORD_COUNTER = "Word counter";

			public const string XML_PARSER = "XML parser";

			public const string ITEMS = "Items";

			public const string INTERACTABLES = "Interactables";

			public const string VARIABLES = "Variables";

			public const string TASKS = "Tasks";

			public const string JOURNAL = "Journal";

			public const string DOUBLE_BASICS = "Double Basic Entities";

			public const string DOORS = "Doors locked in articy";

			public const string ORB_CAMERA = "Dialogue orb Camera Markers";

			public const string TASK_XP = "Tasks XP";

			public static Dictionary<CATEGORY_GROUP, Dictionary<string, StatisticsAction>> StatisticTypes;
		}

		public enum FILE_CATEGORY
		{
			STATISTICS = 0,
			ERROR = 1
		}

		public const string DIRECTORY_NAME = "Statistics";

		private const string ERROR_DIRECTORY_NAME = "Statistics_Errors";

		public const string FILE_NAME_SUFFIX = ".json";

		public static Dictionary<int, string> actorMap;

		public DialogueDatabase ntwtfDD;

		public void CalculateStatistics()
		{
		}

		private void InitializeHelperDatasets(DialogueDatabase ntwtfDD)
		{
		}

		private void DoStatistics(DialogueDatabase ntwtfDD)
		{
		}

		private static string GetStatisticsDirectory()
		{
			return null;
		}

		private static string GetErrorsDirectory()
		{
			return null;
		}

		public static string GetSavePath(string fileName, string extension, FILE_CATEGORY fileCategory)
		{
			return null;
		}

		public static void CreateDirectories()
		{
		}

		private void GenerateActorMap(DialogueDatabase ntwtfDD)
		{
		}
	}
}
