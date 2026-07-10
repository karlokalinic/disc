using System.Collections.Generic;

namespace PixelCrushers.DialogueSystem
{
	public static class DatabaseMerger
	{
		public enum ConflictingIDRule
		{
			ReplaceConflictingIDs = 0,
			AllowConflictingIDs = 1,
			AssignUniqueIDs = 2
		}

		private class NewIDs
		{
			public bool destinationHasPlayerActor;

			public bool destinationHasAlertVariable;

			public Dictionary<int, int> actor;

			public Dictionary<int, int> item;

			public Dictionary<int, int> location;

			public Dictionary<int, int> variable;

			public Dictionary<int, int> conversation;
		}

		public static void Merge(DialogueDatabase destination, DialogueDatabase source, ConflictingIDRule conflictingIDRule, bool mergeProperties, bool mergeActors, bool mergeItems, bool mergeLocations, bool mergeVariables, bool mergeConversations)
		{
		}

		public static void Merge(DialogueDatabase destination, DialogueDatabase source, ConflictingIDRule conflictingIDRule)
		{
		}

		private static void MergeDatabaseProperties(DialogueDatabase destination, DialogueDatabase source)
		{
		}

		private static void MergeReplaceConflictingIDs(DialogueDatabase destination, DialogueDatabase source, bool mergeProperties, bool mergeActors, bool mergeItems, bool mergeLocations, bool mergeVariables, bool mergeConversations)
		{
		}

		private static void MergeActorsReplaceConflictingIDs(DialogueDatabase destination, DialogueDatabase source)
		{
		}

		private static void MergeItemsReplaceConflictingIDs(DialogueDatabase destination, DialogueDatabase source)
		{
		}

		private static void MergeLocationsReplaceConflictingIDs(DialogueDatabase destination, DialogueDatabase source)
		{
		}

		private static void MergeVariablesReplaceConflictingIDs(DialogueDatabase destination, DialogueDatabase source)
		{
		}

		private static void MergeConversationsReplaceConflictingIDs(DialogueDatabase destination, DialogueDatabase source)
		{
		}

		private static void MergeAllowConflictingIDs(DialogueDatabase destination, DialogueDatabase source, bool mergeProperties, bool mergeActors, bool mergeItems, bool mergeLocations, bool mergeVariables, bool mergeConversations)
		{
		}

		private static void MergeActorsAllowConflictingIDs(DialogueDatabase destination, DialogueDatabase source)
		{
		}

		private static void MergeItemsAllowConflictingIDs(DialogueDatabase destination, DialogueDatabase source)
		{
		}

		private static void MergeLocationsAllowConflictingIDs(DialogueDatabase destination, DialogueDatabase source)
		{
		}

		private static void MergeVariablesAllowConflictingIDs(DialogueDatabase destination, DialogueDatabase source)
		{
		}

		private static void MergeConversationsAllowConflictingIDs(DialogueDatabase destination, DialogueDatabase source)
		{
		}

		private static void MergeAssignUniqueIDs(DialogueDatabase destination, DialogueDatabase source, bool mergeProperties, bool mergeActors, bool mergeItems, bool mergeLocations, bool mergeVariables, bool mergeConversations)
		{
		}

		private static void GetNewActorIDs(DialogueDatabase destination, DialogueDatabase source, NewIDs newIDs)
		{
		}

		private static void GetNewItemIDs(DialogueDatabase destination, DialogueDatabase source, NewIDs newIDs)
		{
		}

		private static void GetNewLocationIDs(DialogueDatabase destination, DialogueDatabase source, NewIDs newIDs)
		{
		}

		private static void GetNewVariableIDs(DialogueDatabase destination, DialogueDatabase source, NewIDs newIDs)
		{
		}

		private static void GetNewConversationIDs(DialogueDatabase destination, DialogueDatabase source, NewIDs newIDs)
		{
		}

		private static void ConvertFieldIDs(List<Field> fields, NewIDs newIDs)
		{
		}

		private static void MergeActors(DialogueDatabase destination, DialogueDatabase source, NewIDs newIDs)
		{
		}

		private static void MergeItems(DialogueDatabase destination, DialogueDatabase source, NewIDs newIDs)
		{
		}

		private static void MergeLocations(DialogueDatabase destination, DialogueDatabase source, NewIDs newIDs)
		{
		}

		private static void MergeVariables(DialogueDatabase destination, DialogueDatabase source, NewIDs newIDs)
		{
		}

		private static void MergeConversations(DialogueDatabase destination, DialogueDatabase source, NewIDs newIDs)
		{
		}
	}
}
