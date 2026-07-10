using System.Collections.Generic;
using System.IO;
using PixelCrushers.DialogueSystem;
using Sunshine.Metric;

namespace statistics
{
	public static class DialogueSanityChecks
	{
		private class CheckStatistics
		{
			public NodeType CheckType;

			public string FlagName;

			public int Difficulty;

			public SkillType SkillType;

			public Dictionary<string, List<int>> Modifiers;

			public string Title;

			public CheckStatistics(PixelCrushers.DialogueSystem.DialogueEntry ddDialogueEntry, NodeType checkType, string title)
			{
			}
		}

		private const string CONFLUENCE_FILE_NAME = "DialogueStats";

		private static SortedDictionary<string, int> duplicateDialogueTitles;

		private static List<string> functionModifierConditions;

		private static Dictionary<string, List<CheckStatistics>> checkStatisticsMap;

		private static Dictionary<int, int> conversationLinkDestinations;

		private static List<string> actorsWithWhiteChecks;

		private static List<string> generalErrors;

		public static void CollectStatistics(DialogueDatabase ntwtfDD)
		{
		}

		private static void AnalyzeDialogues(DialogueDatabase ntwtfDD)
		{
		}

		private static void AnalyzeConversation(DialogueDatabase ntwtfDD, PixelCrushers.DialogueSystem.Conversation ddConversation)
		{
		}

		private static DialogueEntry AnalyzeDialogueNode(DialogueDatabase ntwtfDD, PixelCrushers.DialogueSystem.Conversation ddConversation, PixelCrushers.DialogueSystem.DialogueEntry ddDialogueEntry)
		{
			return null;
		}

		private static void CollectModifierPreconditions(Dictionary<string, string> dialogueEntryFields)
		{
		}

		private static void GenerateDialogueStatisticsForConfluence()
		{
		}

		private static void OutputDialogueStatisticsByType(StreamWriter file, ConversationType conversationType, bool checkForMultiple)
		{
		}

		private static void PrintUnityDialoguesNotFoundInArticy(StreamWriter file)
		{
		}

		private static void CompareAndPrintCheckStatistics(StreamWriter file)
		{
		}

		private static void WriteValueToFile(StreamWriter file, string value)
		{
		}
	}
}
