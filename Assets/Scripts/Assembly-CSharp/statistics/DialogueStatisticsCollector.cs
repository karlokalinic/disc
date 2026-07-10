using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;

namespace statistics
{
	public static class DialogueStatisticsCollector
	{
		private const string FILE_NAME_PREFIX = "Dialogue";

		public static SortedDictionary<string, Conversation> dialogueMap;

		public static List<string> unknownDialogueTitles;

		public static List<string> ORB_LUA_FUNCTIONS;

		public static void CollectStatistics(DialogueDatabase ntwtfDD)
		{
		}

		private static void AddFilterValues(Dialogue dialogue)
		{
		}

		private static void AnalyzeDialogues(DialogueDatabase ntwtfDD)
		{
		}

		private static Conversation AnalyzeConversation(PixelCrushers.DialogueSystem.Conversation ddConversation)
		{
			return null;
		}

		public static ConversationType GetConversationType(PixelCrushers.DialogueSystem.Conversation ddConversation)
		{
			return default(ConversationType);
		}

		private static DialogueEntry AnalyzeDialogueNode(PixelCrushers.DialogueSystem.DialogueEntry ddDialogueEntry, Conversation conversation)
		{
			return null;
		}

		public static NodeType GetCheckType(PixelCrushers.DialogueSystem.DialogueEntry ddDialogueEntry)
		{
			return default(NodeType);
		}

		private static void CheckOrbsInUserScript(DialogueDatabase ntwtfDD)
		{
		}

		private static void CheckForOrbInUserScript(string userScript, string conversationTitle, string dialogueEntryTitle)
		{
		}

		private static void CheckDialoguesInScenes()
		{
		}

		private static void FindConversationsOnComponent(GameObject gameObject, string sceneName)
		{
		}

		private static void AddHardcodedDialogues()
		{
		}

		private static void CheckItemDialogues(DialogueDatabase ntwtfDD)
		{
		}

		private static void AddLocationToDialogueMap(string dialogueTitle, string location)
		{
		}
	}
}
