using System.Collections.Generic;

namespace PixelCrushers.DialogueSystem
{
	public static class QuestLog
	{
		public delegate void QuestChangedDelegate(string questName, QuestState newState);

		public class QuestWatchItem
		{
			private string questName;

			private int entryNumber;

			private LuaWatchFrequency frequency;

			private string luaExpression;

			private QuestChangedDelegate questChangedHandler;

			public QuestWatchItem(string questName, LuaWatchFrequency frequency, QuestChangedDelegate questChangedHandler)
			{
			}

			public QuestWatchItem(string questName, int entryNumber, LuaWatchFrequency frequency, QuestChangedDelegate questChangedHandler)
			{
			}

			public bool Matches(string questName, LuaWatchFrequency frequency, QuestChangedDelegate questChangedHandler)
			{
				return false;
			}

			public bool Matches(string questName, int entryNumber, LuaWatchFrequency frequency, QuestChangedDelegate questChangedHandler)
			{
				return false;
			}

			public void StopObserving()
			{
			}

			private void OnLuaChanged(LuaWatchItem luaWatchItem, Lua.Result newResult)
			{
			}
		}

		public const string UnassignedStateString = "unassigned";

		public const string ActiveStateString = "active";

		public const string SuccessStateString = "success";

		public const string FailureStateString = "failure";

		public const string AbandonedStateString = "abandoned";

		public const string DoneStateString = "done";

		public static StringToQuestStateDelegate StringToState;

		public static CurrentQuestStateDelegate CurrentQuestStateOverride;

		public static SetQuestStateDelegate SetQuestStateOverride;

		public static CurrentQuestEntryStateDelegate CurrentQuestEntryStateOverride;

		public static SetQuestEntryStateDelegate SetQuestEntryStateOverride;

		public static bool trackOneQuestAtATime;

		private static readonly List<QuestWatchItem> questWatchList;

		public static void RegisterQuestLogFunctions()
		{
		}

		public static void AddQuest(string questName, string description, string successDescription, string failureDescription, QuestState state)
		{
		}

		public static void AddQuest(string questName, string description, QuestState state)
		{
		}

		public static void AddQuest(string questName, string description)
		{
		}

		public static void DeleteQuest(string questName)
		{
		}

		public static QuestState GetQuestState(string questName)
		{
			return default(QuestState);
		}

		public static string CurrentQuestState(string questName)
		{
			return null;
		}

		public static string DefaultCurrentQuestState(string questName)
		{
			return null;
		}

		public static void SetQuestState(string questName, QuestState state)
		{
		}

		public static void SetQuestState(string questName, string state)
		{
		}

		public static void DefaultSetQuestState(string questName, string state)
		{
		}

		private static void SendUpdateTracker()
		{
		}

		public static void InformQuestStateChange(string questName)
		{
		}

		public static void InformQuestEntryStateChange(string questName, int entryNumber)
		{
		}

		public static bool IsQuestUnassigned(string questName)
		{
			return false;
		}

		public static bool IsQuestActive(string questName)
		{
			return false;
		}

		public static bool IsQuestSuccessful(string questName)
		{
			return false;
		}

		public static bool IsQuestFailed(string questName)
		{
			return false;
		}

		public static bool IsQuestAbandoned(string questName)
		{
			return false;
		}

		public static bool IsQuestDone(string questName)
		{
			return false;
		}

		public static bool IsQuestInStateMask(string questName, QuestState stateMask)
		{
			return false;
		}

		public static void StartQuest(string questName)
		{
		}

		public static void CompleteQuest(string questName)
		{
		}

		public static void FailQuest(string questName)
		{
		}

		public static void AbandonQuest(string questName)
		{
		}

		public static QuestState DefaultStringToState(string s)
		{
			return default(QuestState);
		}

		public static string StateToString(QuestState state)
		{
			return null;
		}

		public static string GetQuestTitle(string questName)
		{
			return null;
		}

		public static string GetQuestDescription(string questName)
		{
			return null;
		}

		public static string GetQuestDescription(string questName, QuestState state)
		{
			return null;
		}

		private static string GetDefaultDescriptionFieldForState(QuestState state)
		{
			return null;
		}

		public static void SetQuestDescription(string questName, QuestState state, string description)
		{
		}

		public static string GetQuestAbandonSequence(string questName)
		{
			return null;
		}

		public static void SetQuestAbandonSequence(string questName, string sequence)
		{
		}

		public static int GetQuestEntryCount(string questName)
		{
			return 0;
		}

		public static void AddQuestEntry(string questName, string description)
		{
		}

		public static string GetQuestEntry(string questName, int entryNumber)
		{
			return null;
		}

		public static void SetQuestEntry(string questName, int entryNumber, string description)
		{
		}

		public static QuestState GetQuestEntryState(string questName, int entryNumber)
		{
			return default(QuestState);
		}

		public static string CurrentQuestEntryState(string questName, double entryNumber)
		{
			return null;
		}

		public static string DefaultCurrentQuestEntryState(string questName, int entryNumber)
		{
			return null;
		}

		public static void SetQuestEntryState(string questName, int entryNumber, QuestState state)
		{
		}

		public static void SetQuestEntryState(string questName, double entryNumber, string state)
		{
		}

		public static void DefaultSetQuestEntryState(string questName, int entryNumber, string state)
		{
		}

		public static string GetEntryFieldName(int entryNumber)
		{
			return null;
		}

		public static string GetEntryStateFieldName(int entryNumber)
		{
			return null;
		}

		public static bool IsQuestTrackingAvailable(string questName)
		{
			return false;
		}

		public static void SetQuestTrackingAvailable(string questName, bool value)
		{
		}

		public static bool IsQuestTrackingEnabled(string questName)
		{
			return false;
		}

		public static void SetQuestTracking(string questName, bool value)
		{
		}

		public static bool IsQuestAbandonable(string questName)
		{
			return false;
		}

		public static string GetQuestGroup(string questName)
		{
			return null;
		}

		public static string[] GetAllGroups()
		{
			return null;
		}

		public static string[] GetAllGroups(QuestState flags)
		{
			return null;
		}

		public static string[] GetAllGroups(QuestState flags, bool sortByGroupName)
		{
			return null;
		}

		public static string[] GetAllQuests()
		{
			return null;
		}

		public static string[] GetAllQuests(QuestState flags)
		{
			return null;
		}

		public static string[] GetAllQuests(QuestState flags, bool sortByName)
		{
			return null;
		}

		public static string[] GetAllQuests(QuestState flags, bool sortByName, string group)
		{
			return null;
		}

		public static QuestGroupRecord[] GetAllGroupsAndQuests(QuestState flags, bool sort = true)
		{
			return null;
		}

		public static void AddQuestStateObserver(string questName, LuaWatchFrequency frequency, QuestChangedDelegate questChangedHandler)
		{
		}

		public static void AddQuestStateObserver(string questName, int entryNumber, LuaWatchFrequency frequency, QuestChangedDelegate questChangedHandler)
		{
		}

		public static void RemoveQuestStateObserver(string questName, LuaWatchFrequency frequency, QuestChangedDelegate questChangedHandler)
		{
		}

		public static void RemoveQuestStateObserver(string questName, int entryNumber, LuaWatchFrequency frequency, QuestChangedDelegate questChangedHandler)
		{
		}

		public static void RemoveAllQuestStateObservers()
		{
		}
	}
}
