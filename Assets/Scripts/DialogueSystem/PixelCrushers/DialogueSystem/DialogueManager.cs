using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public static class DialogueManager
	{
		private static DialogueSystemController m_instance;

		public static DialogueSystemController instance => null;

		public static bool hasInstance => false;

		public static DatabaseManager databaseManager => null;

		public static DialogueDatabase masterDatabase => null;

		public static IDialogueUI dialogueUI
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static DisplaySettings displaySettings => null;

		public static bool isConversationActive => false;

		public static bool allowSimultaneousConversations => false;

		public static IsDialogueEntryValidDelegate isDialogueEntryValid
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static GetInputButtonDownDelegate getInputButtonDown
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static Transform currentActor => null;

		public static Transform currentConversant => null;

		public static ConversationState currentConversationState => null;

		public static string lastConversationStarted => null;

		public static int lastConversationID => 0;

		public static ConversationController conversationController => null;

		public static ConversationModel conversationModel => null;

		public static ConversationView conversationView => null;

		public static DialogueDebug.DebugLevel debugLevel
		{
			get
			{
				return default(DialogueDebug.DebugLevel);
			}
			set
			{
			}
		}

		public static bool allowLuaExceptions
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static DialogueSystemController Instance => null;

		public static bool HasInstance => false;

		public static DatabaseManager DatabaseManager => null;

		public static DialogueDatabase MasterDatabase => null;

		public static IDialogueUI DialogueUI
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static DisplaySettings DisplaySettings => null;

		public static bool IsConversationActive => false;

		public static bool AllowSimultaneousConversations => false;

		public static IsDialogueEntryValidDelegate IsDialogueEntryValid
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static GetInputButtonDownDelegate GetInputButtonDown
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static Transform CurrentActor => null;

		public static Transform CurrentConversant => null;

		public static ConversationState CurrentConversationState => null;

		public static string LastConversationStarted => null;

		public static int LastConversationID => 0;

		public static ConversationController ConversationController => null;

		public static ConversationModel ConversationModel => null;

		public static ConversationView ConversationView => null;

		public static DialogueDebug.DebugLevel DebugLevel
		{
			get
			{
				return default(DialogueDebug.DebugLevel);
			}
			set
			{
			}
		}

		public static bool AllowLuaExceptions
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static void SetLanguage(string language)
		{
		}

		public static void SetDialogueSystemInput(bool value)
		{
		}

		public static bool IsDialogueSystemInputDisabled()
		{
			return false;
		}

		public static void AddDatabase(DialogueDatabase database)
		{
		}

		public static void RemoveDatabase(DialogueDatabase database)
		{
		}

		public static void ResetDatabase(DatabaseResetOptions databaseResetOptions)
		{
		}

		public static void ResetDatabase()
		{
		}

		public static void PreloadMasterDatabase()
		{
		}

		public static void PreloadDialogueUI()
		{
		}

		public static bool ConversationHasValidEntry(string title, Transform actor, Transform conversant)
		{
			return false;
		}

		public static bool ConversationHasValidEntry(string title, Transform actor)
		{
			return false;
		}

		public static bool ConversationHasValidEntry(string title)
		{
			return false;
		}

		public static void StartConversation(string title, Transform actor, Transform conversant, int initialDialogueEntryID)
		{
		}

		public static void StartConversation(string title, Transform actor, Transform conversant)
		{
		}

		public static void StartConversation(string title, Transform actor)
		{
		}

		public static void StartConversation(string title)
		{
		}

		public static void StopConversation()
		{
		}

		public static void UpdateResponses()
		{
		}

		public static void Bark(string conversationTitle, Transform speaker, Transform listener, BarkHistory barkHistory)
		{
		}

		public static void Bark(string conversationTitle, Transform speaker, Transform listener)
		{
		}

		public static void Bark(string conversationTitle, Transform speaker)
		{
		}

		public static void Bark(string conversationTitle, Transform speaker, BarkHistory barkHistory)
		{
		}

		public static void BarkString(string barkText, Transform speaker, Transform listener = null, string sequence = null)
		{
		}

		public static float GetBarkDuration(string barkText)
		{
			return 0f;
		}

		public static void ShowAlert(string message, float duration)
		{
		}

		public static void ShowAlert(string message)
		{
		}

		public static void CheckAlerts()
		{
		}

		public static void HideAlert()
		{
		}

		public static string GetLocalizedText(string s)
		{
			return null;
		}

		public static Sequencer PlaySequence(string sequence, Transform speaker, Transform listener, bool informParticipants, bool destroyWhenDone, string entrytag)
		{
			return null;
		}

		public static Sequencer PlaySequence(string sequence, Transform speaker, Transform listener, bool informParticipants, bool destroyWhenDone)
		{
			return null;
		}

		public static Sequencer PlaySequence(string sequence, Transform speaker, Transform listener, bool informParticipants)
		{
			return null;
		}

		public static Sequencer PlaySequence(string sequence, Transform speaker, Transform listener)
		{
			return null;
		}

		public static Sequencer PlaySequence(string sequence)
		{
			return null;
		}

		public static void StopSequence(Sequencer sequencer)
		{
		}

		public static void Pause()
		{
		}

		public static void Unpause()
		{
		}

		public static void UseDialogueUI(GameObject gameObject)
		{
		}

		public static void SetPortrait(string actorName, string portraitName)
		{
		}

		public static void AddLuaObserver(string luaExpression, LuaWatchFrequency frequency, LuaChangedDelegate luaChangedHandler)
		{
		}

		public static void RemoveLuaObserver(string luaExpression, LuaWatchFrequency frequency, LuaChangedDelegate luaChangedHandler)
		{
		}

		public static void RemoveAllObservers(LuaWatchFrequency frequency)
		{
		}

		public static void RemoveAllObservers()
		{
		}

		public static void RegisterAssetBundle(AssetBundle bundle)
		{
		}

		public static void UnregisterAssetBundle(AssetBundle bundle)
		{
		}

		public static UnityEngine.Object LoadAsset(string name)
		{
			return null;
		}

		public static UnityEngine.Object LoadAsset(string name, Type type)
		{
			return null;
		}

		public static void SendUpdateTracker()
		{
		}
	}
}
