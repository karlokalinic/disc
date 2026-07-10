using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Language.Lua;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public static class PersistentDataManager
	{
		public enum RecordPersistentDataOn
		{
			AllGameObjects = 0,
			OnlyRegisteredGameObjects = 1,
			NoGameObjects = 2
		}

		public class AsyncSaveOperation
		{
			public bool isDone;

			public string content;
		}

		public class AsyncRawDataOperation
		{
			public bool isDone;

			public byte[] content;
		}

		public static bool includeActorData;

		public static bool includeAllItemData;

		public static bool includeLocationData;

		public static bool includeAllConversationFields;

		public static bool includeSimStatus;

		public static string saveConversationSimStatusWithField;

		public static string saveDialogueEntrySimStatusWithField;

		public static bool includeRelationshipAndStatusData;

		public static bool initializeNewVariables;

		public static bool initializeNewSimStatus;

		public static GetCustomSaveDataDelegate GetCustomSaveData;

		public static RecordPersistentDataOn recordPersistentDataOn;

		private static HashSet<GameObject> listeners;

		private static bool useConversationID;

		private static bool useEntryID;

		private static Dictionary<int, string> s_dialogueEntrySimStatusFieldLookupTable;

		public static int asyncGameObjectBatchSize;

		public static int asyncDialogueEntryBatchSize;

		public static void RegisterPersistentData(GameObject go)
		{
		}

		public static void UnregisterPersistentData(GameObject go)
		{
		}

		public static void Reset(DatabaseResetOptions databaseResetOptions)
		{
		}

		public static void Reset()
		{
		}

		public static void Record()
		{
		}

		public static void Apply()
		{
		}

		private static void SendPersistentDataMessage(string message)
		{
		}

		public static void LevelWillBeUnloaded()
		{
		}

		public static void ApplySaveData(string saveData, DatabaseResetOptions databaseResetOptions = DatabaseResetOptions.KeepAllLoaded)
		{
		}

		public static string GetSaveData()
		{
			return null;
		}

		public static void AppendDialogueSystemData(StringBuilder sb)
		{
		}

		public static void AppendVariableData(StringBuilder sb)
		{
		}

		public static void AppendItemData(StringBuilder sb)
		{
		}

		private static void AppendFields(StringBuilder sb, LuaTableWrapper fields)
		{
		}

		private static string GetFieldKeyString(string key)
		{
			return null;
		}

		private static bool IsValidVarName(string key)
		{
			return false;
		}

		private static string GetFieldValueString(object o)
		{
			return null;
		}

		public static void AppendLocationData(StringBuilder sb)
		{
		}

		public static void AppendActorData(StringBuilder sb)
		{
		}

		private static void AppendAssetFieldData(StringBuilder sb, LuaTableWrapper fields)
		{
		}

		public static void AppendRelationshipAndStatusTables(StringBuilder sb)
		{
		}

		public static void RefreshRelationshipAndStatusTablesFromLua()
		{
		}

		public static void AppendConversationData(StringBuilder sb)
		{
		}

		private static void AppendAllConversationFields(StringBuilder sb)
		{
		}

		private static void AppendSimStatus(StringBuilder sb)
		{
		}

		private static int AppendSimStatusForConversation(StringBuilder sb, LuaTable conversationTable, int conversationID, LuaTable fieldTable)
		{
			return 0;
		}

		private static void ExpandCompressedSimStatusData()
		{
		}

		private static void ExpandSimStatusForConversation(StringBuilder sb, int conversationID, string conversationIDString, LuaTable fieldTable, LuaString luaStringSimX, Dictionary<int, DialogueEntry> dialogueEntryCache)
		{
		}

		private static char SimStatusToChar(string simStatus)
		{
			return '\0';
		}

		private static string CharToSimStatus(char c)
		{
			return null;
		}

		public static void InitializeNewVariablesFromDatabase()
		{
		}

		public static void InitializeNewQuestEntriesFromDatabase()
		{
		}

		public static void InitializeNewSimStatusFromDatabase()
		{
		}

		public static AsyncSaveOperation GetSaveDataAsync()
		{
			return null;
		}

		private static IEnumerator GetSaveDataAsyncCoroutine(AsyncSaveOperation asyncOp)
		{
			return null;
		}

		public static void RecordAsync()
		{
		}

		private static IEnumerator AppendConversationDataAsync(StringBuilder sb)
		{
			return null;
		}

		public static MemoryStream GetRawData(MemoryStream stream)
		{
			return null;
		}

		private static void WriteValue(BinaryWriter writer, LuaValue value)
		{
		}

		private static void WriteTable(BinaryWriter writer, LuaTable table)
		{
		}

		public static void ApplyRawData(byte[] bytes)
		{
		}

		private static LuaValue ReadValue(BinaryReader reader)
		{
			return null;
		}

		private static void ReadTable(BinaryReader reader, LuaTable table)
		{
		}

		private static void WriteExtraData(BinaryWriter writer)
		{
		}

		private static void ApplyExtraData(BinaryReader reader)
		{
		}

		private static void PrepSimStatusForRawData(LuaTable conversationTable)
		{
		}

		private static IEnumerator PrepSimStatusForRawDataAsync(LuaTable conversationTable)
		{
			return null;
		}

		private static int PrepConversationSimStatusForRawData(LuaTable conversationTable, int conversationID, LuaTable fieldTable, Dictionary<int, DialogueEntry> dialogueEntryCache, StringBuilder sb)
		{
			return 0;
		}

		private static void ApplySimStatusFromRawData()
		{
		}
	}
}
