using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using Voidforge;

namespace statistics
{
	public static class DialogueGraph
	{
		public class Node
		{
			public string title;

			public int id;

			public int conversationId;

			public string preCondition;

			public string postCondition;

			public Dictionary<int, List<int>> parents;

			public Dictionary<int, List<int>> children;

			public Node(string title, int id, int conversationId, string preCondition, string postCondition)
			{
			}
		}

		public const string DIALOGUE_ARTICY_ID = "0x01000004000112B3";

		private static SortedDictionary<string, List<string>> preconditionDialogueMap;

		private static SortedDictionary<string, List<string>> postconditionDialogueMap;

		public static SortedDictionary<int, SortedDictionary<int, Node>> dialogueEntries;

		public static Dictionary<string, List<Tuple<int, int>>> ArticyIdMap;

		private static DialogueDatabase ntwtfDD;

		public static void CollectStatistics(DialogueDatabase ntwtfDD)
		{
		}

		private static void ClearAndInit(DialogueDatabase ntwtfDD)
		{
		}

		private static void CollectReferences(DialogueDatabase ntwtfDD)
		{
		}

		private static void RecursiveSearch(PixelCrushers.DialogueSystem.DialogueEntry entry, PixelCrushers.DialogueSystem.DialogueEntry parentEntry)
		{
		}

		public static void PrintData(List<string> preConditions, List<string> postConditions)
		{
		}

		private static string NormalizeConditions(string conditions)
		{
			return null;
		}
	}
}
