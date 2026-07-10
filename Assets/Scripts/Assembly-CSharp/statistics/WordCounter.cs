using System.Collections.Generic;
using System.IO;
using PixelCrushers.DialogueSystem;

namespace statistics
{
	public static class WordCounter
	{
		private class Counter
		{
			public int nrOfConversations;

			public int nrOfDialogueEntries;

			public long nrOfWords;
		}

		private const string STATISTICS_FILE_NAME = "WordCounter";

		private const string STATISTICS_DETAILS_FILE_NAME = "WordCounter_Details";

		private static Counter newCounter;

		private static Dictionary<ConversationType, Counter> newCounterByType;

		private static Dictionary<ConversationType, SortedDictionary<string, long>> wordsByConversation;

		private static Dictionary<string, SortedDictionary<string, long>> wordsByDialogue;

		public static void CountEm(DialogueDatabase ntwtfDD)
		{
		}

		private static void CountDialogues(DialogueDatabase ntwtfDD)
		{
		}

		private static void CountConversation(PixelCrushers.DialogueSystem.Conversation ddConversation, Counter counter, Dictionary<ConversationType, Counter> counterByType)
		{
		}

		private static void CountEntities(DialogueDatabase ntwtfDD)
		{
		}

		private static void AddToDictionaryWithSuffix(SortedDictionary<string, long> dictionary, string key, long value)
		{
		}

		private static int CountWords(PixelCrushers.DialogueSystem.Conversation ddConversation)
		{
			return 0;
		}

		private static int CountWords(PixelCrushers.DialogueSystem.DialogueEntry dialogueEntry)
		{
			return 0;
		}

		private static int CountWords(string text)
		{
			return 0;
		}

		private static void WriteToDetailedToFile()
		{
		}

		private static void WriteToFile(DialogueDatabase ntwtfDD)
		{
		}

		private static void WriteCounter(StreamWriter file, Counter counter)
		{
		}
	}
}
