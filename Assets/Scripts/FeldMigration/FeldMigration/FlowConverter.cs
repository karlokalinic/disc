using System.Collections.Generic;
using PixelCrushers.DialogueSystem;

namespace FeldMigration
{
	public class FlowConverter
	{
		public enum ConversationType
		{
			Regular = 0,
			Interactable = 1,
			Orb = 2,
			Task = 3
		}

		private static Dictionary<string, string> interactableFieldsExportMap;

		private static Dictionary<string, string> orbFieldsExportMap;

		private static Dictionary<string, string> subtaskImportMap;

		private static Dictionary<string, string> taskFieldsExportMap;

		private static Dictionary<int, string> CheckTypeToStringDict;

		private static Dictionary<int, string> TaskRewardToStringDict;

		private static Dictionary<string, string> interactableFieldsImportMap;

		private static Dictionary<string, string> orbFieldsImportMap;

		private static Dictionary<string, string> taskFieldsImportMap;

		private const string ConditionFieldName = "Condition";

		private const string InstructionFieldName = "Instruction";

		private static HashSet<string> FieldsToImportIgnore;

		private static Dictionary<string, string> FlowToConversationFieldNameMap;

		private static HashSet<string> ExpressionsToIgnore;

		public static string identityInteractableFieldName => null;

		public static string checkTypeInteractableAdditionalFieldName => null;

		public static string identityOrbFieldName => null;

		public static string checkTypeOrbAdditionalFieldName => null;

		public static string identityTaskFieldName => null;

		public static string taskRewardTaskAdditionalFieldName => null;

		private static bool IsInteractableConversation(Conversation conversation)
		{
			return false;
		}

		private static void ApplyExportToInteractableTemplate(FeldCard feldCard, Conversation conversation)
		{
		}

		private static void AddAdditionalInteractableFields(FeldCard feldCard)
		{
		}

		private static bool IsOrbConversation(Conversation conversation)
		{
			return false;
		}

		private static void ApplyExportToOrbTemplate(FeldCard feldCard, Conversation conversation)
		{
		}

		private static void AddAdditionalOrbFields(FeldCard feldCard)
		{
		}

		private static bool IsTaskConversation(Conversation conversation)
		{
			return false;
		}

		private static void ApplyExportToTaskTemplate(FeldCard feldCard, Conversation conversation)
		{
		}

		private static void AddAdditionalTaskFields(FeldCard feldCard)
		{
		}

		private static GraphData CreateSubtask(string display_subtask, string subtask_title, string done_subtask, string cancel_subtask, bool timed_subtask)
		{
			return null;
		}

		public static void ApplyExportToTemplate(FeldCard feldCard, Conversation conversation)
		{
		}

		public static ConversationType GetConversationType(Conversation conversation)
		{
			return default(ConversationType);
		}

		public static FeldFlow ExportToFeld(Conversation conversation, string parentFlowId)
		{
			return null;
		}

		private static string GetCheckTypeString(string variable)
		{
			return null;
		}

		private static string GetTaskRewardString(string variable)
		{
			return null;
		}

		private static void PrepareImportInteractableCard(FeldCard feldCard)
		{
		}

		private static void ApplyImportInteractableTemplate(FeldCard feldCard, Conversation conversation)
		{
		}

		private static void PrepareImportOrbCard(FeldCard feldCard)
		{
		}

		private static void ApplyImportOrbTemplate(FeldCard feldCard, Conversation conversation)
		{
		}

		private static void PrepareImportTaskCard(FeldCard sourceCard)
		{
		}

		private static void ApplyImportTaskTemplate(FeldCard feldCard, Conversation conversation)
		{
		}

		public static void PrepareImportToTemplate(FeldCard feldCard)
		{
		}

		public static void ApplyImportToTemplate(FeldCard feldCard, Conversation conversation)
		{
		}

		public static ConversationType GetFlowTemplateType(FeldCard feldCard)
		{
			return default(ConversationType);
		}

		public static Conversation ToDialogueSystem(FeldFlow flow, FeldCard flowCard, int conversationID, Template template)
		{
			return null;
		}

		private static void FixConditionField(Conversation conversation)
		{
		}

		private static void FixInstructionField(Conversation conversation)
		{
		}

		public static void ImportFieldsToConversation(Conversation conversation, FeldFlow feldFlow)
		{
		}

		public static void ImportFieldsToConversation(Conversation conversation, FeldCard feldCard)
		{
		}

		private static void AppendInputExpressions(Conversation conversation, FeldCard feldCard)
		{
		}

		private static void AppendCardExpressions(Conversation conversation, FeldCard feldCard)
		{
		}

		private static void AppendOutputExpressions(Conversation conversation, FeldCard feldCard, string outputLabel = "")
		{
		}

		private static void AssignActorToConversation(FeldCard card, Conversation conversation)
		{
		}

		private static void AssignConversantToConversation(FeldCard card, Conversation conversation)
		{
		}
	}
}
