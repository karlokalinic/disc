using PixelCrushers.DialogueSystem.ChatMapper;

namespace PixelCrushers.DialogueSystem
{
	public static class ChatMapperToDialogueDatabase
	{
		public static DialogueDatabase ConvertToDialogueDatabase(ChatMapperProject chatMapperProject)
		{
			return null;
		}

		private static void ConvertProjectAttributes(ChatMapperProject chatMapperProject, DialogueDatabase database)
		{
		}

		private static void ConvertActors(ChatMapperProject chatMapperProject, DialogueDatabase database)
		{
		}

		private static void ConvertItems(ChatMapperProject chatMapperProject, DialogueDatabase database)
		{
		}

		private static void ConvertLocations(ChatMapperProject chatMapperProject, DialogueDatabase database)
		{
		}

		private static void ConvertVariables(ChatMapperProject chatMapperProject, DialogueDatabase database)
		{
		}

		private static void ConvertConversations(ChatMapperProject chatMapperProject, DialogueDatabase database)
		{
		}

		private static void SetConversationStartCutsceneToNone(Conversation conversation)
		{
		}

		public static void FixConversationsLinkedToFirstEntry(DialogueDatabase database, bool resetNodePositions = false)
		{
		}

		public static void ConvertAudioFilesToSequences(Conversation conversation)
		{
		}
	}
}
